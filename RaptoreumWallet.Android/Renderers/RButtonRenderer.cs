using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RaptoreumWallet.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.CommunityToolkit.Effects;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(RButtonRenderer))]
namespace RaptoreumWallet.Droid.Renderers
{
    public class RButtonRenderer : ButtonRenderer
    {
        public RButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Build.VERSION.SdkInt<BuildVersionCodes.Lollipop)
                return;

            var radius = (float)ShadowEffect.GetRadius(Element);
            if (radius < 0)
                radius = 0;

            var opacity = ShadowEffect.GetOpacity(Element);
            if (opacity < 0)
                opacity = 1;

            var color = ShadowEffect.GetColor(Element);
            if (color.IsDefault)
            {
                return;
            } 

            color = color.MultiplyAlpha(opacity);
            var androidColor = color.ToAndroid();
            var offsetX = (float)ShadowEffect.GetOffsetX(Element);
            var offsetY = (float)ShadowEffect.GetOffsetY(Element);
            var cornerRadius = Element is IBorderElement borderElement ? borderElement.CornerRadius : 0;

            var pixelOffsetX = Context.ToPixels(offsetX);
            var pixelOffsetY = Context.ToPixels(offsetY);
            var pixelCornerRadius = Context.ToPixels(cornerRadius);
            Control.OutlineProvider = new ShadowOutlineProvider(pixelOffsetX, pixelOffsetY, 0);
            Control.Elevation = 0;
            Elevation = 0;
        }

        class ShadowOutlineProvider : ViewOutlineProvider
        {
            readonly float offsetX;
            readonly float offsetY;
            readonly float cornerRadius;

            public ShadowOutlineProvider(float offsetX, float offsetY, float cornerRadius)
            {
                this.offsetX = offsetX;
                this.offsetY = offsetY;
                this.cornerRadius = cornerRadius;
            }

            public override void GetOutline(Android.Views.View? view, Outline? outline)
                => outline?.SetRoundRect((int)offsetX, (int)offsetY, view?.Width ?? 0, view?.Height ?? 0, cornerRadius);
        }
    }
}