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

namespace CMCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ClaimSubmission : Window
    {
        public ClaimSubmission()
        {
            InitializeComponent();
        }
        private void OpenLecturerWindow_Click(object sender, RoutedEventArgs e)
        {
            ClaimSubmission lecturerWindow = new ClaimSubmission();
            lecturerWindow.Show();
        }

        private void OpenCoordinatorWindow_Click(object sender, RoutedEventArgs e)
        {
            CoordinatorDashboard coordinatorWindow = new CoordinatorDashboard();
            coordinatorWindow.Show();
        }

        private void OpenManagerWindow_Click(object sender, RoutedEventArgs e)
        {
            ManagerDashboard managerWindow = new ManagerDashboard();
            managerWindow.Show();

        }
    }
}

   
