using Autodesk.Revit.Creation;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WallTypesDisplayer.Model;
using Document = Autodesk.Revit.DB.Document;


// This code is a part of the M-V-VM series for Autodesk Revit add-ins tutorial by Mohamed-Youssef Krafess. Learn more at www.easyrevitapi.com
namespace WallTypesDisplayer.ProjectViewModel 
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Document _revitDocument;
        public Document RevitDocument 
        {
            get { return _revitDocument; }
            set { _revitDocument = value; }     
        }

        private List<WallType> _revitDocumentWallTypes;
        public List<WallType> RevitDocumentWallTypes
        {
            get { return _revitDocumentWallTypes; }
            set { _revitDocumentWallTypes = value; }
        }

        private WallType _selectedWallType;
        public WallType SelectedWallType
        {
            get { return _selectedWallType; }
            set { _selectedWallType = value; }
        }

        private double _selectedWallTypeWidth;
        public double SelectedWallTypeWidth
        {
            get { return _selectedWallTypeWidth; }
            set
            {
                _selectedWallTypeWidth = value;
                OnPropertyChanged();
            }
        }

        public ViewModel(Document rvtDocument)
        {
            this.RevitDocument = rvtDocument;
            this.RevitDocumentWallTypes = DocumentTypesExtractor.ExtractWallTypes(rvtDocument);
        }

        public void UpdateSelectedWallTypeWidth()
        {
            this.SelectedWallTypeWidth = WallTypeData.ReturnWidth(this.SelectedWallType);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
