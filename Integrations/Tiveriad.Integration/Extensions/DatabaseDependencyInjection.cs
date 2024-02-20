#region

using Microsoft.EntityFrameworkCore;
using Tiveriad.Documents.Core.Entities;
using Tiveriad.Identities.Core.Entities;
using Tiveriad.Integration.Persistence;
using Tiveriad.Notifications.Core.Entities;
using Tiveriad.Registrations.Core.Entities;
using Tiveriad.Repositories.EntityFrameworkCore.Repositories;
using Tiveriad.Repositories.Microsoft.DependencyInjection;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

#endregion

namespace Tiveriad.Integration.Extensions;

public static class DatabaseDependencyInjection
{
    public static IServiceCollection AddDatabase(this IServiceCollection servicesCollection)
    {
        servicesCollection.AddDbContextPool<DbContext, DefaultContext>(options =>
        {
            
            var hostingEnvironment = servicesCollection.BuildServiceProvider().GetRequiredService<IHostingEnvironment>();
            
            var logger = servicesCollection.BuildServiceProvider().GetService<ILogger<DefaultContext>>();
            if (logger != null)
                options.LogTo(message => { logger.LogInformation(message); }).EnableSensitiveDataLogging()
                    .EnableDetailedErrors();

            var databasePath = Path.Combine(hostingEnvironment.ContentRootPath, "database.db");
            options.UseSqlite($"Data Source={databasePath}");
        });

        servicesCollection.AddRepositories(typeof(EFRepository<,>),
            typeof(DocumentDescription).Assembly,
            typeof(Notification).Assembly,
            typeof(User).Assembly, typeof(Registration).Assembly);
        ;

        var serviceProvider = servicesCollection.BuildServiceProvider();
        var defaultContext = serviceProvider.GetRequiredService<DbContext>();
        var sql = defaultContext.Database.EnsureCreated();


        return servicesCollection;
    }
}