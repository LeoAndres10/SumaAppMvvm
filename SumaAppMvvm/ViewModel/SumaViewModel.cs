using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm.ViewModel
{
    public partial class SumaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;
        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double suma;
        public SumaViewModel()
        {

        }

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]

        private void Calcular()
        {
            try
            {
                if (A == 0 || B == 0)
                {
                    Alerta("ADVERTENCIA", "Uno de los campos esta en 0");
                    Suma = (A + B);
                }
                else
                {
                    Suma = (A + B);
                }
            } catch (Exception ex)
            {

                Alerta("ERROR", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            Suma = 0;
        }

    }
}
