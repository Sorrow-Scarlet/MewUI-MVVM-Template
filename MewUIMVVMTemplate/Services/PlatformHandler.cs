using Aprillz.MewUI;

namespace MewUIMVVMTemplate.Services;

public class PlatformHandler
{
    public static void RegisterPlatform()
    {
        if (OperatingSystem.IsWindows())
        {
            Win32Platform.Register();
            Direct2DBackend.Register();
        }
        if (OperatingSystem.IsLinux())
        {
            X11Platform.Register();
            MewVGX11Backend.Register();
        }
        if (OperatingSystem.IsMacOS())
        {
            MacOSPlatform.Register();
            MewVGX11Backend.Register();
        }
    }
}
