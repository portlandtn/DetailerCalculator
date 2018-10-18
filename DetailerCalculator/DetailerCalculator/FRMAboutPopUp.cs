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
   public partial class FRMAboutPopUp : Form
   {
      public FRMAboutPopUp()
      {
         InitializeComponent();
         Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
         Text = Text + " " + version.Major + "." + version.Minor + " (build " + version.Build + ")"; //change form title
      }

      private void AboutFormLoad(object sender, EventArgs e)
      {
         string version = Application.ProductVersion;
         VersionLabel.Text = "Version: " + version;
      }
   }
}
