using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace LayoutEx
{
    public class LimitRGBBehaviors : Behavior<Entry>
    {
        public static readonly BindableProperty AttachBehaviorProperty =
        BindableProperty.CreateAttached("AttachBehavior", typeof(bool),
            typeof(LimitRGBBehaviors),
            false, propertyChanged: OnAttachBehaviorChanged);
        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }
        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }

        static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as Entry;
            if (entry == null)
            {
                return;
            }

            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                entry.TextChanged += OnEntryTextChanged;
            }
            else
            {
                entry.TextChanged -= OnEntryTextChanged;
            }
        }

        static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            int result;
            bool isValid = int.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = (result<=255&&result>0) ? Color.Aqua : Color.Red;
        }

    }
}
