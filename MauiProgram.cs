namespace CodexGigas;

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
			});
#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasViewModel>();

		builder.Services.AddSingleton<InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasPage>();

		builder.Services.AddSingleton<IntegracionNumericaViewModel>();

		builder.Services.AddSingleton<IntegracionNumericaPage>();

		builder.Services.AddSingleton<EcuacionesPolinomialesViewModel>();

		builder.Services.AddSingleton<EcuacionesPolinomialesPage>();

		builder.Services.AddSingleton<EcuacionesNoLinealesNoPolinomialesViewModel>();

		builder.Services.AddSingleton<EcuacionesNoLinealesNoPolinomialesPage>();

		builder.Services.AddSingleton<EcuacionesDiferencialesOrdinariasParcialesViewModel>();

		builder.Services.AddSingleton<EcuacionesDiferencialesOrdinariasParcialesPage>();

		return builder.Build();
	}
}
