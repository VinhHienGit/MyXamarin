using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutEx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginFoody : ContentPage
	{
		public LoginFoody ()
		{
			InitializeComponent ();
		}

        private async void btnLoginWithPhone_Clicked(object sender, EventArgs e)
        {
            await btnLoginWithPhone.ScaleTo(2, 500);
        }

        private void btnLoginWithFaceBook_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Login with Facebook!!");
        }

        private void btnLoginWithGoogle_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Login with GG!!");
        }
        

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            lbFogetPass.TextColor = Color.DarkGreen;
        }

        private void lbTerms_Tapped(object sender, EventArgs e)
        {
            lbTermsOfUse.TextColor = Color.DarkGreen;
        }
    }
}