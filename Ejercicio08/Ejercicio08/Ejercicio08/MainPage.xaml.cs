using Ejercicio08.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SimpleDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InteractiveDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CommandDemo());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Operaciones());

            };
        }
    }
}
