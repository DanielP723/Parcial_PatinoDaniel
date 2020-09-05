using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial_PatiñoDaniel
{
    /// <summary>
    /// Lógica de interacción para Empleados.xaml
    /// </summary>
    public partial class Empleados : Page
    {
        public Empleados()
        {
            InitializeComponent();

            
        }
        private void btnQuitar_Click(object sender, RoutedEventArgs e)
        {
            lbProductos.Items.Remove(lbProductos.SelectedItem);
            txtAliñado.Text = "";
            txtEspecial.Text = "";
            txtNoaliñado.Text = "";
        }


        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            lblHora.Content = DateTime.Now.ToString("hh:mm:ss");
            lblNombre.Content = txtCliente.Text;
            lblCédula.Content = txtCédula.Text;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbProductos.Items.Add("Aliñado x" + txtAliñado.Text);
            lbProductos.Items.Add("No aliñado x" + txtNoaliñado.Text);
            lbProductos.Items.Add("Especial x" + txtEspecial.Text);

        }
    }
}
