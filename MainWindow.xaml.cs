using RegistroRoles.UI.Consultas;
using RegistroRoles.UI.Registros;
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

namespace RegistroRoles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RolMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rRoles roless = new rRoles();
            roless.Show();
        }

        private void ConsultaUsuarioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios consulta = new cUsuarios();
            consulta.Show();
        }

        private void ConsultaRolMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cRoles rol = new cRoles();
            rol.Show();
        }

        private void UsuarioMenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            rUsuarios usuarioo = new rUsuarios();
            usuarioo.Show();
        }
    }
}
