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
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StandardMetricTableLayoutPanel.SuspendLayout();
            this.CalculationTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandardMetricTableLayoutPanel
            // 
            this.StandardMetricTableLayoutPanel.ColumnCount = 2;
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.Controls.Add(this.StandardRadioButton, 0, 0);
            this.StandardMetricTableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 0);
            this.StandardMetricTableLayoutPanel.Location = new System.Drawing.Point(0, 74);
            this.StandardMetricTableLayoutPanel.Name = "StandardMetricTableLayoutPanel";
            this.StandardMetricTableLayoutPanel.RowCount = 1;
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StandardMetricTableLayoutPanel.Size = new System.Drawing.Size(311, 44);
            this.StandardMetricTableLayoutPanel.TabIndex = 0;
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardRadioButton.Location = new System.Drawing.Point(3, 3);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(117, 29);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(158, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(90, 29);
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
            this.CalculationTableLayoutPanel.Location = new System.Drawing.Point(0, 120);
            this.CalculationTableLayoutPanel.Name = "CalculationTableLayoutPanel";
            this.CalculationTableLayoutPanel.RowCount = 6;
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculationTableLayoutPanel.Size = new System.Drawing.Size(311, 312);
            this.CalculationTableLayoutPanel.TabIndex = 1;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(209, 9);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(90, 22);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "inches/cm";
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 7);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(79, 25);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height :";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 47);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(85, 25);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight :";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(106, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(97, 35);
            this.HeightTextBox.TabIndex = 2;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(106, 43);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(97, 35);
            this.WeightTextBox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(209, 49);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(93, 22);
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
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 141);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(97, 52);
            this.FourButton.TabIndex = 9;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(106, 141);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(97, 52);
            this.FiveButton.TabIndex = 10;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(209, 141);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(99, 52);
            this.SixButton.TabIndex = 11;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 199);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(97, 52);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(106, 199);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(97, 52);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(209, 199);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(99, 52);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 257);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(97, 52);
            this.ZeroButton.TabIndex = 15;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(106, 257);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(97, 52);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(209, 257);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(99, 52);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(710, 533);
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
    }
}

