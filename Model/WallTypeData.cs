using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

// This code is a part of the M-V-VM series for Autodesk Revit add-ins tutorial by Mohamed-Youssef Krafess. Learn more at www.easyrevitapi.com
namespace WallTypesDisplayer.Model
{
    public class WallTypeData
    {
        public static double ReturnWidth(WallType wallType) 
        {
            double WallTypeWidth_Feet = wallType.Width;
            double WallTypeWidth_Millimeters = WallTypeWidth_Feet * 304.8;

            return WallTypeWidth_Millimeters;
        }


    }
}
