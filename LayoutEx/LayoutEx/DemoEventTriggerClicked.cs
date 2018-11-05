using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutEx
{
    public class DemoEventTriggerClicked : TriggerAction<Button>
    {
        protected override  async void Invoke(Button sender)
        {
            await Task.WhenAll(
                sender.ScaleTo(.7, 2000),
                sender.BackGroundColorTo(sender.BackgroundColor, Color.LightBlue, c => sender.BackgroundColor = c, 2000),
                sender.ColorTo(sender.TextColor, Color.Red, c => sender.TextColor = c, 2000)
                );
            await Task.WhenAny<bool>(
                sender.ScaleTo(1, 2000),
                sender.TextColorTo(sender.TextColor, Color.Gold, c => sender.TextColor = c, 2000),
                sender.BackGroundColorTo(sender.BackgroundColor, Color.Gray, c => sender.BackgroundColor = c, 2000)
                );
            //await sender.ColorTo(sender.TextColor, Color.Gold, c => sender.TextColor = c, 300);
        }
    }
}
