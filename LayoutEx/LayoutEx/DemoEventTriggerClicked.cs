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
                sender.ColorTo(sender.BackgroundColor, Color.Blue, c => sender.BackgroundColor = c, 2000),
                sender.ColorTo(sender.TextColor, Color.Red, c => sender.TextColor = c, 2000),
                sender.ScaleTo(.5, 2000),
                sender.ColorTo(Color.Blue, sender.BackgroundColor, c => sender.BackgroundColor = c, 2000),
                sender.ColorTo(Color.Red, sender.TextColor, c => sender.TextColor = c, 2000),
                sender.ScaleTo(1, 2000)
                );
        }
    }
}
