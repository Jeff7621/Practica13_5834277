using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13.Modelos
{
     partial class Area : ObservableObject
    {
        [ObservableProperty]
        public string numero1;

        [ObservableProperty]
        public string numero2;

        [ObservableProperty]
        public string numero3;

        [ObservableProperty]
        public string resultado;


        [RelayCommand]
        private void CalcularArea()
        {

            if (double.TryParse(Numero1, out double num1) && double.TryParse(Numero2, out double num2) && double.TryParse(Numero3, out double num3))
            {

                double F1 = ((num1 + num2 + num3) / 2);

                Resultado = (F1 * (F1 - num1) * (F1 - num2) * (F1 - num3)).ToString();
            }
            else
            {
                Resultado = "Ingrese un numero";
            }
        }




    }
}
