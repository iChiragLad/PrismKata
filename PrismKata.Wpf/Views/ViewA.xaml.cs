using System.Windows.Controls;
using PrismKata.ViewModels;

namespace PrismKata.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ViewA : UserControl
    {
        public ViewA()
        {
            InitializeComponent();
            DataContext = new ViewAViewModel();
        }
    }
}
