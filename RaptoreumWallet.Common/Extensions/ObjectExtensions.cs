using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaptoreumWallet.Common.Extensions
{
    public static class ObjectExtension
    {
        public static T GetValue<T>(this BindableObject obj, BindableProperty pro)
        {
            return (T)obj.GetValue(pro);
        }
        public static Dictionary<string, T> GetFieldValues<T>(this Type obj)
        {
            return obj.GetFields(BindingFlags.Public | BindingFlags.Static)
                      .Where(f => f.FieldType == typeof(T))
                      .ToDictionary(f => f.Name,
                                    f => (T)f.GetValue(null));
        }
    }
}
