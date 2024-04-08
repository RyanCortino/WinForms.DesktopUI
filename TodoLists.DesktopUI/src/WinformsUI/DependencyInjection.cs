using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddDesktopServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // Config
        _ = services.Configure<ApplicationOptions>(
            configuration.GetSection(ApplicationOptions.SectionName)
        );

        // Views
        services.AddTransient<ISplashView, SplashForm>();
        services.AddTransient<IMainView, MainForm>();

        // Presenters
        services.AddTransient<SplashPresenter>();

        return services;
    }
}
