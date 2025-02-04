﻿using Android.App;
using Android.Content.PM;
using Microsoft.Maui;

namespace GraphicsControls.Sample
{
    [Activity(
        Theme = "@style/Maui.SplashTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode)]
    [IntentFilter(
        new[] { Microsoft.Maui.Essentials.Platform.Intent.ActionAppAction },
        Categories = new[] { Android.Content.Intent.CategoryDefault })]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}