using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Semaforo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (Rojo.IsChecked.Value)
            {
                string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                Imagen.Source = new BitmapImage(new Uri(projectDirectory + "/z-rojo.jpg", UriKind.Absolute));
            }
            if (Ambar.IsChecked.Value)
            {
                string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                Imagen.Source = new BitmapImage(new Uri(projectDirectory + "/z-ambar.jpg", UriKind.Absolute));

            }
            if (Verde.IsChecked.Value)
            {
                string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                Imagen.Source = new BitmapImage(new Uri(projectDirectory + "/z-verde.jpg", UriKind.Absolute));
            }

        }
    }
}
