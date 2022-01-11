using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaptoreumWallet.Common.Extensions
{  
    public static partial class Styles
    {
        public static Style CreateStyle<T>()
        {
            return new Style(typeof(T));
        }
         
        public static Style BaseOn(this Style style, Style basedOn)
        {
            try
            {
                style.BasedOn = basedOn;
                return style;
            }
            catch(Exception)
            {
                return style;
            }
        }

        public static Style Set(this Style style, BindableProperty property, object value)
        {
            style.Setters.Add(new Setter
            {
                Property = property,
                Value = value
            });
            return style;
        }

        public static Style BindTrigger(this Style style, Binding binding, object value, params (BindableProperty p, object value)[] setters)
        {
            var dataTrigger = new DataTrigger(style.TargetType)
            {
                Binding = binding,
                Value = value
            };

            for (int i = 0; i < setters.Length; i++)
            {
                dataTrigger.Setters.Add(new Setter
                {
                    Property = setters[i].p,
                    Value = setters[i].value
                });
            }

            style.Triggers.Add(dataTrigger);

            return style;
        }
    } 
}
