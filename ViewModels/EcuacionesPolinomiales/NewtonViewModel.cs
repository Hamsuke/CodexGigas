﻿namespace CodexGigas.ViewModels.EcuacionesPolinomiales
{
    [QueryProperty(nameof(Funcion), "funcion")]
    public partial class NewtonViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _funcion;

        [ObservableProperty]
        private string _valI;

        [ObservableProperty]
        private string _function;

        [RelayCommand]
        public void SetValores()
        {
            if (!string.IsNullOrWhiteSpace(Funcion) && Funcion.Contains('|'))
            {
                string[] valores = Funcion.Split('|');

                if (valores.Length == 2)
                {
                    Function = valores[0].Trim(' ');
                    ValI = valores[1].Trim(' ', '(', ')');
                }
            }
        }
    }
}
