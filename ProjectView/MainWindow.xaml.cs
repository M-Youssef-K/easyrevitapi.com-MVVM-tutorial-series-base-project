using System.Windows;
using WallTypesDisplayer.ProjectViewModel;
using Autodesk.Revit.DB;

// This code is a part of the M-V-VM series for Autodesk Revit add-ins tutorial by Mohamed-Youssef Krafess. Learn more at www.easyrevitapi.com
namespace WallTypesDisplayer
{

    public partial class MainWindow : Window
    {
        private ViewModel _viewModel;

        public ViewModel ViewModel { get { return _viewModel; } }
        public MainWindow(ViewModel vModel)
        {
            InitializeComponent();

            this._viewModel = vModel;
            DataContext = this._viewModel;
        }

        public void MainButtonAction(object sender, RoutedEventArgs e)
        {
            this._viewModel.UpdateSelectedWallTypeWidth();    
        }

    }
}
