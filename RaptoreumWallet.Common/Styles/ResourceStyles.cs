using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Internals;
using RaptoreumWallet.Common.Extensions;
using Xamarin.CommunityToolkit.Effects;

namespace RaptoreumWallet.Common.Styles
{
    public class CommonStyles
    { 
        public static readonly Style ContainerEditor = Extensions.Styles.CreateStyle<Frame>()
            .Set(Frame.CornerRadiusProperty, 0)
            .Set(Frame.BackgroundColorProperty, Colors.SurfaceColor)
            .Set(Frame.PaddingProperty, new Thickness(12, 0))
            .Set(Frame.HasShadowProperty, false);
        
        public static readonly Style ContainerShadow = Extensions.Styles.CreateStyle<Frame>()
            .Set(Frame.CornerRadiusProperty, 0)
            .Set(Frame.BackgroundColorProperty, Colors.SurfaceColor)
            .Set(ShadowEffect.ColorProperty, Colors.ShadowColor)
            .Set(ShadowEffect.RadiusProperty, Dimensions.ShadowRadius)
            .Set(ShadowEffect.OffsetXProperty, Dimensions.ShadowOffsetX)
            .Set(ShadowEffect.OffsetYProperty, Dimensions.ShadowOffsetY)
            .Set(Frame.HasShadowProperty, false);

        public static readonly Style BoxShadow = Extensions.Styles.CreateStyle<BoxView>()
            
           .Set(ShadowEffect.ColorProperty, Colors.ShadowColor)
           .Set(ShadowEffect.RadiusProperty, Dimensions.ShadowRadius)
           .Set(ShadowEffect.OffsetXProperty, Dimensions.ShadowOffsetX)
           .Set(ShadowEffect.OffsetYProperty, Dimensions.ShadowOffsetY) ;

        public static readonly Style BackButton = Extensions.Styles.CreateStyle<ImageButton>()
           .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
           .Set(View.WidthRequestProperty, Dimensions.ButtonHeight)
           .Set(View.BackgroundColorProperty, Color.Transparent)
           .Set(ImageButton.SourceProperty, "button_back_popup")
           .Set(ImageButton.HorizontalOptionsProperty, LayoutOptions.Start)
           .Set(ImageButton.MarginProperty, new Thickness(16, 0, 0, 0))
           .Set(ImageButton.CommandParameterProperty, new Binding("CloseCommand"));

        public static readonly Style ButtonBase = Extensions.Styles.CreateStyle<Button>()
            .Set(View.VerticalOptionsProperty, LayoutOptions.Center)
            .Set(View.HorizontalOptionsProperty, LayoutOptions.Center)
            .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
            .Set(View.WidthRequestProperty, Dimensions.ButtonWidth)
            .Set(Button.CornerRadiusProperty, Dimensions.ButtonRadius)
            .Set(Button.FontFamilyProperty, Strings.FontRegular)
            .Set(Button.FontSizeProperty, Dimensions.FontSizeNormal)
            .Set(Button.TextTransformProperty, TextTransform.None);

        public static readonly Style ButtonPrimary = Extensions.Styles.CreateStyle<Button>()
            .BaseOn(ButtonBase)
            .Set(Button.BackgroundProperty, Colors.PrimaryColor)
            .Set(Button.TextColorProperty, Colors.SurfaceColor);

        public static readonly Style ButtonSecondary = Extensions.Styles.CreateStyle<Button>()
            .BaseOn(ButtonBase)
            .Set(Button.TextColorProperty, Colors.OrangeColor)
            .Set(Button.BackgroundColorProperty, Color.Transparent)
            .Set(Button.BorderWidthProperty, 1)
            .Set(Button.BorderColorProperty, Colors.OrangeColor);

        public static readonly Style FrameBase = Extensions.Styles.CreateStyle<Frame>()
            .Set(Frame.PaddingProperty, new Thickness(0))
            .Set(Frame.CornerRadiusProperty, 4)
            .Set(Frame.HasShadowProperty, false);

        public static readonly Style ButtonImageBase = Extensions.Styles.CreateStyle<ImageButton>()
            .Set(View.VerticalOptionsProperty, LayoutOptions.Center)
            .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
            .Set(ImageButton.PaddingProperty, 4)
            .Set(ShadowEffect.ColorProperty, Colors.ShadowColor)
            .Set(ShadowEffect.RadiusProperty, Dimensions.ShadowRadius)
            .Set(ShadowEffect.OffsetXProperty, Dimensions.ShadowOffsetX)
            .Set(ShadowEffect.OffsetYProperty, Dimensions.ShadowOffsetY)
            .Set(ImageButton.BackgroundColorProperty, Color.Transparent);

    }
    public class LabelStyles
    {
        public static readonly Style LabelBase = Extensions.Styles.CreateStyle<Label>()
            .Set(Label.TextColorProperty, Colors.TextPrimaryColor)
            .Set(Label.FontFamilyProperty, Strings.FontRegular);

        public static readonly Style LargeLabel = Extensions.Styles.CreateStyle<Label>()
           .BaseOn(LabelBase)
           .Set(Label.FontSizeProperty, Dimensions.FontSizeLarge);

        public static readonly Style NormalLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeNormal);

        public static readonly Style DescriptionLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.TextColorProperty, Colors.TextSecondaryColor)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeDescription);

        public static readonly Style SmallLabel = Extensions.Styles.CreateStyle<Label>()
           .BaseOn(LabelBase)
           .Set(Label.FontSizeProperty, Dimensions.FontSizeSmall);
    }

    public class ResourceStyles : ResourceDictionary
    {
        public ResourceStyles()
        {
            Add(CommonStyles.FrameBase.TargetType.FullName, CommonStyles.FrameBase);
            Add(CommonStyles.ButtonBase.TargetType.FullName, CommonStyles.ButtonBase);
            Add(CommonStyles.ButtonImageBase.TargetType.FullName, CommonStyles.ButtonImageBase);
            typeof(LabelStyles).GetFieldValues<Style>().ForEach(d => Add(d.Key, d.Value));
            typeof(CommonStyles).GetFieldValues<Style>().ForEach(d => Add(d.Key, d.Value));
        }
    }
}
