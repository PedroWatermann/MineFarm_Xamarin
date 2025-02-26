using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MineFarm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePedregulho : ContentPage
    {
        public PagePedregulho()
        {
            InitializeComponent();
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}