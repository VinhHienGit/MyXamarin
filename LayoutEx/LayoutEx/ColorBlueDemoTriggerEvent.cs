using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LayoutEx
{
    public class ColorBlueDemoTriggerEvent : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int rgb = -1;
            bool isN = Int32.TryParse(sender.Text, out rgb);
            if(rgb >= 0 && rgb <= 255)
            {
                sender.ColorTo(sender.BackgroundColor, Color.FromRgb(0, 0,rgb), c => sender.BackgroundColor = c, 500);
            }
        }
    }
}
