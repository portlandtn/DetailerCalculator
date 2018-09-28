using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailerCalculator
{
    public partial class FRMTrig : Form
    {
        public FRMTrig(double angle1, double angle2, double angle3, double angle4)
        {
            InitializeComponent();
         rboAngle1.Text = Convert.ToString("Angle1: " + angle1);
         rboAngle1.Text = Convert.ToString("Angle2: " + angle2);
         rboAngle1.Text = Convert.ToString("Angle3: " + angle3);
         rboAngle1.Text = Convert.ToString("Angle4: " + angle4);
      }

        private void FRMTrig_Load(object sender, EventArgs e)
        {

        }

      private void Panel3_Paint(object sender, PaintEventArgs e)
      {

      }
    }
}
