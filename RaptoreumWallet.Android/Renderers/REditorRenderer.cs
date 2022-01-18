using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RaptoreumWallet.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Editor), typeof(REditorRenderer))]
namespace RaptoreumWallet.Droid.Renderers
{
    public class REditorRenderer : EditorRenderer
    {
        public REditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null)
            {
                return;
            }
            Control.SetPadding(0, 0, 0, 0);
            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}