﻿using System;
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
        public FRMTrig()
        {
            InitializeComponent();
        }

        private void FRMTrig_Load(object sender, EventArgs e)
        {
            rboAngle1.Text = FRMDetailerCalculator.Angle1;
            rboAngle2.Text = FRMDetailerCalculator.Angle2;
            rboAngle3.Text = FRMDetailerCalculator.Angle3;
            rboAngle4.Text = FRMDetailerCalculator.Angle4;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
