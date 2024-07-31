using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13.Modelos
{
    partial class Sumar : ObservableObject
    {
        [ObservableProperty]
        public string numero1;

        [ObservableProperty]
        public string numero2;

        [ObservableProperty]
        public string resultado;


        [RelayCommand]
        private void RealizarSuma()
        {

            if (double.TryParse(Numero1, out double num1) && double.TryParse(Numero2, out double num2))
            {

                Resultado = (num1 + num2).ToString();

            }
            else
            {
                Resultado = "Ingrese un numero";
            }
        }


    }
}
