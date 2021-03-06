using ElmSharp;

namespace Tizen.NET.MaterialComponents
{
    public static class Styles
    {
        public static readonly string Material = "material";

        public class CheckBox
        {
            public static readonly string Style = "material_checkboxes";
        }

        public class Entry
        {
            public static readonly string Singleline = "singleline";
        }

        public class ProgressBar
        {
            public static readonly string MaterialCircular = "material_circular";
        }

        public class RadioButton
        {
            public static readonly string Style = "material_radio_buttons";
        }

        public class Switch
        {
            public static readonly string Style = "material_switches";
        }

        public class GenListItem
        {
            public static readonly string Default = "default";
            public static readonly string MaterialNavigation = "material_navigation";
            public static readonly string MaterialNavigationSubtitle = "material_navigation_subtitle";
            public static readonly string MaterialNavigationDivider = "material_navigation_divider";
            public static readonly string MaterialSingleLine = "material_1line";
            public static readonly string MaterialDoubleLine = "material_2line";
            public static readonly string MaterialTripleLine = "material_3line";
        }

        public class Popup
        {
            public static readonly string SnackBars = "material_snackbars";
            public static readonly string Alert = "material_alert";
            public static readonly string Simple = "material_simple";
            public static readonly string Confirmation = "material_confirmation";
            public static readonly string FullScreen = "material_fullscreen";
            public static readonly string FullScreenTitle = "popup_fullscreen_title";

            public static readonly string PopupButton = "material_popup";
            public static readonly string PopupButton2 = "material_popup2";
        }

        public class Button
        {
            public static readonly string FloatingButton = "floatingbutton/material";
        }

        public class Banner
        {
            public static readonly string SingleLine = "banner_1line";
            public static readonly string DoubleLine = "banner_2line";

        }
    }

    public static class Parts
    {
        public class Widget
        {
            public static readonly string Background = "bg";
            public static readonly string BackgroundPressed = "bg_pressed";
            public static readonly string BackgroundDisabled = "bg_disabled";

            public static readonly string Text = "text";
            public static readonly string TextPressed = "text_pressed";
            public static readonly string TextDisabled = "text_disabled";

            public static readonly string Title = "title";

            public static readonly string Icon = "icon";
            public static readonly string IconPressed = "icon_pressed";
        }

        public class Label
        {
            public static readonly string Text = "text";
            public static readonly string TextEdje = "elm.text";
        }

        public class Button
        {
            public static readonly string Effect = "effect";
        }

        public class Layout
        {
            public static readonly string Content = "elm.swallow.content";
            public static readonly string Title = "elm.swallow.title";
            public static readonly string Border = "border";
            public static readonly string FloatingButton = "elm.swallow.floatingbutton";
            public static readonly string Sheets = "elm.swallow.sheets";
        }

        public class Check
        {
            public static readonly string BackgroundOn = "bg_on";
            public static readonly string BackgroundOnDisabled = "bg_on_disabled";
            public static readonly string Stroke = "stroke";
            public static readonly string StrokeDisabled = "stroke_disabled";
        }

        public class Entry
        {
            public static readonly string Label = "label";
            public static readonly string Cursor = "cursor";
            public static readonly string Guide = "elm.guide";
            public static readonly string TextLabel = "elm.text.label";
            public static readonly string TextEdit = "text_edit";
            public static readonly string TextEditFocused = "text_edit_focused";
            public static readonly string Underline = "underline";
            public static readonly string UnderlineFocused = "underline_focused";
        }

        public class GenListItem
        {
            public static readonly string BackgroundActivated = "active_bg";
            public static readonly string Icon = "elm.swallow.icon";
            public static readonly string Text = "elm.text";
            public static readonly string SubText = "elm.text.sub";
            public static readonly string MetaControl = "elm.swallow.end";
        }

        public class ProgressBar
        {
            public static readonly string Bar = "bar";
            public static readonly string BarDisabled = "bar_disabled";
        }

        public class Radio
        {
            public static readonly string Icon = "icon";
            public static readonly string IconDisabled = "icon_disabled";
        }

        public class Slider
        {
            public static readonly string Bar = "bar";
            public static readonly string BarPressed = "bar_pressed";
            public static readonly string BarDisabled = "bar_disabled";

            public static readonly string Handler = "handler";
            public static readonly string Handler2 = "handler2";
            public static readonly string HandlerPressed = "handler_pressed";
            public static readonly string HandlerDisabled = "handler_disabled";
        }

        public class Switch
        {
            public static readonly string SliderOn = "slider_on";
            public static readonly string SliderDisabledOn = "slider_disabled_on";
            public static readonly string ShapeOn = "shape_on";
            public static readonly string ShapeDisabledOn = "shape_disabled_on";
        }

        public class ToolbarItem
        {
            public static readonly string Background = "bg";
            public static readonly string Text = "text";
            public static readonly string TextSelected = "text_selected";
            public static readonly string Underline = "underline";
        }

        public class Popup
        {
            public static readonly string Button1 = "button1";
            public static readonly string Button2 = "button2";
            public static readonly string Text = "elm.text";
            public static readonly string TextLabel = "elm.text.label";
            public static readonly string Title = "title,text";
            public static readonly string ElmTitle = "elm.text.title";
            public static readonly string ActionButton = "elm.swallow.action_button";
            public static readonly string ActionButton2 = "elm.swallow.action_button2";
            public static readonly string Icon = "elm.swallow.icon";
        }

        public class Menus
        {
            public static readonly string Divider = "divider";
        }

        public class Background
        {
            public static readonly string Bg = "elm.swallow.background";
        }
    }

    public static class Actions
    {
        public static readonly string ShowShadow = "elm,action,show,shadow";
        public static readonly string HideShadow = "elm,action,hide,shadow";
    }

    public static class States
    {
        public static readonly string Activate = "elm,state,activate";
        public static readonly string Unactivate = "elm,state,unactivate";
        public static readonly string Focused = "elm,state,focused";
        public static readonly string Unfocused = "elm,state,unfocused";
    }

    public static class Events
    {
        public static readonly string Changed = "changed";
        public static readonly string VirtualKeypadOn = "virtualkeypad,state,on";
        public static readonly string VirtualKeypadOff = "virtualkeypad,state,off";
    }

    public static class Signal
    {
        public static readonly string ActionClick = "elm,action,click";
    }

    public static class DefaultValues
    {
        public class FloatingActionButton
        {
            public static readonly int Width = 56 * 2;
            public static readonly int Height = 56 * 2;
        }

        public class AppBar
        {
            // It comes from here, and the values are adjested for Tize mobile screen size.
            // https://material.io/components/app-bars-top/#specs
            public static readonly int Height = 56 * 2;
            public static readonly int ItemSize = 24 * 2;
            public static readonly int ItemPadding = 24 * 2;
            public static readonly int ProminentHeight = 128 * 2;
            public static readonly int FontSize = 40;
            public static readonly int Padding = 16 * 2;
            public static readonly int TitleSpacing = 32 * 2;
            public static readonly int MaximumItemCount = 4;

            public static readonly string DefaultTextStyle = $"DEFAULT = 'font_size={DefaultValues.AppBar.FontSize} ellipsis=1.0' ";
            public static readonly string MoreIconPath = "Tizen.NET.MaterialComponents.Resources.dots_vertical.png";
        }
    }
}
