using Aprillz.MewUI;
using Aprillz.MewUI.Controls;
using MewUIMVVMTemplate.Services;
using MewUIMVVMTemplate.ViewModels;
using MewUIMVVMTemplate.Views;

// Here for Hot Reload Reflection
#if DEBUG
[assembly: System.Reflection.Metadata.MetadataUpdateHandler(
    typeof(Aprillz.MewUI.HotReload.MewUiMetadataUpdateHandler)
)]

#endif
namespace MewUIMVVMTemplate;

class Program
{
    // Icon & Title change here
    public static IconSource Icon { get; set; } = IconSource.FromResource<MainView>("app.ico");
    public static string Title { get; set; } = "MewUIMVVMTemplate";

    [STAThread]
    static void Main()
    {
        Build();
    }

    static void Build()
    {
        // Register platforms and render backends;
        PlatformHandler.RegisterPlatform();
        BuildWindow();
    }

    static void BuildWindow()
    {
        var view = new MainView(new MainVM());
        var window = new Window().OnBuild(x =>
        {
            x.Content(view).Resizable(480, 480);
            x.Icon(Icon).Title(Title);
            x.OnLoaded(() => { }).OnClosed(() => { });
            x.Padding(8).Content(view);
        });
        Application.Run(window);
    }
}
