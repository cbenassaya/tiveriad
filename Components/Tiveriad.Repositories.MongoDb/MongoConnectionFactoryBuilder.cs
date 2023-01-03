using MongoDB.Driver;

namespace Tiveriad.Repositories.MongoDb;

public class MongoConnectionFactoryBuilder
{
    private MongoConnectionConfigurator _configurator;
    
    public MongoConnectionFactoryBuilder Configure(Action<MongoConnectionConfigurator> action)
    {
        _configurator = new MongoConnectionConfigurator();
        action(_configurator);
        return this;
    }
    
    public IConnectionFactory<IMongoDatabase> Build()
    {
        var client = string.IsNullOrEmpty(_configurator.ConnectionString) ? new MongoClient(_configurator.Build()): new MongoClient(_configurator.ConnectionString);
        return new MongoConnectionFactory(client, client.GetDatabase(_configurator.DatabaseName));
    }
    
}