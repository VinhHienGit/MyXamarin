using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LayoutEx
{
    public class DemoEventTriggerClicked : TriggerAction<Button>
    {
        protected override  async void Invoke(Button sender)
        {
            await sender.ScaleTo(.7, 500);
            await sender.ScaleTo(1, 500);
        }
    }
}
