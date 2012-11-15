using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Xna.Framework;

namespace TestMonoGameAndroid
{
    [Activity(
        Label = "MonoGame Test",
        MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden,
        Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Landscape, 
        Theme = "@android:style/Theme.NoTitleBar", 
        LaunchMode = LaunchMode.SingleInstance)]
    public class Activity1 : AndroidGameActivity
    {
        Game1 _game;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Game.Activity = this;
            _game = new Game1();
            _game.Run();

            SetContentView(_game.Window);
        }

        protected override void OnDestroy()
        {
            Console.WriteLine("OnDestroy Called!");

            base.OnDestroy();
        }
    }
}

