using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Windows;
using WallTypesDisplayer.ProjectViewModel;


// This code is a part of the M-V-VM series for Autodesk Revit add-ins tutorial by Mohamed-Youssef Krafess. Learn more at www.easyrevitapi.com
namespace WallTypesDisplayer
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class ExternalCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document revitDocument = commandData.Application.ActiveUIDocument.Document;
            ViewModel viewModel = new ViewModel(revitDocument);
            MainWindow mainView = new MainWindow(viewModel);

            mainView.ShowDialog();
            return Result.Succeeded;

        }
    }
}
