using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationTest
{
    public partial class UiContentPage : ContentPage
    {
        public UiContentPage()
        {
            InitializeComponent();
        }

        protected async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UiTabPage());
        }
    }
}
