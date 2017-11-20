namespace DetailerCalculator
{
    partial class FRMDetailerCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDetailerCalculator = new System.Windows.Forms.Label();
            this.pnlMathMethod = new System.Windows.Forms.Panel();
            this.lblMathMethod = new System.Windows.Forms.Label();
            this.rboStandardMethod = new System.Windows.Forms.RadioButton();
            this.rboDetailingMethod = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rboAngle4 = new System.Windows.Forms.RadioButton();
            this.rboAngle3 = new System.Windows.Forms.RadioButton();
            this.lblAngles = new System.Windows.Forms.Label();
            this.rboAngle2 = new System.Windows.Forms.RadioButton();
            this.rboAngle1 = new System.Windows.Forms.RadioButton();
            this.pnlMathButtons = new System.Windows.Forms.Panel();
            this.btnDec2Ft = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnFt2Dec = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTrig = new System.Windows.Forms.Button();
            this.txtNumberEntry = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRise2Base = new System.Windows.Forms.Button();
            this.btnRise2Slope = new System.Windows.Forms.Button();
            this.btnSlope2Rise = new System.Windows.Forms.Button();
            this.btnSlope2Base = new System.Windows.Forms.Button();
            this.btnBase2Slope = new System.Windows.Forms.Button();
            this.btnBase2Rise = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRiseSlope2Angle = new System.Windows.Forms.Button();
            this.btnBaseSlope2Angle = new System.Windows.Forms.Button();
            this.btnBaseRise2Angle = new System.Windows.Forms.Button();
            this.btnOverwriteAngle1 = new System.Windows.Forms.Button();
            this.pnlMathMethod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMathButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetailerCalculator
            // 
            this.lblDetailerCalculator.AutoSize = true;
            this.lblDetailerCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailerCalculator.Location = new System.Drawing.Point(218, 18);
            this.lblDetailerCalculator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailerCalculator.Name = "lblDetailerCalculator";
            this.lblDetailerCalculator.Size = new System.Drawing.Size(191, 26);
            this.lblDetailerCalculator.TabIndex = 0;
            this.lblDetailerCalculator.Text = "Detailer Calculator";
            // 
            // pnlMathMethod
            // 
            this.pnlMathMethod.Controls.Add(this.lblMathMethod);
            this.pnlMathMethod.Controls.Add(this.rboStandardMethod);
            this.pnlMathMethod.Controls.Add(this.rboDetailingMethod);
            this.pnlMathMethod.Location = new System.Drawing.Point(10, 18);
            this.pnlMathMethod.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMathMethod.Name = "pnlMathMethod";
            this.pnlMathMethod.Size = new System.Drawing.Size(89, 81);
            this.pnlMathMethod.TabIndex = 1;
            // 
            // lblMathMethod
            // 
            this.lblMathMethod.AutoSize = true;
            this.lblMathMethod.Location = new System.Drawing.Point(3, 3);
            this.lblMathMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMathMethod.Name = "lblMathMethod";
            this.lblMathMethod.Size = new System.Drawing.Size(70, 13);
            this.lblMathMethod.TabIndex = 2;
            this.lblMathMethod.Text = "Math Method";
            // 
            // rboStandardMethod
            // 
            this.rboStandardMethod.AutoSize = true;
            this.rboStandardMethod.Location = new System.Drawing.Point(3, 44);
            this.rboStandardMethod.Margin = new System.Windows.Forms.Padding(2);
            this.rboStandardMethod.Name = "rboStandardMethod";
            this.rboStandardMethod.Size = new System.Drawing.Size(68, 17);
            this.rboStandardMethod.TabIndex = 1;
            this.rboStandardMethod.Text = "Standard";
            this.rboStandardMethod.UseVisualStyleBackColor = true;
            // 
            // rboDetailingMethod
            // 
            this.rboDetailingMethod.AutoSize = true;
            this.rboDetailingMethod.Checked = true;
            this.rboDetailingMethod.Location = new System.Drawing.Point(3, 22);
            this.rboDetailingMethod.Margin = new System.Windows.Forms.Padding(2);
            this.rboDetailingMethod.Name = "rboDetailingMethod";
            this.rboDetailingMethod.Size = new System.Drawing.Size(66, 17);
            this.rboDetailingMethod.TabIndex = 0;
            this.rboDetailingMethod.TabStop = true;
            this.rboDetailingMethod.Text = "Detailing";
            this.rboDetailingMethod.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rboAngle4);
            this.panel1.Controls.Add(this.rboAngle3);
            this.panel1.Controls.Add(this.lblAngles);
            this.panel1.Controls.Add(this.rboAngle2);
            this.panel1.Controls.Add(this.rboAngle1);
            this.panel1.Location = new System.Drawing.Point(466, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 112);
            this.panel1.TabIndex = 2;
            // 
            // rboAngle4
            // 
            this.rboAngle4.AutoSize = true;
            this.rboAngle4.Location = new System.Drawing.Point(3, 88);
            this.rboAngle4.Margin = new System.Windows.Forms.Padding(2);
            this.rboAngle4.Name = "rboAngle4";
            this.rboAngle4.Size = new System.Drawing.Size(67, 17);
            this.rboAngle4.TabIndex = 4;
            this.rboAngle4.Text = "Angle 4: ";
            this.rboAngle4.UseVisualStyleBackColor = true;
            // 
            // rboAngle3
            // 
            this.rboAngle3.AutoSize = true;
            this.rboAngle3.Location = new System.Drawing.Point(3, 66);
            this.rboAngle3.Margin = new System.Windows.Forms.Padding(2);
            this.rboAngle3.Name = "rboAngle3";
            this.rboAngle3.Size = new System.Drawing.Size(67, 17);
            this.rboAngle3.TabIndex = 3;
            this.rboAngle3.Text = "Angle 3: ";
            this.rboAngle3.UseVisualStyleBackColor = true;
            // 
            // lblAngles
            // 
            this.lblAngles.AutoSize = true;
            this.lblAngles.Location = new System.Drawing.Point(3, 3);
            this.lblAngles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAngles.Name = "lblAngles";
            this.lblAngles.Size = new System.Drawing.Size(39, 13);
            this.lblAngles.TabIndex = 2;
            this.lblAngles.Text = "Angles";
            // 
            // rboAngle2
            // 
            this.rboAngle2.AutoSize = true;
            this.rboAngle2.Location = new System.Drawing.Point(3, 44);
            this.rboAngle2.Margin = new System.Windows.Forms.Padding(2);
            this.rboAngle2.Name = "rboAngle2";
            this.rboAngle2.Size = new System.Drawing.Size(67, 17);
            this.rboAngle2.TabIndex = 1;
            this.rboAngle2.Text = "Angle 2: ";
            this.rboAngle2.UseVisualStyleBackColor = true;
            // 
            // rboAngle1
            // 
            this.rboAngle1.AutoSize = true;
            this.rboAngle1.Checked = true;
            this.rboAngle1.Location = new System.Drawing.Point(3, 22);
            this.rboAngle1.Margin = new System.Windows.Forms.Padding(2);
            this.rboAngle1.Name = "rboAngle1";
            this.rboAngle1.Size = new System.Drawing.Size(67, 17);
            this.rboAngle1.TabIndex = 0;
            this.rboAngle1.TabStop = true;
            this.rboAngle1.Text = "Angle 1: ";
            this.rboAngle1.UseVisualStyleBackColor = true;
            this.rboAngle1.CheckedChanged += new System.EventHandler(this.RboAngle1_CheckedChanged);
            // 
            // pnlMathButtons
            // 
            this.pnlMathButtons.Controls.Add(this.btnDec2Ft);
            this.pnlMathButtons.Controls.Add(this.btnPlusMinus);
            this.pnlMathButtons.Controls.Add(this.btnDivide);
            this.pnlMathButtons.Controls.Add(this.btnMultiply);
            this.pnlMathButtons.Controls.Add(this.btnFt2Dec);
            this.pnlMathButtons.Controls.Add(this.btnSubtract);
            this.pnlMathButtons.Controls.Add(this.btnAdd);
            this.pnlMathButtons.Controls.Add(this.btnTrig);
            this.pnlMathButtons.Location = new System.Drawing.Point(10, 104);
            this.pnlMathButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMathButtons.Name = "pnlMathButtons";
            this.pnlMathButtons.Size = new System.Drawing.Size(211, 89);
            this.pnlMathButtons.TabIndex = 3;
            // 
            // btnDec2Ft
            // 
            this.btnDec2Ft.Location = new System.Drawing.Point(138, 58);
            this.btnDec2Ft.Margin = new System.Windows.Forms.Padding(2);
            this.btnDec2Ft.Name = "btnDec2Ft";
            this.btnDec2Ft.Size = new System.Drawing.Size(63, 23);
            this.btnDec2Ft.TabIndex = 8;
            this.btnDec2Ft.Text = "Dec to Ft";
            this.btnDec2Ft.UseVisualStyleBackColor = true;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(3, 58);
            this.btnPlusMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(63, 23);
            this.btnPlusMinus.TabIndex = 6;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(138, 31);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(63, 23);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(70, 31);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(63, 23);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnFt2Dec
            // 
            this.btnFt2Dec.Location = new System.Drawing.Point(70, 58);
            this.btnFt2Dec.Margin = new System.Windows.Forms.Padding(2);
            this.btnFt2Dec.Name = "btnFt2Dec";
            this.btnFt2Dec.Size = new System.Drawing.Size(63, 23);
            this.btnFt2Dec.TabIndex = 3;
            this.btnFt2Dec.Text = "Ft to Dec";
            this.btnFt2Dec.UseVisualStyleBackColor = true;
            this.btnFt2Dec.Click += new System.EventHandler(this.BtnFt2Dec_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(138, 3);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(63, 23);
            this.btnSubtract.TabIndex = 2;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnTrig
            // 
            this.btnTrig.Location = new System.Drawing.Point(3, 3);
            this.btnTrig.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrig.Name = "btnTrig";
            this.btnTrig.Size = new System.Drawing.Size(63, 23);
            this.btnTrig.TabIndex = 0;
            this.btnTrig.Text = "Trig";
            this.btnTrig.UseVisualStyleBackColor = true;
            this.btnTrig.Click += new System.EventHandler(this.BtnTrig_Click);
            // 
            // txtNumberEntry
            // 
            this.txtNumberEntry.Location = new System.Drawing.Point(10, 198);
            this.txtNumberEntry.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberEntry.Name = "txtNumberEntry";
            this.txtNumberEntry.Size = new System.Drawing.Size(212, 20);
            this.txtNumberEntry.TabIndex = 4;
            this.txtNumberEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOutput
            // 
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutput.Location = new System.Drawing.Point(259, 138);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(357, 222);
            this.btnOutput.TabIndex = 5;
            this.btnOutput.Text = "0";
            this.btnOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRise2Base);
            this.panel3.Controls.Add(this.btnRise2Slope);
            this.panel3.Controls.Add(this.btnSlope2Rise);
            this.panel3.Controls.Add(this.btnSlope2Base);
            this.panel3.Controls.Add(this.btnBase2Slope);
            this.panel3.Controls.Add(this.btnBase2Rise);
            this.panel3.Location = new System.Drawing.Point(10, 221);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 81);
            this.panel3.TabIndex = 8;
            // 
            // btnRise2Base
            // 
            this.btnRise2Base.Location = new System.Drawing.Point(64, 50);
            this.btnRise2Base.Margin = new System.Windows.Forms.Padding(2);
            this.btnRise2Base.Name = "btnRise2Base";
            this.btnRise2Base.Size = new System.Drawing.Size(56, 19);
            this.btnRise2Base.TabIndex = 5;
            this.btnRise2Base.Text = "R to B";
            this.btnRise2Base.UseVisualStyleBackColor = true;
            // 
            // btnRise2Slope
            // 
            this.btnRise2Slope.Location = new System.Drawing.Point(64, 26);
            this.btnRise2Slope.Margin = new System.Windows.Forms.Padding(2);
            this.btnRise2Slope.Name = "btnRise2Slope";
            this.btnRise2Slope.Size = new System.Drawing.Size(56, 19);
            this.btnRise2Slope.TabIndex = 4;
            this.btnRise2Slope.Text = "R to S";
            this.btnRise2Slope.UseVisualStyleBackColor = true;
            // 
            // btnSlope2Rise
            // 
            this.btnSlope2Rise.Location = new System.Drawing.Point(64, 2);
            this.btnSlope2Rise.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlope2Rise.Name = "btnSlope2Rise";
            this.btnSlope2Rise.Size = new System.Drawing.Size(56, 19);
            this.btnSlope2Rise.TabIndex = 3;
            this.btnSlope2Rise.Text = "S to R";
            this.btnSlope2Rise.UseVisualStyleBackColor = true;
            // 
            // btnSlope2Base
            // 
            this.btnSlope2Base.Location = new System.Drawing.Point(3, 49);
            this.btnSlope2Base.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlope2Base.Name = "btnSlope2Base";
            this.btnSlope2Base.Size = new System.Drawing.Size(56, 19);
            this.btnSlope2Base.TabIndex = 2;
            this.btnSlope2Base.Text = "S to B";
            this.btnSlope2Base.UseVisualStyleBackColor = true;
            // 
            // btnBase2Slope
            // 
            this.btnBase2Slope.Location = new System.Drawing.Point(3, 25);
            this.btnBase2Slope.Margin = new System.Windows.Forms.Padding(2);
            this.btnBase2Slope.Name = "btnBase2Slope";
            this.btnBase2Slope.Size = new System.Drawing.Size(56, 19);
            this.btnBase2Slope.TabIndex = 1;
            this.btnBase2Slope.Text = "B to S";
            this.btnBase2Slope.UseVisualStyleBackColor = true;
            // 
            // btnBase2Rise
            // 
            this.btnBase2Rise.Location = new System.Drawing.Point(3, 2);
            this.btnBase2Rise.Margin = new System.Windows.Forms.Padding(2);
            this.btnBase2Rise.Name = "btnBase2Rise";
            this.btnBase2Rise.Size = new System.Drawing.Size(56, 19);
            this.btnBase2Rise.TabIndex = 0;
            this.btnBase2Rise.Text = "B to R";
            this.btnBase2Rise.UseVisualStyleBackColor = true;
            this.btnBase2Rise.Click += new System.EventHandler(this.BtnBase2Rise_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRiseSlope2Angle);
            this.panel2.Controls.Add(this.btnBaseSlope2Angle);
            this.panel2.Controls.Add(this.btnBaseRise2Angle);
            this.panel2.Location = new System.Drawing.Point(164, 221);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 81);
            this.panel2.TabIndex = 9;
            // 
            // btnRiseSlope2Angle
            // 
            this.btnRiseSlope2Angle.Location = new System.Drawing.Point(3, 50);
            this.btnRiseSlope2Angle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRiseSlope2Angle.Name = "btnRiseSlope2Angle";
            this.btnRiseSlope2Angle.Size = new System.Drawing.Size(56, 19);
            this.btnRiseSlope2Angle.TabIndex = 7;
            this.btnRiseSlope2Angle.Text = "RS 2 A";
            this.btnRiseSlope2Angle.UseVisualStyleBackColor = true;
            // 
            // btnBaseSlope2Angle
            // 
            this.btnBaseSlope2Angle.Location = new System.Drawing.Point(3, 26);
            this.btnBaseSlope2Angle.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaseSlope2Angle.Name = "btnBaseSlope2Angle";
            this.btnBaseSlope2Angle.Size = new System.Drawing.Size(56, 19);
            this.btnBaseSlope2Angle.TabIndex = 6;
            this.btnBaseSlope2Angle.Text = "BS to A";
            this.btnBaseSlope2Angle.UseVisualStyleBackColor = true;
            // 
            // btnBaseRise2Angle
            // 
            this.btnBaseRise2Angle.Location = new System.Drawing.Point(2, 2);
            this.btnBaseRise2Angle.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaseRise2Angle.Name = "btnBaseRise2Angle";
            this.btnBaseRise2Angle.Size = new System.Drawing.Size(56, 19);
            this.btnBaseRise2Angle.TabIndex = 5;
            this.btnBaseRise2Angle.Text = "BR to A";
            this.btnBaseRise2Angle.UseVisualStyleBackColor = true;
            // 
            // btnOverwriteAngle1
            // 
            this.btnOverwriteAngle1.Location = new System.Drawing.Point(386, 47);
            this.btnOverwriteAngle1.Name = "btnOverwriteAngle1";
            this.btnOverwriteAngle1.Size = new System.Drawing.Size(75, 23);
            this.btnOverwriteAngle1.TabIndex = 10;
            this.btnOverwriteAngle1.Text = "Overwrite";
            this.btnOverwriteAngle1.UseVisualStyleBackColor = true;
            this.btnOverwriteAngle1.Click += new System.EventHandler(this.BtnOverwriteAngle1_Click);
            // 
            // FRMDetailerCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 370);
            this.Controls.Add(this.btnOverwriteAngle1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtNumberEntry);
            this.Controls.Add(this.pnlMathButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMathMethod);
            this.Controls.Add(this.lblDetailerCalculator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMDetailerCalculator";
            this.Text = "Detailer Calculator";
            this.Load += new System.EventHandler(this.FRMDetailerCalculator_Load);
            this.pnlMathMethod.ResumeLayout(false);
            this.pnlMathMethod.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMathButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetailerCalculator;
        private System.Windows.Forms.Panel pnlMathMethod;
        private System.Windows.Forms.Label lblMathMethod;
        private System.Windows.Forms.RadioButton rboStandardMethod;
        private System.Windows.Forms.RadioButton rboDetailingMethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAngles;
        private System.Windows.Forms.RadioButton rboAngle2;
        private System.Windows.Forms.RadioButton rboAngle1;
        private System.Windows.Forms.Panel pnlMathButtons;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnFt2Dec;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTrig;
        private System.Windows.Forms.Button btnDec2Ft;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.TextBox txtNumberEntry;
        private System.Windows.Forms.RadioButton rboAngle4;
        private System.Windows.Forms.RadioButton rboAngle3;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRise2Base;
        private System.Windows.Forms.Button btnRise2Slope;
        private System.Windows.Forms.Button btnSlope2Rise;
        private System.Windows.Forms.Button btnSlope2Base;
        private System.Windows.Forms.Button btnBase2Slope;
        private System.Windows.Forms.Button btnBase2Rise;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRiseSlope2Angle;
        private System.Windows.Forms.Button btnBaseSlope2Angle;
        private System.Windows.Forms.Button btnBaseRise2Angle;
        private System.Windows.Forms.Button btnOverwriteAngle1;
    }
}

