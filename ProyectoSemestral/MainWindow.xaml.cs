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
        ObservableCollection<string> director = new ObservableCollection<string>();
        ObservableCollection<string> sinopsis = new ObservableCollection<string>();
        ObservableCollection<string> temporadas = new ObservableCollection<string>();
        ObservableCollection<string> genero = new ObservableCollection<string>();
        ObservableCollection<int> rating = new ObservableCollection<int>();

        public string titulomaybe { get; set; }
        public string anomaybe { get; set; }
        public string directormaybe { get; set; }
        public string sinopsismaybe { get; set; }
        public string temporadasmaybe { get; set; }
        public string generomaybe { get; set; }

        public int ratingmaybe { get; set; }


    

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

            PPEstrella1.Visibility = Visibility.Hidden;
            PPEstrella2.Visibility = Visibility.Hidden;
            PPEstrella3.Visibility = Visibility.Hidden;
            PPEstrella4.Visibility = Visibility.Hidden;
            PPEstrella5.Visibility = Visibility.Hidden;

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
            //((ParametrosElemento)(grdParametros.Children[0])).RatingInt();
            //Pelicula temp = new Pelicula("Sin Titulo");
            if (((ParametrosElemento)(grdParametros.Children[0])).PEPelicula.IsChecked == true)
            {
                titulomaybe = ((ParametrosElemento)(grdParametros.Children[0])).temp;
                anomaybe = ((ParametrosElemento)(grdParametros.Children[0])).AAtemp;
                directormaybe = ((ParametrosElemento)(grdParametros.Children[0])).PeDirTemp;
                sinopsismaybe = ((ParametrosElemento)(grdParametros.Children[0])).PeSinoTemp;
                temporadasmaybe = "";
                ratingmaybe = ((ParametrosElemento)(grdParametros.Children[0])).PeRatingTemp;
                generomaybe = ((ParametrosElemento)(grdParametros.Children[0])).PeGeneTemp;

            }
            if (((ParametrosElemento)(grdParametros.Children[0])).PESerie.IsChecked == true)
            {
                titulomaybe = ((ParametrosElemento)(grdParametros.Children[0])).serietempo;
                anomaybe = ((ParametrosElemento)(grdParametros.Children[0])).AAserietempo;
                directormaybe = ((ParametrosElemento)(grdParametros.Children[0])).SeDirTemp;
                sinopsismaybe = ((ParametrosElemento)(grdParametros.Children[0])).SeSinoTemp;
                temporadasmaybe = ((ParametrosElemento)(grdParametros.Children[0])).SeTemporaTemp;
                ratingmaybe = ((ParametrosElemento)(grdParametros.Children[0])).SeRatingTemp;
                generomaybe = ((ParametrosElemento)(grdParametros.Children[0])).SeGeneTemp;

            }

            ano.Add(anomaybe);
            pelicula.Add(titulomaybe);
            director.Add(directormaybe);
            sinopsis.Add(sinopsismaybe);
            temporadas.Add(temporadasmaybe);
            genero.Add(generomaybe);
            rating.Add(ratingmaybe);

            grdParametros.Children.Clear();
            grdParametros.Visibility = Visibility.Hidden;
            btnA1.Visibility = Visibility.Visible;
            btnA2.Visibility = Visibility.Visible;
            btnAno1.Visibility = Visibility.Visible;
            btnAno2.Visibility = Visibility.Visible;
            btnAgregar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;


            PPEstrella1.Visibility = Visibility.Hidden;
            PPEstrella2.Visibility = Visibility.Hidden;
            PPEstrella3.Visibility = Visibility.Hidden;
            PPEstrella4.Visibility = Visibility.Hidden; 
            PPEstrella5.Visibility = Visibility.Hidden;
        }

        private void LstNombre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnEditarElemento.Visibility = Visibility.Visible;
            grdParametros.Children.Clear();
            grdParametros.Visibility = Visibility.Visible;
            grdParametros.Children.Add(new SeleccionPelicula());

            ((SeleccionPelicula)(grdParametros.Children[0])).PPTitulo.IsEnabled = false;
            ((SeleccionPelicula)(grdParametros.Children[0])).PPAno.IsEnabled = false;
            ((SeleccionPelicula)(grdParametros.Children[0])).PPDirector.IsEnabled = false;
            ((SeleccionPelicula)(grdParametros.Children[0])).PPSinopsis.IsEnabled = false;
            ((SeleccionPelicula)(grdParametros.Children[0])).PPTemporadas.IsEnabled = false;
            ((SeleccionPelicula)(grdParametros.Children[0])).PPGenero.IsEnabled = false;

            ((SeleccionPelicula)(grdParametros.Children[0])).PPTitulo.Text = pelicula[lstNombre.SelectedIndex];
            ((SeleccionPelicula)(grdParametros.Children[0])).PPAno.Text = ano[lstNombre.SelectedIndex];
            ((SeleccionPelicula)(grdParametros.Children[0])).PPDirector.Text = director[lstNombre.SelectedIndex];
            ((SeleccionPelicula)(grdParametros.Children[0])).PPSinopsis.Text = sinopsis[lstNombre.SelectedIndex];
            ((SeleccionPelicula)(grdParametros.Children[0])).PPTemporadas.Text = temporadas[lstNombre.SelectedIndex];
            ((SeleccionPelicula)(grdParametros.Children[0])).PPGenero.Text = genero[lstNombre.SelectedIndex];


            if (String.IsNullOrEmpty(((SeleccionPelicula)(grdParametros.Children[0])).PPTemporadas.Text))
            {
                ((SeleccionPelicula)(grdParametros.Children[0])).PPTemporadas.Visibility = Visibility.Hidden;
                ((SeleccionPelicula)(grdParametros.Children[0])).PPTemporadasPP.Visibility = Visibility.Hidden;

            }
            else
            {
                ((SeleccionPelicula)(grdParametros.Children[0])).PPTemporadas.Visibility = Visibility.Visible;
                ((SeleccionPelicula)(grdParametros.Children[0])).PPTemporadasPP.Visibility = Visibility.Visible;

            }

            if(rating[lstNombre.SelectedIndex] == 1)
            {
              PPEstrella1.Visibility = Visibility.Visible;
              PPEstrella2.Visibility = Visibility.Hidden;
                PPEstrella3.Visibility = Visibility.Hidden;
                PPEstrella4.Visibility = Visibility.Hidden;
                PPEstrella5.Visibility = Visibility.Hidden;
            }
            if (rating[lstNombre.SelectedIndex] == 2)
            {
                PPEstrella1.Visibility = Visibility.Visible;
                PPEstrella2.Visibility = Visibility.Visible;
                PPEstrella3.Visibility = Visibility.Hidden;
                PPEstrella4.Visibility = Visibility.Hidden;
                PPEstrella5.Visibility = Visibility.Hidden;
            }
            if (rating[lstNombre.SelectedIndex] == 3)
            {
                PPEstrella1.Visibility = Visibility.Visible;
                PPEstrella2.Visibility = Visibility.Visible;
                PPEstrella3.Visibility = Visibility.Visible;
                PPEstrella4.Visibility = Visibility.Hidden;
                PPEstrella5.Visibility = Visibility.Hidden;
            }
            if (rating[lstNombre.SelectedIndex] == 4)
            {
                PPEstrella1.Visibility = Visibility.Visible;
                PPEstrella2.Visibility = Visibility.Visible;
                PPEstrella3.Visibility = Visibility.Visible;
                PPEstrella4.Visibility = Visibility.Visible;
                PPEstrella5.Visibility = Visibility.Hidden;
            }
            if (rating[lstNombre.SelectedIndex] == 5)
            {
                PPEstrella1.Visibility = Visibility.Visible;
                PPEstrella2.Visibility = Visibility.Visible;
                PPEstrella3.Visibility = Visibility.Visible;
                PPEstrella4.Visibility = Visibility.Visible;
                PPEstrella5.Visibility = Visibility.Visible;
            }
        }
    }
}
