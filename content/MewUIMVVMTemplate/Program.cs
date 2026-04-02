using Aprillz.MewUI;
using Aprillz.MewUI.Controls;
using MewUIMVVMTemplate.Services;
using MewUIMVVMTemplate.ViewModels;
using MewUIMVVMTemplate.Views;

// Here for hot reload reflection
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
        // Use new Window() to create a normal window
        // NOTE: While using NativeCustomWindow
        // DO NOT ADD PADDING directly to `x` or the button will glitch
        var window = new NativeCustomWindow().OnBuild(x =>
        {
            x.Content(view).Resizable(480, 480);
            x.Icon(Icon).Title(Title);
            x.OnLoaded(() => { }).OnClosed(() => { });
        });
        Application.Run(window);
    }
}
