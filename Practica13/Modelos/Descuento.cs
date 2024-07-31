using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13.Modelos
{
    partial class Descuento : ObservableObject
    {
        [ObservableProperty]
        public string tra_sueldo;

        [ObservableProperty]
        public string nuevosueldo;


        [RelayCommand]
        private void NuevoSueldo()
        {
            if (decimal.TryParse(Tra_sueldo, out decimal tsueldo))
            {
                decimal suel = tsueldo < 1000 ? tsueldo * 1.15m : tsueldo * 1.12m;
                Nuevosueldo = suel.ToString();
            }
            else
            {
                Nuevosueldo = "Ingrese su sueldo";
            }



        }




    }
}
