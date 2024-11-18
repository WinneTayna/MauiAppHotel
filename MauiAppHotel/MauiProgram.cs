using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("RedHatDisplay-Black.ttf", "RedHatDisplayBlack");
                    fonts.AddFont("RedHatDisplay-BlackItalic.ttf", "RedHatDisplayBlackItalic");
                    fonts.AddFont("RedHatDisplay-Bold.ttf", "RedHatDisplayBold");
                    fonts.AddFont("RedHatDisplay-BoldItalic.ttf", "RedHatDisplayBoldItalic");
                    fonts.AddFont("RedHatDisplay-ExtraBold.ttf", "RedHatDisplayExtraBold");
                    fonts.AddFont("RedHatDisplay-ExtraBoldItalic.ttf", "RedHatDisplayExtraBoldItalic");
                    fonts.AddFont("RedHatDisplay-Italic.ttf", "RedHatDisplayItalic");
                    fonts.AddFont("RedHatDisplay-Light.ttf", "RedHatDisplayLight");
                    fonts.AddFont("RedHatDisplay-LightItalic.ttf", "RedHatDisplayLightItalic");
                    fonts.AddFont("RedHatDisplay-Medium.ttf", "RedHatDisplayMedium");
                    fonts.AddFont("RedHatDisplay-MediumItalic.ttf", "RedHatDisplayMediumItalic");
                    fonts.AddFont("RedHatDisplay-Regular.ttf", "RedHatDisplayRegular");
                    fonts.AddFont("RedHatDisplay-SemiBold.ttf", "RedHatDisplaySemiBold");
                    fonts.AddFont("RedHatDisplay-SemiBoldItalic.ttf", "RedHatDisplaySemiBoldItalic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
