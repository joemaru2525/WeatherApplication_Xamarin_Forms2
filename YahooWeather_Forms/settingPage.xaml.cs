using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YahooWeather_Forms
{
    public partial class settingPage : ContentPage
    {
        public const string KeyText1 = "myText1";
        public const string KeyText2 = "myText2";
        public const string KeyText3 = "myText3";
        public const string KeyText4 = "myText4";

        //http://theiphonewalls.com/wp-content/uploads/2014/11/Fantasy-Cloudy-Space.jpg
        //http://theiphonewalls.com/wp-content/uploads/2013/06/Alemania-Sand.jpg
        //http://theiphonewalls.com/wp-content/uploads/2014/11/Everest-Mountain-Snow-Stars.jpg
        //http://markinternational.info/data/out/785/225948934-pretty-iphone-wallpaper.jpg
        //http://markinternational.info/data/out/785/225948989-pretty-iphone-wallpaper.jpg
        //http://markinternational.info/data/out/785/225949258-pretty-iphone-wallpaper.jpg
        //http://markinternational.info/data/out/785/225949454-pretty-iphone-wallpaper.jpg

        public settingPage()
        {
            InitializeComponent();
            // 保存されているテキストをラベルに表示
            UpdateLabelText1();
            UpdateLabelText2();
            UpdateLabelText3();
        }

        void Button1_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.Properties[KeyText1] = this.Entry1.Text;    // 保存
            UpdateLabelText1(); // 保存されているテキストをラベルに表示
        }
        void Button2_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.Properties[KeyText2] = this.Entry2.Text;    // 保存
            UpdateLabelText2(); // 保存されているテキストをラベルに表示
        }
        void Button3_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.Properties[KeyText3] = this.Entry3.Text;    // 保存
            UpdateLabelText3(); // 保存されているテキストをラベルに表示
        }

        private void UpdateLabelText1()
        {
            if (Application.Current.Properties.ContainsKey(KeyText1))
            {
                this.WallpaperLabel1.Text = Application.Current.Properties[KeyText1] as string;
                imageBackground2.Source = this.WallpaperLabel1.Text;
            }
        }
        private void UpdateLabelText2()
        {
            if (Application.Current.Properties.ContainsKey(KeyText2))
            {
                this.WallpaperLabel2.Text = Application.Current.Properties[KeyText2] as string;
                imageBackground2.Source = this.WallpaperLabel2.Text;
            }
        }
        private void UpdateLabelText3()
        {
            if (Application.Current.Properties.ContainsKey(KeyText3))
            {
                this.WallpaperLabel3.Text = Application.Current.Properties[KeyText3] as string;
                imageBackground2.Source = this.WallpaperLabel3.Text;
            }
        }

        public void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            // ラベルに変化した値を表示する
            System.Diagnostics.Debug.WriteLine(Slider1.Value);
            imageBackground2.Opacity = Slider1.Value;
            Application.Current.Properties[KeyText4] = Slider1.Value.ToString();    // 保存
            this.OpacityLabel1.Text = Application.Current.Properties[KeyText4] as string;
        }
    }
}
