using Tiveriad.Connections;
using Tiveriad.EnterpriseIntegrationPatterns.RabbitMq;
using Tiveriad.EnterpriseIntegrationPatterns.RabbitMq.EventBrokers;
using Tiveriad.Multitenancy.Core.DomainEvents;
using IConnection = RabbitMQ.Client.IConnection;

namespace Multitenancy.Integration.Infrastructure.Publishers;

public class MembershipDomainEventPublisher: RabbitMqPublisher<MembershipDomainEvent, string>
{
    public MembershipDomainEventPublisher(
        IConnectionFactory<IConnection> connectionFactory,
        IRabbitMqConnectionConfiguration configuration,
        string eventName,
        ILogger<MembershipDomainEventPublisher> logger) : base(connectionFactory, configuration, eventName, logger)
    {
    }
}