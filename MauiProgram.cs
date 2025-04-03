using CodexGigas.Services;
using CodexGigas.ViewModels.EcuacionesDiferenciales.MetodosDeUnPaso;
using CodexGigas.ViewModels.EcuacionesNoLinealesNoPolinomiales;
using CodexGigas.ViewModels.EcuacionesPolinomiales;
using CodexGigas.ViewModels.IntegracionNumerica;
using CodexGigas.ViewModels.InterpolacionPolinomial;
using CodexGigas.Views.EcuacionesDiferenciales.MetodosDeUnPaso;
using CodexGigas.Views.EcuacionesNoLinealesNoPolinomiales;
using CodexGigas.Views.EcuacionesPolinomiales;
using CodexGigas.Views.IntegracionNumerica;
using CommunityToolkit.Maui;

namespace CodexGigas;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			// Initialize the .NET MAUI Community Toolkit by adding the below line of code
			.UseMauiCommunityToolkit()
			// After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if DEBUG
		builder.Logging.AddDebug();
#endif

        //Servicio de datos
        builder.Services.AddSingleton<IDataServices, DataServices>();
        builder.Services.AddSingleton<HttpClient>();

        //Armar metodo principal Interpolacion Polinomial
        builder.Services.AddSingleton<InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasViewModel>();
        builder.Services.AddSingleton<InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasPage>();
        //Armar Submetodos Interpolacion Polinomial
        builder.Services.AddSingleton<VanderMondePages>();
		builder.Services.AddSingleton<InterDeNewtonPages>();
        builder.Services.AddSingleton<MinimosCuadradosPages>();
        builder.Services.AddSingleton<MinimosCuadradosViewModel>();
        builder.Services.AddSingleton<InterBariLagraPages>();
        builder.Services.AddSingleton<PoliOrtoDeChebyPages>();

        //Armar metodo principal Integracion Numerica
        builder.Services.AddSingleton<IntegracionNumericaPage>();
        builder.Services.AddSingleton<IntegracionNumericaViewModel>();
        //Armar Submetodos Integracion Numerica
		builder.Services.AddSingleton<CuadraturasGaussLegendreN3Page>();
        builder.Services.AddSingleton<CuadraturasGaussLegendreN3ViewModel>();

        //Armar metodo principal Ecuaciones Diferenciales
        builder.Services.AddSingleton<EcuacionesDiferencialesOrdinariasParcialesViewModel>();
        builder.Services.AddSingleton<EcuacionesDiferencialesOrdinariasParcialesPage>();
        //Armar Submetodos Ecuaciones Diferenciales
		//Metodos de un paso
		builder.Services.AddSingleton<RungeKuttaOrden2Page>();
        builder.Services.AddSingleton<RungeKuttaOrden2ViewModel>();

        //Armar Metodo Principal Ecuaciones No Lineales No Polinomiales
        builder.Services.AddSingleton<EcuacionesNoLinealesNoPolinomialesViewModel>();
        builder.Services.AddSingleton<EcuacionesNoLinealesNoPolinomialesPage>();
        //Armar Submetodos Ecuaciones No Lineales No Polinomiales
        builder.Services.AddSingleton<PuntoFijoPage>();
        builder.Services.AddSingleton<PuntoFijoViewModel>();

        //Armar Metodo Principal Ecuaciones Polinomiales
        builder.Services.AddSingleton<EcuacionesPolinomialesViewModel>();
        builder.Services.AddSingleton<EcuacionesPolinomialesPage>();
        //Armar Submetodos Ecuaciones Polinomiales
        builder.Services.AddSingleton<BairstowPages>();
        builder.Services.AddSingleton<NewtonPages>();
        builder.Services.AddSingleton<NewtonViewModel>();
        return builder.Build();
	}
}
