using Bookify.Application.Abstractions.Behaviors;
using Bookify.Domain.Bookings;
using Microsoft.Extensions.DependencyInjection;

namespace Bookify.Application;

public static class DependencyInjection
{

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(conciguration =>
        {
            conciguration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            conciguration.AddOpenBehavior(typeof(LoggingBehavior<,>));
            conciguration.AddOpenBehavior(typeof(ValidationBehavior<,>));
            conciguration.AddOpenBehavior(typeof(QueryCachingBehavior<,>));
        });

        services.AddTransient<PricingService>();

        return services;
    }
}
