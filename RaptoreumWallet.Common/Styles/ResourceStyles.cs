using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Shapes; 
using Xamarin.Forms.Internals;
using RaptoreumWallet.Common.Extensions;

namespace RaptoreumWallet.Common.Styles
{
    public class CommonStyles
    {
        public static readonly Style EntryBase = Extensions.Styles.CreateStyle<Entry>()
            .Set(Entry.FontFamilyProperty, Strings.FontRegular)
            .Set(Entry.VerticalTextAlignmentProperty, TextAlignment.Center)
            .Set(Entry.TextColorProperty, Colors.TextPrimaryColor)
            .Set(Entry.PlaceholderColorProperty, Colors.TextPrimaryColor)
            .Set(View.BackgroundColorProperty, Color.Transparent)
            .Set(View.HeightRequestProperty, Dimensions.EntryHeight)
            .Set(Entry.FontSizeProperty, Dimensions.FontSizeNormal);

        public static readonly Style EditorBase = Extensions.Styles.CreateStyle<Editor>()
            .Set(Entry.FontFamilyProperty, Strings.FontRegular)
            .Set(Entry.TextColorProperty, Colors.TextPrimaryColor)
            .Set(Entry.PlaceholderColorProperty, Colors.TextPrimaryColor)
            .Set(View.BackgroundColorProperty, Color.Transparent)
            .Set(Entry.FontSizeProperty, Dimensions.FontSizeNormal);

        public static readonly Style ContainerEntry = Extensions.Styles.CreateStyle<Frame>()
            .Set(Frame.CornerRadiusProperty, 0)
            .Set(Frame.BackgroundColorProperty, Colors.EntryBackgroundColor)
            .Set(Frame.BorderColorProperty, Colors.EntryBorderColor)
            .Set(Frame.PaddingProperty, new Thickness(12, 0))
            .Set(Frame.HasShadowProperty, false)
            .Set(View.HeightRequestProperty, Dimensions.EntryHeight);

        public static readonly Style ContainerEditor = Extensions.Styles.CreateStyle<Frame>()
            .Set(Frame.CornerRadiusProperty, 0)
            .Set(Frame.BackgroundColorProperty, Colors.EntryBackgroundColor)
            .Set(Frame.BorderColorProperty, Colors.EntryBorderColor)
            .Set(Frame.PaddingProperty, new Thickness(12, 0))
            .Set(Frame.HasShadowProperty, false);


        public static readonly Style EntrySecondary = Extensions.Styles.CreateStyle<Entry>()
          .Set(Entry.VerticalTextAlignmentProperty, TextAlignment.Center)
          .Set(Entry.TextColorProperty, Colors.TextEntrySecondaryColor)
          .Set(Entry.FontFamilyProperty, Strings.FontRegular)
          .Set(Entry.PlaceholderColorProperty, Colors.TextEntrySecondaryColor)
          .Set(View.BackgroundColorProperty, Color.Transparent)
          .Set(View.HeightRequestProperty, Dimensions.EntryHeight)
          .Set(Entry.FontSizeProperty, Dimensions.FontSizeNormal);

        public static readonly Style ContainerEntrySecondary = Extensions.Styles.CreateStyle<Frame>()
            .Set(Frame.CornerRadiusProperty, Dimensions.EntryRadius)
            .Set(View.BackgroundColorProperty, Color.FromHex("#AD6C5448"))
            .Set(Frame.BorderColorProperty, Color.FromHex("#AD6C5448"))
            .Set(Frame.PaddingProperty, new Thickness(12, 0))
            .Set(Frame.HasShadowProperty, false)
            .Set(View.HeightRequestProperty, Dimensions.EntryHeight);

        public static readonly Style ButtonImage = Extensions.Styles.CreateStyle<ImageButton>()
           .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
           .Set(View.BackgroundColorProperty, Color.Transparent)
           .Set(View.BackgroundColorProperty, Color.Transparent);

