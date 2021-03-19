using System;
using Gtk;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("window", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
