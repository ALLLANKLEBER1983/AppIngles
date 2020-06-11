using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InglesCriancas
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCores());
        }

        private void btNumeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageNumeros());
        }

        private void btFamilia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageFamilia());

        }

        private void btSair_Clicked(object sender, EventArgs e)
        {

        }
    }
}
