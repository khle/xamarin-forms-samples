﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace HelloXamarinFormsWorldXaml.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("HelloXamarinFormsWorldXaml");
            window.Show();
            Gtk.Application.Run();
        }
    }
}