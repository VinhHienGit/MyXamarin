using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LayoutEx
{
    public class ButtonLoginWithTrigersAction : TriggerAction<Button>
    {
        protected override void Invoke(Button sender)
        {
            if (sender.BackgroundColor == Color.Green)
            {
                sender.BackgroundColor = Color.LightGreen;
                return;
            }
            if (sender.BackgroundColor == Color.Red)
            {
                sender.BackgroundColor = Color.IndianRed;
                return;
            }
            if (sender.BackgroundColor == Color.Blue)
            {
                sender.BackgroundColor = Color.LightBlue;
                return;
            }
            if (sender.BackgroundColor == Color.LightGreen)
            {
                sender.BackgroundColor = Color.Green;
                return;
            }
            if (sender.BackgroundColor == Color.IndianRed)
            {
                sender.BackgroundColor = Color.Red;
                return;
            }
            if (sender.BackgroundColor == Color.LightBlue)
            {
                sender.BackgroundColor = Color.Blue;
                return;
            }
        }
    }
}
