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
                sender.ColorTo(sender.BackgroundColor, Color.Goldenrod, c => sender.BackgroundColor = c, 2000),
                sender.ScaleTo(.7, 2000),
                sender.ColorTo(sender.TextColor, Color.Gray, c => sender.BackgroundColor = c, 2000),
                sender.ScaleTo(1, 2000)
                );
            sender.BackgroundColor = Color.Default;
            sender.TextColor = Color.Default;
        }
    }
}
