using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;

using Gurobi;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Drawing.Drawing2D;

namespace UncertaintyClassification
{
    public class UncertaintyClassification : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public UncertaintyClassification()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;
            frmOptClassfication pfrmOptClassification = new frmOptClassfication();
            pfrmOptClassification.Show();
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
