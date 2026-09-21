using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SushiGo
{
    /// <summary>
    /// Interaction logic for CreateAccountPage.xaml
    /// </summary>
    public partial class CreateAccountPage : Window
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void btnLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == "es-MX")
            {
                App.ChangeLanguage("en-US");
            }
            else
            {
                App.ChangeLanguage("es-MX");
            }

            CreateAccountPage newWindow = new CreateAccountPage();
            newWindow.Show();

            this.Close();
        }
    }
}
