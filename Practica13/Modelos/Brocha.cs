using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13.Modelos
{
    partial class Brocha : ObservableObject
    {

        [ObservableProperty]
        public string metros;

        [ObservableProperty]
        public string precio;

        [ObservableProperty]
        public string total;


        [RelayCommand]
        private void ResultadoBrocha()
        {
            if (double.TryParse(Metros, out double metros) && double.TryParse(Precio, out double precio))
            {
                Total = (metros * precio).ToString();

            }
            else
            {
                Total = "Ingrese un numero";
            }
        }




    }
}
