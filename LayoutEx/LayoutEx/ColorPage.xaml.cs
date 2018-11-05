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
	public partial class ColorPage : ContentPage
	{
		public ColorPage ()
		{
			InitializeComponent ();
		}

        private void btnGetRGB_Clicked(object sender, EventArgs e)
        {
            int r = 0;
            int.TryParse(red.Text.Trim(), out r);
            int g = 0;
            int.TryParse(green.Text.Trim(), out g);
            int b = 0;
            int.TryParse(blue.Text.Trim(), out b);
            myBoxView.Color = Color.FromRgb(r, g, b);
        }

        private void myButton_Clicked(object sender, EventArgs e)
        {
            string name = myEntry.Text.Trim();
            Label hello = new Label();
            hello.Text = "Hi! " + name;
            hello.TextColor = Color.BlueViolet;
        }

        private void btnAddPage_Clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new GridCaculator(), this);
        }

        private void btnRemovePageBefore_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
        }
    }
}