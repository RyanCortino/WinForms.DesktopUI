using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WinformsUI.Forms;

public partial class SplashForm : Form, ISplashView, IProgress<string>
{
    public SplashForm(ILogger<SplashForm> logger, IOptions<ApplicationOptions> appOptions)
    {
        _logger = logger;
        _logger.LogInformation("Initializing Splash Form Components.");

        _appOptions = appOptions.Value;

        InitializeComponent();
    }

    private readonly ILogger _logger;

    private readonly ApplicationOptions _appOptions;

    public void InitializeView()
    {
        VersionLabel.Text = CoreAssembly.Version.ToString();
    }

    public void Report(string value)
    {
        _logger.LogInformation("{message}", value);

        this.StatusLabel.Text = value;
    }

    private async void SplashView_Load(object sender, EventArgs e)
    {
        InitializeView();

        this.ProgressBar.ProgressBar.Step = 10;

        // Load Resources and close when  the default delay is expired and loading has completed.
        await Task.Run(() =>
        {
            Report("Loading resources...");

            var loadingTasks = new[]
            {
                Task.Run(() => DelaySplashScreenAsync()),
                Task.Run(() => LoadResourcesAsync()),
                Task.Run(() => LoadResourcesAsync()),
                Task.Run(() => LoadResourcesAsync())
            };

            Task.WaitAll(loadingTasks);

            Report("Loading complete.");
        });

        Close();
    }

    private async Task DelaySplashScreenAsync()
    {
        await Task.Delay((int)(_appOptions.DefaultSplashScreenDelay * 1000));

        Report("Default delay timer has expired.");
    }

    private async Task LoadResourcesAsync()
    {
        await Task.Delay(1000);

        Report("Resources loaded.");
    }
}
