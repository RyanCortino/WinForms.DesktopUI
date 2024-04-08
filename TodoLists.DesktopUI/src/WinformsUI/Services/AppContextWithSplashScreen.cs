using Microsoft.Extensions.Logging;

namespace WinformsUI.Services;

internal class AppContextWithSplashScreen(
    ILogger<AppContextWithSplashScreen> logger,
    ISplashView splashView,
    IMainView mainView
) : ApplicationContext(splashView as Form)
{
    private readonly ILogger _logger = logger;

    private readonly IMainView _mainView = mainView;

    protected override void OnMainFormClosed(object? sender, EventArgs e)
    {
        if (sender is ISplashView)
        {
            LaunchMainForm();

            return;
        }

        _logger.LogInformation("Exiting Application.");

        base.OnMainFormClosed(sender, e);
    }

    private void LaunchMainForm()
    {
        MainForm = _mainView as Form;

        MainForm?.Show();
    }
}