        public static readonly Style BackButton = Extensions.Styles.CreateStyle<ImageButton>()
           .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
           .Set(View.WidthRequestProperty, Dimensions.ButtonHeight)
           .Set(View.BackgroundColorProperty, Color.Transparent)
           .Set(ImageButton.SourceProperty, "button_back_popup")
           .Set(ImageButton.HorizontalOptionsProperty, LayoutOptions.Start)
           .Set(ImageButton.MarginProperty, new Thickness(16, 0, 0, 0))
           .Set(ImageButton.CommandParameterProperty, new Binding("CloseCommand"));

        public static readonly Style CloseButton = Extensions.Styles.CreateStyle<ImageButton>()
           .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
           .Set(View.WidthRequestProperty, Dimensions.ButtonHeight)
           .Set(View.BackgroundColorProperty, Color.Transparent)
           .Set(ImageButton.SourceProperty, "button_close_popup")
           .Set(ImageButton.HorizontalOptionsProperty, LayoutOptions.Start) ;


        public static readonly Style ButtonImageBase = Extensions.Styles.CreateStyle<ImageButton>()
            .BaseOn(ButtonImage)
            .Set(ImageButton.PaddingProperty, new Thickness(0, 10, 0, 14));

        public static readonly Style ButtonBGBase = Extensions.Styles.CreateStyle<Button>()
            .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
            .Set(View.BackgroundColorProperty, Color.Transparent)
            .Set(Button.PaddingProperty, new Thickness(0, 10, 0, 14))
            .Set(Button.FontFamilyProperty, Strings.FontBold)
            .Set(Button.TextTransformProperty, TextTransform.None)
            .Set(Button.TextColorProperty, Color.White);


        public static readonly Style ButtonBase = Extensions.Styles.CreateStyle<Button>()
            .Set(View.VerticalOptionsProperty, LayoutOptions.Center)
            .Set(View.HeightRequestProperty, Dimensions.ButtonHeight)
            .Set(View.BackgroundColorProperty, Color.Transparent)
            .Set(Button.FontFamilyProperty, Strings.FontBold)
            .Set(Button.FontSizeProperty, Dimensions.FontSizeNormal)
            .Set(Button.TextTransformProperty, TextTransform.None);


        public static readonly Style RadioButtonBase = Extensions.Styles.CreateStyle<RadioButton>()
            .Set(View.BackgroundColorProperty, Color.Transparent)
            .Set(Button.FontFamilyProperty, Strings.FontRegular)
            .Set(Button.FontSizeProperty, Dimensions.FontSizeNormal)
            .Set(Button.TextTransformProperty, TextTransform.None);

        public static readonly Style ButtonTransparent = Extensions.Styles.CreateStyle<Button>()
            .BaseOn(ButtonBase)
            .Set(Button.FontFamilyProperty, Strings.FontRegular);

        public static readonly Style ButtonTabBase = Extensions.Styles.CreateStyle<Button>()
            .Set(Button.TextTransformProperty, TextTransform.None)
            .Set(Button.FontFamilyProperty, Strings.FontBold);


        public static readonly Style TabButton = Extensions.Styles.CreateStyle<Button>()
            .BaseOn(ButtonTabBase)
            .Set(Button.BorderWidthProperty, Dimensions.BorderWidthDefault)
            .Set(Button.BorderColorProperty, Colors.BorderColor)
            .Set(Button.CornerRadiusProperty, 0);


        public static readonly Style HorizontalSeparator = Extensions.Styles.CreateStyle<Line>()
            .Set(View.HeightRequestProperty, Dimensions.SeparatorSize)
            .Set(View.BackgroundColorProperty, Colors.SeparatorColor);

        public static readonly Style FrameBase = Extensions.Styles.CreateStyle<Frame>()
            .Set(Frame.PaddingProperty, new Thickness(0))
            .Set(Frame.CornerRadiusProperty, 4)
            .Set(Frame.HasShadowProperty, false);


