using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace BeautifulPlacesApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
				fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
			});
		
		// Убираю нижнюю полоску у Entry в Android app
#if  ANDROID
		EntryHandler.PlatformViewFactory = (h) =>
		{
			var entry = new AndroidX.AppCompat.Widget.AppCompatEditText(h.Context);
			entry.Background = null;
			entry.SetBackgroundColor(Android.Graphics.Color.Transparent);
			return entry;
		};
#endif

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
