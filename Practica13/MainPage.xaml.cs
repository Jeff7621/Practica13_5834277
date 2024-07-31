namespace Practica13
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }


        private async void ButtonSumar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sumar());
        }

        private async void ButtonArea(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Area());
        }

        private async void ButtonDistancia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Distancia());
        }

        private async void ButtonBrocha(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrochaGorda());
        }

        private async void ButtonSueldo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sueldo());
        }
    }

}