        public static readonly Style FrameSetting = Extensions.Styles.CreateStyle<Frame>()
            .BaseOn(FrameBase)
            .Set(Frame.PaddingProperty, new Thickness(0))
            .Set(Frame.BorderColorProperty, Colors.EntryBorderColor)
            .Set(Frame.BackgroundColorProperty, Colors.EntryBackgroundColor)
            .Set(Frame.HeightRequestProperty, 56) 
            .Set(Frame.CornerRadiusProperty, 2) 
            .Set(Frame.HasShadowProperty, false); 
    }
    public class LabelStyles
    {
        public const string Suffixes = "Label";
        public static readonly Style LabelBase = Extensions.Styles.CreateStyle<Label>()
            .Set(Label.TextColorProperty, Colors.TextPrimaryColor)
            .Set(Label.FontFamilyProperty, Strings.FontRegular);

        public static readonly Style LabelBoldBase = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.FontFamilyProperty, Strings.FontBold);

        public static readonly Style LargeBoldLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBoldBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeLarge);

        public static readonly Style TitleBoldLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBoldBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeTitle);

        public static readonly Style NormalBoldLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBoldBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeNormal);

        public static readonly Style MediumBoldLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBoldBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeMedium);

        public static readonly Style TinyBoldLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBoldBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeTiny);

        public static readonly Style LargeLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeLarge);

        public static readonly Style TitleLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeTitle);

        public static readonly Style NormalLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeNormal);

        public static readonly Style MediumLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeMedium);

        public static readonly Style TinyLabel = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(LabelBase)
            .Set(Label.FontSizeProperty, Dimensions.FontSizeTiny);

        public static readonly Style SmallLabel = Extensions.Styles.CreateStyle<Label>()
           .BaseOn(LabelBase)
           .Set(Label.FontSizeProperty, Dimensions.FontSizeSmall); 

        public static readonly Style TabTitle = Extensions.Styles.CreateStyle<Label>()
            .BaseOn(MediumBoldLabel)
            .Set(Label.HorizontalOptionsProperty, LayoutOptions.Center)
            .Set(Label.TextColorProperty, Color.White);

        

        public static readonly Style LabelIconBase = Extensions.Styles.CreateStyle<Label>()
           .BaseOn(LargeLabel)
           .Set(Label.FontFamilyProperty, Strings.FontMaterialDesign);


        public static readonly Style LabelHeaderPageBase = Extensions.Styles.CreateStyle<Label>()
           .BaseOn(LargeBoldLabel)
           .Set(Label.HorizontalOptionsProperty, LayoutOptions.Center)
           .Set(Label.VerticalOptionsProperty, LayoutOptions.Center);

        public static readonly Style HeaderPageLightLabel = Extensions.Styles.CreateStyle<Label>()
           .BaseOn(LabelHeaderPageBase)
           .Set(Label.TextColorProperty, Color.White); 
    }

    public class ResourceStyles : ResourceDictionary
    {
        public ResourceStyles()
        {

            Add(CommonStyles.EntryBase.TargetType.FullName, CommonStyles.EntryBase);
            Add(CommonStyles.ButtonImage.TargetType.FullName, CommonStyles.ButtonImage);
            Add(CommonStyles.FrameBase.TargetType.FullName, CommonStyles.FrameBase);
            Add(CommonStyles.EditorBase.TargetType.FullName, CommonStyles.EditorBase);
            Add(CommonStyles.RadioButtonBase.TargetType.FullName, CommonStyles.RadioButtonBase);
            Add(CommonStyles.ButtonBase.TargetType.FullName, CommonStyles.ButtonBase);
            typeof(LabelStyles).GetFieldValues<Style>().ForEach(d => Add(d.Key, d.Value));
            typeof(CommonStyles).GetFieldValues<Style>().ForEach(d => Add(d.Key, d.Value));
        }
    }
}
