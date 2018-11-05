using Android.Provider;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutEx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationMain : ContentPage
	{
		public NavigationMain ()
		{
			InitializeComponent ();
		}

        private void btnGotoColorPage_Clicked(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            int age = 0;
            int.TryParse(txtAge.Text.Trim(), out age);
            Contact cont = new Contact()
            {
                Name = name,
                Age = age,
            };
            ColorPage colorPage = new ColorPage();
            colorPage.BindingContext = cont;
            Navigation.PushAsync(colorPage);
        }

        private void btnGoToCaculator_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridCaculator());
        }

        private void btnGoToLoginFoody_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginFoody());
        }
    }
}