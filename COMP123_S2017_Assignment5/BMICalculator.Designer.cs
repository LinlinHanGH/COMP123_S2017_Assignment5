namespace COMP123_S2017_Assignment5
{
    partial class BMICalculator
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
            this.components = new System.ComponentModel.Container();
            this.StandardMetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.SevenButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReferenceLabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BMIlabel = new System.Windows.Forms.Label();
            this.Ref_titleBMI_label = new System.Windows.Forms.Label();
            this.Ref_titleResultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Ref_UnderweightLabel = new System.Windows.Forms.Label();
            this.ReferenceTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Ref_Under_ResLabel = new System.Windows.Forms.Label();
            this.Ref_NormalLabel = new System.Windows.Forms.Label();
            this.Ref_OverweightLabel = new System.Windows.Forms.Label();
            this.Ref_ObeseLabel = new System.Windows.Forms.Label();
            this.Ref_Normal_ResLabel = new System.Windows.Forms.Label();
            this.Ref_Over_ResLabel = new System.Windows.Forms.Label();
            this.Ref_Obese_ResLabel = new System.Windows.Forms.Label();
            this.StandardMetricTableLayoutPanel.SuspendLayout();
            this.CalculationTableLayoutPanel.SuspendLayout();
            this.ResultTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ReferenceTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandardMetricTableLayoutPanel
            // 
            this.StandardMetricTableLayoutPanel.ColumnCount = 2;
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.Controls.Add(this.StandardRadioButton, 0, 0);
            this.StandardMetricTableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 0);
            this.StandardMetricTableLayoutPanel.Location = new System.Drawing.Point(28, 47);
            this.StandardMetricTableLayoutPanel.Name = "StandardMetricTableLayoutPanel";
            this.StandardMetricTableLayoutPanel.RowCount = 1;
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StandardMetricTableLayoutPanel.Size = new System.Drawing.Size(316, 44);
            this.StandardMetricTableLayoutPanel.TabIndex = 0;
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardRadioButton.Location = new System.Drawing.Point(11, 5);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(135, 33);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(185, 5);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(104, 33);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // CalculationTableLayoutPanel
            // 
            this.CalculationTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationTableLayoutPanel.ColumnCount = 3;
            this.CalculationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.CalculationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculationTableLayoutPanel.Controls.Add(this.CalculateButton, 2, 5);
            this.CalculationTableLayoutPanel.Controls.Add(this.ResetButton, 1, 5);
            this.CalculationTableLayoutPanel.Controls.Add(this.ZeroButton, 0, 5);
            this.CalculationTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 4);
            this.CalculationTableLayoutPanel.Controls.Add(this.TwoButton, 1, 4);
            this.CalculationTableLayoutPanel.Controls.Add(this.OneButton, 0, 4);
            this.CalculationTableLayoutPanel.Controls.Add(this.SixButton, 2, 3);
            this.CalculationTableLayoutPanel.Controls.Add(this.FiveButton, 1, 3);
            this.CalculationTableLayoutPanel.Controls.Add(this.FourButton, 0, 3);
            this.CalculationTableLayoutPanel.Controls.Add(this.NineButton, 2, 2);
            this.CalculationTableLayoutPanel.Controls.Add(this.EightButton, 1, 2);
            this.CalculationTableLayoutPanel.Controls.Add(this.HeightUnitLabel, 2, 0);
            this.CalculationTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.CalculationTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.CalculationTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.CalculationTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.CalculationTableLayoutPanel.Controls.Add(this.WeightUnitLabel, 2, 1);
            this.CalculationTableLayoutPanel.Controls.Add(this.SevenButton, 0, 2);
            this.CalculationTableLayoutPanel.Location = new System.Drawing.Point(29, 93);
            this.CalculationTableLayoutPanel.Name = "CalculationTableLayoutPanel";
            this.CalculationTableLayoutPanel.RowCount = 6;
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculationTableLayoutPanel.Size = new System.Drawing.Size(311, 329);
            this.CalculationTableLayoutPanel.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateButton.BackColor = System.Drawing.Color.Navy;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(209, 271);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(99, 52);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.BackColor = System.Drawing.Color.Wheat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ResetButton.Location = new System.Drawing.Point(106, 271);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(97, 52);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 269);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(97, 52);
            this.ZeroButton.TabIndex = 15;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(209, 207);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(99, 52);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(106, 207);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(97, 52);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 207);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(97, 52);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(209, 145);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(99, 52);
            this.SixButton.TabIndex = 11;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(106, 145);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(97, 52);
            this.FiveButton.TabIndex = 10;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 145);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(97, 52);
            this.FourButton.TabIndex = 9;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(209, 83);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(99, 52);
            this.NineButton.TabIndex = 8;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(106, 83);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(97, 52);
            this.EightButton.TabIndex = 7;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(209, 0);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(85, 40);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "inches/cm";
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(4, 5);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(95, 29);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height :";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(7, 40);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(88, 40);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight :";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightTextBox.Enabled = false;
            this.HeightTextBox.Location = new System.Drawing.Point(107, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ReadOnly = true;
            this.HeightTextBox.Size = new System.Drawing.Size(95, 35);
            this.HeightTextBox.TabIndex = 2;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightTextBox.Enabled = false;
            this.WeightTextBox.Location = new System.Drawing.Point(106, 43);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.ReadOnly = true;
            this.WeightTextBox.Size = new System.Drawing.Size(97, 35);
            this.WeightTextBox.TabIndex = 3;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(209, 40);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(93, 40);
            this.WeightUnitLabel.TabIndex = 5;
            this.WeightUnitLabel.Text = "pounds/kg";
            this.WeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 83);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(97, 52);
            this.SevenButton.TabIndex = 6;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ResultTableLayoutPanel
            // 
            this.ResultTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultTableLayoutPanel.ColumnCount = 1;
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultTableLayoutPanel.Controls.Add(this.ReferenceLabel, 0, 4);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIResultTextBox, 0, 1);
            this.ResultTableLayoutPanel.Controls.Add(this.RangeLabel, 0, 2);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIlabel, 0, 0);
            this.ResultTableLayoutPanel.Controls.Add(this.textBox1, 0, 3);
            this.ResultTableLayoutPanel.Location = new System.Drawing.Point(362, 47);
            this.ResultTableLayoutPanel.Name = "ResultTableLayoutPanel";
            this.ResultTableLayoutPanel.RowCount = 5;
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultTableLayoutPanel.Size = new System.Drawing.Size(311, 181);
            this.ResultTableLayoutPanel.TabIndex = 3;
            // 
            // ReferenceLabel
            // 
            this.ReferenceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReferenceLabel.AutoSize = true;
            this.ReferenceLabel.Location = new System.Drawing.Point(93, 148);
            this.ReferenceLabel.Name = "ReferenceLabel";
            this.ReferenceLabel.Size = new System.Drawing.Size(125, 29);
            this.ReferenceLabel.TabIndex = 6;
            this.ReferenceLabel.Text = "Reference";
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.Location = new System.Drawing.Point(3, 39);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.ReadOnly = true;
            this.BMIResultTextBox.Size = new System.Drawing.Size(305, 35);
            this.BMIResultTextBox.TabIndex = 0;
            this.BMIResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RangeLabel
            // 
            this.RangeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Location = new System.Drawing.Point(113, 75);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(84, 29);
            this.RangeLabel.TabIndex = 4;
            this.RangeLabel.Text = "Range";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(305, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMIlabel
            // 
            this.BMIlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIlabel.AutoSize = true;
            this.BMIlabel.Location = new System.Drawing.Point(99, 3);
            this.BMIlabel.Name = "BMIlabel";
            this.BMIlabel.Size = new System.Drawing.Size(112, 29);
            this.BMIlabel.TabIndex = 0;
            this.BMIlabel.Text = "Your BMI";
            // 
            // Ref_titleBMI_label
            // 
            this.Ref_titleBMI_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ref_titleBMI_label.AutoSize = true;
            this.Ref_titleBMI_label.BackColor = System.Drawing.Color.Transparent;
            this.Ref_titleBMI_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref_titleBMI_label.Location = new System.Drawing.Point(6, 6);
            this.Ref_titleBMI_label.Name = "Ref_titleBMI_label";
            this.Ref_titleBMI_label.Size = new System.Drawing.Size(111, 25);
            this.Ref_titleBMI_label.TabIndex = 0;
            this.Ref_titleBMI_label.Text = "BMI Scale";
            this.Ref_titleBMI_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ref_titleResultLabel
            // 
            this.Ref_titleResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ref_titleResultLabel.AutoSize = true;
            this.Ref_titleResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.Ref_titleResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref_titleResultLabel.Location = new System.Drawing.Point(180, 6);
            this.Ref_titleResultLabel.Name = "Ref_titleResultLabel";
            this.Ref_titleResultLabel.Size = new System.Drawing.Size(72, 25);
            this.Ref_titleResultLabel.TabIndex = 1;
            this.Ref_titleResultLabel.Text = "Result";
            this.Ref_titleResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.Ref_titleBMI_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ref_titleResultLabel, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(362, 229);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 37);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Ref_UnderweightLabel
            // 
            this.Ref_UnderweightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_UnderweightLabel.AutoSize = true;
            this.Ref_UnderweightLabel.Location = new System.Drawing.Point(4, 1);
            this.Ref_UnderweightLabel.Name = "Ref_UnderweightLabel";
            this.Ref_UnderweightLabel.Size = new System.Drawing.Size(116, 36);
            this.Ref_UnderweightLabel.TabIndex = 0;
            this.Ref_UnderweightLabel.Text = "Underweight";
            // 
            // ReferenceTableLayoutPanel
            // 
            this.ReferenceTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReferenceTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ReferenceTableLayoutPanel.ColumnCount = 2;
            this.ReferenceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ReferenceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_Obese_ResLabel, 1, 3);
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_Over_ResLabel, 1, 2);
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_Normal_ResLabel, 1, 1);
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_NormalLabel, 0, 1);
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_UnderweightLabel, 0, 0);
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_Under_ResLabel, 1, 0);
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_OverweightLabel, 0, 2);
            this.ReferenceTableLayoutPanel.Controls.Add(this.Ref_ObeseLabel, 0, 3);
            this.ReferenceTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceTableLayoutPanel.Location = new System.Drawing.Point(362, 264);
            this.ReferenceTableLayoutPanel.Name = "ReferenceTableLayoutPanel";
            this.ReferenceTableLayoutPanel.RowCount = 4;
            this.ReferenceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ReferenceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ReferenceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ReferenceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ReferenceTableLayoutPanel.Size = new System.Drawing.Size(310, 151);
            this.ReferenceTableLayoutPanel.TabIndex = 4;
            // 
            // Ref_Under_ResLabel
            // 
            this.Ref_Under_ResLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_Under_ResLabel.AutoSize = true;
            this.Ref_Under_ResLabel.Location = new System.Drawing.Point(127, 6);
            this.Ref_Under_ResLabel.Name = "Ref_Under_ResLabel";
            this.Ref_Under_ResLabel.Size = new System.Drawing.Size(140, 25);
            this.Ref_Under_ResLabel.TabIndex = 1;
            this.Ref_Under_ResLabel.Text = "Less than 18.5";
            // 
            // Ref_NormalLabel
            // 
            this.Ref_NormalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_NormalLabel.AutoSize = true;
            this.Ref_NormalLabel.Location = new System.Drawing.Point(4, 43);
            this.Ref_NormalLabel.Name = "Ref_NormalLabel";
            this.Ref_NormalLabel.Size = new System.Drawing.Size(74, 25);
            this.Ref_NormalLabel.TabIndex = 2;
            this.Ref_NormalLabel.Text = "Normal";
            // 
            // Ref_OverweightLabel
            // 
            this.Ref_OverweightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_OverweightLabel.AutoSize = true;
            this.Ref_OverweightLabel.Location = new System.Drawing.Point(4, 80);
            this.Ref_OverweightLabel.Name = "Ref_OverweightLabel";
            this.Ref_OverweightLabel.Size = new System.Drawing.Size(111, 25);
            this.Ref_OverweightLabel.TabIndex = 3;
            this.Ref_OverweightLabel.Text = "Overweight";
            // 
            // Ref_ObeseLabel
            // 
            this.Ref_ObeseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_ObeseLabel.AutoSize = true;
            this.Ref_ObeseLabel.Location = new System.Drawing.Point(4, 118);
            this.Ref_ObeseLabel.Name = "Ref_ObeseLabel";
            this.Ref_ObeseLabel.Size = new System.Drawing.Size(71, 25);
            this.Ref_ObeseLabel.TabIndex = 4;
            this.Ref_ObeseLabel.Text = "Obese";
            // 
            // Ref_Normal_ResLabel
            // 
            this.Ref_Normal_ResLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_Normal_ResLabel.AutoSize = true;
            this.Ref_Normal_ResLabel.Location = new System.Drawing.Point(127, 38);
            this.Ref_Normal_ResLabel.Name = "Ref_Normal_ResLabel";
            this.Ref_Normal_ResLabel.Size = new System.Drawing.Size(172, 36);
            this.Ref_Normal_ResLabel.TabIndex = 5;
            this.Ref_Normal_ResLabel.Text = "between 18.5 and 24.9";
            // 
            // Ref_Over_ResLabel
            // 
            this.Ref_Over_ResLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_Over_ResLabel.AutoSize = true;
            this.Ref_Over_ResLabel.Location = new System.Drawing.Point(127, 75);
            this.Ref_Over_ResLabel.Name = "Ref_Over_ResLabel";
            this.Ref_Over_ResLabel.Size = new System.Drawing.Size(156, 36);
            this.Ref_Over_ResLabel.TabIndex = 6;
            this.Ref_Over_ResLabel.Text = "between 25 and 29.9";
            // 
            // Ref_Obese_ResLabel
            // 
            this.Ref_Obese_ResLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ref_Obese_ResLabel.AutoSize = true;
            this.Ref_Obese_ResLabel.Location = new System.Drawing.Point(127, 118);
            this.Ref_Obese_ResLabel.Name = "Ref_Obese_ResLabel";
            this.Ref_Obese_ResLabel.Size = new System.Drawing.Size(122, 25);
            this.Ref_Obese_ResLabel.TabIndex = 7;
            this.Ref_Obese_ResLabel.Text = "30 or greater";
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(710, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ReferenceTableLayoutPanel);
            this.Controls.Add(this.ResultTableLayoutPanel);
            this.Controls.Add(this.CalculationTableLayoutPanel);
            this.Controls.Add(this.StandardMetricTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICaculator_Load);
            this.StandardMetricTableLayoutPanel.ResumeLayout(false);
            this.StandardMetricTableLayoutPanel.PerformLayout();
            this.CalculationTableLayoutPanel.ResumeLayout(false);
            this.CalculationTableLayoutPanel.PerformLayout();
            this.ResultTableLayoutPanel.ResumeLayout(false);
            this.ResultTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ReferenceTableLayoutPanel.ResumeLayout(false);
            this.ReferenceTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel StandardMetricTableLayoutPanel;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TableLayoutPanel CalculationTableLayoutPanel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.TableLayoutPanel ResultTableLayoutPanel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label BMIlabel;
        private System.Windows.Forms.Label Ref_titleBMI_label;
        private System.Windows.Forms.Label ReferenceLabel;
        private System.Windows.Forms.Label Ref_titleResultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Ref_UnderweightLabel;
        private System.Windows.Forms.TableLayoutPanel ReferenceTableLayoutPanel;
        private System.Windows.Forms.Label Ref_Obese_ResLabel;
        private System.Windows.Forms.Label Ref_Over_ResLabel;
        private System.Windows.Forms.Label Ref_Normal_ResLabel;
        private System.Windows.Forms.Label Ref_NormalLabel;
        private System.Windows.Forms.Label Ref_Under_ResLabel;
        private System.Windows.Forms.Label Ref_OverweightLabel;
        private System.Windows.Forms.Label Ref_ObeseLabel;
    }
}

