namespace TempadColorPicker
{
    partial class TempadColorPicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblInt = new Label();
            lblHex = new Label();
            lblRGB = new Label();
            IntValuText = new TextBox();
            ColorPrev = new Label();
            ColPrevLabelText = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.InactiveCaptionText;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(197, 119);
            button1.TabIndex = 0;
            button1.Text = "Pick Color (Click here)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblInt
            // 
            lblInt.BackColor = SystemColors.InactiveCaption;
            lblInt.Location = new Point(215, 81);
            lblInt.Name = "lblInt";
            lblInt.Size = new Size(178, 24);
            lblInt.TabIndex = 3;
            lblInt.Text = "IntegerValue";
            // 
            // lblHex
            // 
            lblHex.BackColor = SystemColors.InactiveCaption;
            lblHex.Location = new Point(215, 12);
            lblHex.Name = "lblHex";
            lblHex.Size = new Size(178, 24);
            lblHex.TabIndex = 4;
            lblHex.Text = "HexValue";
            // 
            // lblRGB
            // 
            lblRGB.BackColor = SystemColors.InactiveCaption;
            lblRGB.Location = new Point(215, 47);
            lblRGB.Name = "lblRGB";
            lblRGB.Size = new Size(178, 24);
            lblRGB.TabIndex = 5;
            lblRGB.Text = "RGBValues";
            // 
            // IntValuText
            // 
            IntValuText.Location = new Point(215, 108);
            IntValuText.Name = "IntValuText";
            IntValuText.Size = new Size(178, 23);
            IntValuText.TabIndex = 6;
            // 
            // ColorPrev
            // 
            ColorPrev.Location = new Point(399, 34);
            ColorPrev.Name = "ColorPrev";
            ColorPrev.Size = new Size(120, 97);
            ColorPrev.TabIndex = 7;
            // 
            // ColPrevLabelText
            // 
            ColPrevLabelText.ForeColor = SystemColors.Highlight;
            ColPrevLabelText.Location = new Point(399, 11);
            ColPrevLabelText.Name = "ColPrevLabelText";
            ColPrevLabelText.Size = new Size(120, 23);
            ColPrevLabelText.TabIndex = 8;
            ColPrevLabelText.Text = "Color Preview Below";
            // 
            // TempadColorPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ColPrevLabelText);
            Controls.Add(ColorPrev);
            Controls.Add(IntValuText);
            Controls.Add(lblRGB);
            Controls.Add(lblHex);
            Controls.Add(lblInt);
            Controls.Add(button1);
            Name = "TempadColorPicker";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblInt;
        private Label lblHex;
        private Label lblRGB;
        private TextBox IntValuText;
        private Label ColorPrev;
        private Label ColPrevLabelText;
    }
}
