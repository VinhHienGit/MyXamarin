using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LayoutEx
{
    public class ColorGreenDemoTriggerEvent : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int rgb = 0;
            bool isN = Int32.TryParse(sender.Text, out rgb);
            if(rgb >= 0 && rgb <= 255)
            {
                sender.BackgroundColor = Color.FromRgb(0, rgb, 0);
            }
        }
    }
}
