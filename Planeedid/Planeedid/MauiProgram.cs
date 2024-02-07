namespace Planeedid;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
				fonts.AddFont("Montserrat-Semibold.ttf", "MontserratMedium");
                fonts.AddFont("Montserrat-Medium.ttf", "MontserratRegular");
            });

		return builder.Build();
	}
}
