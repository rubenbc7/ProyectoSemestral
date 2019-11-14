using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoSemestral
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> pelicula = new ObservableCollection<string>();
        ObservableCollection<string> ano = new ObservableCollection<string>();
        public string titulomaybe { get; set; }
        public string anomaybe { get; set; }
    

        public MainWindow()
        {
            InitializeComponent();
            lstNombre.ItemsSource = pelicula;
            lstAno.ItemsSource = ano;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
            grdParametros.Children.Add(new ParametrosElemento());
            grdParametros.Visibility = Visibility.Visible;
            btnA1.Visibility = Visibility.Hidden;
            btnA2.Visibility = Visibility.Hidden;
            btnAno1.Visibility = Visibility.Hidden;
            btnAno2.Visibility = Visibility.Hidden;
            btnAgregar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
            grdParametros.Visibility = Visibility.Hidden;
            btnA1.Visibility = Visibility.Visible;
            btnA2.Visibility = Visibility.Visible;
            btnAno1.Visibility = Visibility.Visible;
            btnAno2.Visibility = Visibility.Visible;
            btnAgregar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            ((ParametrosElemento)(grdParametros.Children[0])).Prueba();
            //Pelicula temp = new Pelicula("Sin Titulo");
            if (((ParametrosElemento)(grdParametros.Children[0])).PEPelicula.IsChecked == true)
            {
                titulomaybe = ((ParametrosElemento)(grdParametros.Children[0])).temp;
                anomaybe = ((ParametrosElemento)(grdParametros.Children[0])).AAtemp;
            }
            if (((ParametrosElemento)(grdParametros.Children[0])).PESerie.IsChecked == true)
            {
                titulomaybe = ((ParametrosElemento)(grdParametros.Children[0])).serietempo;
                anomaybe = ((ParametrosElemento)(grdParametros.Children[0])).AAserietempo;
            }

            ano.Add(anomaybe);
            pelicula.Add(titulomaybe);

            grdParametros.Children.Clear();
            grdParametros.Visibility = Visibility.Hidden;
            btnA1.Visibility = Visibility.Visible;
            btnA2.Visibility = Visibility.Visible;
            btnAno1.Visibility = Visibility.Visible;
            btnAno2.Visibility = Visibility.Visible;
            btnAgregar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
