using System.Text.Json;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using Tiveriad.Commons.RetryLogic;
using Tiveriad.Connections;
using Tiveriad.EnterpriseIntegrationPatterns.EventBrokers;
using Tiveriad.EnterpriseIntegrationPatterns.MessageBrokers;

namespace Tiveriad.EnterpriseIntegrationPatterns.RabbitMq.EventBrokers;

public class RabbitMqPublisher<TEvent,TKey>:IPublisher<TEvent,TKey> where TEvent:IDomainEvent < TKey> 
    where TKey : IEquatable<TKey>
{
    private readonly IConnectionFactory<IConnection> _connectionFactory;
    private readonly ILogger<RabbitMqPublisher<TEvent,TKey>> _logger;
    private readonly IRabbitMqConnectionConfiguration _configuration;
    private readonly string _eventName;

    public RabbitMqPublisher(IConnectionFactory<IConnection> connectionFactory, IRabbitMqConnectionConfiguration configuration, string eventName, ILogger<RabbitMqPublisher<TEvent, TKey>> logger)
    {
        _connectionFactory = connectionFactory;
        _logger = logger;
        _eventName = eventName;
        _configuration = configuration;
    }

    public Task Publish(IDomainEvent<TKey> @event, CancellationToken cancellationToken)
    {
        var connection = _connectionFactory.GetConnection();
        _logger.LogTrace("Creating RabbitMQ channel to publish event: {EventId} ({EventName})", @event.Id, _eventName);
        
        var channel = connection.CreateModel();
        _logger.LogTrace("Declaring RabbitMQ exchange to publish event: {EventId}", @event.Id);
        channel.ExchangeDeclare(exchange:_configuration.BrokerName , type: ExchangeType.Direct, true);
        var body = JsonSerializer.SerializeToUtf8Bytes(@event, @event.GetType(), new JsonSerializerOptions
        {
            WriteIndented = true
        });
        Retry.On<Exception>().For(3).Execute(context =>
        {
            if (context.Exceptions.Count > 1)
                connection = _connectionFactory.GetConnection();
            var properties = channel.CreateBasicProperties();
            properties.DeliveryMode = 2; // persistent
            _logger.LogTrace("Publishing event to RabbitMQ: {EventId}", @event.Id);
            channel.BasicPublish(
                exchange: _configuration.BrokerName,
                routingKey: _eventName,
                mandatory: true,
                basicProperties: properties,
                body: body);
        });
        return Task.CompletedTask;
    }
}