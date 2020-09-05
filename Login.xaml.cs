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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUsuario.Text == "Administrador" && txtContraseña.Password == "1234")
            {
                MainWindow admin = (MainWindow)Window.GetWindow(this);
                admin.frameMain.NavigationService.Navigate(new Administrador());
            }
            if (txtUsuario.Text == "Empleado" && txtContraseña.Password == "1234")
            {
                MainWindow employee = (MainWindow)Window.GetWindow(this);
                employee.frameMain.NavigationService.Navigate(new Empleados());
            }
        }
        private void txtContraseña_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "Administrador" && txtContraseña.Password == "1234")
            {
                MainWindow admin = (MainWindow)Window.GetWindow(this);
                admin.frameMain.NavigationService.Navigate(new Administrador());
            }
            if (txtUsuario.Text == "Empleado" && txtContraseña.Password == "1234")
            {
                MainWindow employee = (MainWindow)Window.GetWindow(this);
                employee.frameMain.NavigationService.Navigate(new Empleados());
            }
        }
    }
}
