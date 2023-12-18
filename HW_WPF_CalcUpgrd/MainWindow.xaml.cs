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

namespace HW_WPF_CalcUpgrd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalcVievMod modViev;
        public MainWindow()
        {
            InitializeComponent();
            modViev = new CalcVievMod();
        }

        private void ClAllClick(object sender, RoutedEventArgs e)
        {
            Disp.Text = "";
            Hist.Text = "";
            modViev.Clear();
        }

        private void ClCLick(object sender, RoutedEventArgs e)
        {
            Disp.Text = "";
        }

        private void DelClick(object sender, RoutedEventArgs e)
        {
            if (Disp.Text.Length != 0)
            {
                Disp.Text = Disp.Text.Remove(Disp.Text.Length - 1);
            }
        }

        private void OpClick(object sender, RoutedEventArgs e)
        {
            if (Disp.Text.Length != 0)
            {
                Hist.Text = modViev.Operation((sender as Button).Content as string, Disp.Text);
                Disp.Text = "";
            }
        }

        private void NumbClick(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + (sender as Button).Content;
        }
    }
}