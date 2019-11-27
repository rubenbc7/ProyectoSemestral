using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para ParametrosElemento.xaml
    /// </summary>
    public partial class ParametrosElemento : UserControl
    {
        public string temp { get; set; }
        public string serietempo { get; set; }
        public string PeDirTemp { get; set; }
        public string PeSinoTemp { get; set; }
        public string PGeneTemp { get; set; }
        public string PeGeneTemp { get; set; }
        public int PeRatingTemp { get; set; }


        public string AAtemp { get; set; }
        public string AAserietempo { get; set; }
        public string SeDirTemp { get; set; }
        public string SeSinoTemp { get; set; }
        public string SeTemporaTemp { get; set; }
        public string SGeneTemp { get; set; }
        public string SeGeneTemp { get; set; }
        public int SeRatingTemp { get; set; }

        public ParametrosElemento()
        {
            InitializeComponent();
        }

        private void PEPelicula_Checked(object sender, RoutedEventArgs e)
        {

            grdElementos.Children.Clear();
            grdElementos.Children.Add(new ParametrosPelicula());
            grdElementos.Visibility = Visibility.Visible;

        }

        private void PESerie_Checked(object sender, RoutedEventArgs e)
        {

            grdElementos.Children.Clear();
            grdElementos.Children.Add(new ParametrosSerie());
            grdElementos.Visibility = Visibility.Visible;
        }

        public void Prueba()
        {
            if (PEPelicula.IsChecked == true)
            {
                temp = ((ParametrosPelicula)(grdElementos.Children[0])).PPTitulo.Text;
                AAtemp = ((ParametrosPelicula)(grdElementos.Children[0])).PPAno.Text;
                PeDirTemp = ((ParametrosPelicula)(grdElementos.Children[0])).PPDirector.Text;
                PeSinoTemp = ((ParametrosPelicula)(grdElementos.Children[0])).PPSinopsis.Text;

                if (((ParametrosPelicula)(grdElementos.Children[0])).PPGenero.SelectedIndex < 0)
                {
                    PeGeneTemp = "";
                }
                else
                {
                    PGeneTemp = ((ParametrosPelicula)(grdElementos.Children[0])).PPGenero.SelectedItem.ToString();
                    PeGeneTemp = PGeneTemp.Remove(0, 38);
                }
          


                if (((ParametrosPelicula)(grdElementos.Children[0])).PPR1.IsChecked == true)
                {
                    PeRatingTemp = 1;
                }
                if (((ParametrosPelicula)(grdElementos.Children[0])).PPR2.IsChecked == true)
                {
                    PeRatingTemp = 2;
                }
                if (((ParametrosPelicula)(grdElementos.Children[0])).PPR3.IsChecked == true)
                {
                    PeRatingTemp = 3;
                }
                if (((ParametrosPelicula)(grdElementos.Children[0])).PPR4.IsChecked == true)
                {
                    PeRatingTemp = 4;
                }
                if (((ParametrosPelicula)(grdElementos.Children[0])).PPR5.IsChecked == true)
                {
                    PeRatingTemp = 5;
                }
                
            }


            if (PESerie.IsChecked == true)
            {
                serietempo = ((ParametrosSerie)(grdElementos.Children[0])).PSTitulo.Text;
                AAserietempo = ((ParametrosSerie)(grdElementos.Children[0])).PSAno.Text;
                SeDirTemp =  ((ParametrosSerie)(grdElementos.Children[0])).PSDirector.Text;
                SeSinoTemp = ((ParametrosSerie)(grdElementos.Children[0])).PSSinopsis.Text;
                SeTemporaTemp = ((ParametrosSerie)(grdElementos.Children[0])).PSTemporadas.Text;
               
                if (((ParametrosSerie)(grdElementos.Children[0])).PSGenero.SelectedIndex < 0)
                {
                    SeGeneTemp = "";
                }
                else
                {
                    SGeneTemp = ((ParametrosSerie)(grdElementos.Children[0])).PSGenero.SelectedItem.ToString();
                    SeGeneTemp = SGeneTemp.Remove(0, 38);
                }

                if (((ParametrosSerie)(grdElementos.Children[0])).PSR1.IsChecked == true)
                {
                    SeRatingTemp = 1;
                }
                if (((ParametrosSerie)(grdElementos.Children[0])).PSR2.IsChecked == true)
                {
                    SeRatingTemp = 2;
                }
                if (((ParametrosSerie)(grdElementos.Children[0])).PSR3.IsChecked == true)
                {
                    SeRatingTemp = 3;
                }
                if (((ParametrosSerie)(grdElementos.Children[0])).PSR4.IsChecked == true)
                {
                    SeRatingTemp = 4;
                }
                if (((ParametrosSerie)(grdElementos.Children[0])).PSR5.IsChecked == true)
                {
                    SeRatingTemp = 5;
                }

            }
        }
    }
}
