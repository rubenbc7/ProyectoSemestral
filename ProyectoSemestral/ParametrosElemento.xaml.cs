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
        public string AAtemp { get; set; }
        public string AAserietempo { get; set; }
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
            }
            if (PESerie.IsChecked == true)
            {
                serietempo = ((ParametrosSerie)(grdElementos.Children[0])).PSTitulo.Text;
                AAserietempo = ((ParametrosSerie)(grdElementos.Children[0])).PSAno.Text;
            }
        }
    }
}
