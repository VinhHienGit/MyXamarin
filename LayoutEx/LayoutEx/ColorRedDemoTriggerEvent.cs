using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LayoutEx
{
    public class ColorRedDemoTriggerEvent : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int rgb = -1;
            int.TryParse(sender.Text.Trim(), out rgb);
            if(rgb >= 0 && rgb <= 255)
            {
                sender.BackgroundColor = Color.FromRgb(rgb, 0, 0);
            }
        }
    }
}
