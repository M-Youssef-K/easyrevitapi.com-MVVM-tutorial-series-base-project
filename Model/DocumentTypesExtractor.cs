using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// This code is a part of the M-V-VM series for Autodesk Revit add-ins tutorial by Mohamed-Youssef Krafess. Learn more at www.easyrevitapi.com
namespace WallTypesDisplayer.Model
{
    public class DocumentTypesExtractor
    {
        public static List<WallType> ExtractWallTypes(Document rvtDocument) 
        {
            IList<Element> documentWallTypes = new FilteredElementCollector(rvtDocument).OfClass(typeof(WallType)).ToElements();

            return documentWallTypes.Cast<WallType>().ToList();        
        }
    }
}
