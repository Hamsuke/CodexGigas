using CodexGigas.Views.EcuacionesDiferenciales.MetodosDeUnPaso;
using CodexGigas.Views.EcuacionesNoLinealesNoPolinomiales;
using CodexGigas.Views.EcuacionesPolinomiales;

namespace CodexGigas;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Metodos de Interpolacion Polinomial, Polinomios Ortogonales y Ajuste de Curvas
        RegisterForRoute<MinimosCuadradosPages>();
        RegisterForRoute<InterDeNewtonPages>();
        RegisterForRoute<PoliOrtoDeChebyPages>();
        RegisterForRoute<InterBariLagraPages>();
        RegisterForRoute<VanderMondePages>();

        //Metodos de Ecuaciones Diferenciales
        RegisterForRoute<RungeKuttaOrden2Page>();

        //Metodos Ecuaciones No Lineales Polinomiales
        RegisterForRoute<PuntoFijoPage>();

        //Metodos Ecuaciones Polinomiales
        RegisterForRoute<NewtonPages>();
        RegisterForRoute<BairstowPages>();

        //Metodos de Integracion Numerica
        RegisterForRoute<MinimosCuadradosPages>();

    }

    protected void RegisterForRoute<T>()
    {
        Routing.RegisterRoute(typeof(T).Name, typeof(T));
    }
}
