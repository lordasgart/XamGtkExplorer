using System;
using System.Net;
using Gdk;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace XamGtkExplorer.GTK
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            Gtk.Application.Init();
            Forms.Init();
            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("XamGtkExplorer");
            window.Icon = Pixbuf.LoadFromResource("XamGtkExplorer.GTK.Application-icon.png");
            window.Show();
            Gtk.Application.Run();
        }
    }
}
