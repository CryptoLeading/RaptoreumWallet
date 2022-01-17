using Prism.Behaviors;
using RaptoreumWallet.Common.Styles;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.Effects;
using Xamarin.Forms;

namespace RaptoreumWallet.Common.Base
{
    public class RPageBehaviorFactory : PageBehaviorFactory
    {
        protected override void ApplyPageBehaviors(Page page)
        {
            base.ApplyPageBehaviors(page);
        }

        protected override void ApplyNavigationPageBehaviors(Xamarin.Forms.NavigationPage page)
        {
            base.ApplyNavigationPageBehaviors(page); 
        }

        protected override void ApplyContentPageBehaviors(ContentPage page)
        {
            base.ApplyContentPageBehaviors(page);
            page.SetValue(StatusBarEffect.ColorProperty, Colors.BackgroundColor);
            page.SetValue(StatusBarEffect.StyleProperty, StatusBarStyle.DarkContent);
        }
    }
}
