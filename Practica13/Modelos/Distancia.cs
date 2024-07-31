using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13.Modelos
{
    partial class Distancia : ObservableObject
    {
        partial class ModeloDistancia : ObservableObject
        {
            [ObservableProperty]
            public string p1x;

            [ObservableProperty]
            public string p1y;

            [ObservableProperty]
            public string p2x;

            [ObservableProperty]
            public string p2y;

            [ObservableProperty]
            public string resultado;


            [RelayCommand]
            private void CalcularDistancia()
            {
                if (double.TryParse(P1x, out double dt1x) && double.TryParse(P1y, out double dt1y)
                    && double.TryParse(P2x, out double dt2x) && double.TryParse(P2y, out double dt2y))
                {
                    double p1 = Math.Pow(dt1x - dt1y, 2);
                    double p2 = Math.Pow(dt2x - dt2y, 2);

                    Resultado = ((p1 + p2)).ToString();

                }
            }



        }
    }
}
