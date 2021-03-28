
namespace Hyperboloid
{
    partial class BodyInertiaMomentsCalculationForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IxyValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IxzValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IyzValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IxValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IyValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IzValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CalculateButton.Location = new System.Drawing.Point(17, 526);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(367, 46);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // HValue
            // 
            this.HValue.DecimalPlaces = 2;
            this.HValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HValue.Location = new System.Drawing.Point(67, 101);
            this.HValue.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.HValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.HValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HValue.Name = "HValue";
            this.HValue.Size = new System.Drawing.Size(107, 30);
            this.HValue.TabIndex = 5;
            this.HValue.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "h =";
            // 
            // CValue
            // 
            this.CValue.DecimalPlaces = 2;
            this.CValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CValue.Location = new System.Drawing.Point(67, 65);
            this.CValue.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.CValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CValue.Name = "CValue";
            this.CValue.Size = new System.Drawing.Size(107, 30);
            this.CValue.TabIndex = 3;
            this.CValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "c =";
            // 
            // AValue
            // 
            this.AValue.DecimalPlaces = 2;
            this.AValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AValue.Location = new System.Drawing.Point(67, 29);
            this.AValue.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.AValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.AValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.AValue.Name = "AValue";
            this.AValue.Size = new System.Drawing.Size(107, 30);
            this.AValue.TabIndex = 1;
            this.AValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=b=";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Hyperboloid.Properties.Resources.оси;
            this.pictureBox3.Location = new System.Drawing.Point(208, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Hyperboloid.Properties.Resources.example1;
            this.pictureBox2.Location = new System.Drawing.Point(272, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Hyperboloid.Properties.Resources.плоскости;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // IxyValue
            // 
            this.IxyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IxyValue.Location = new System.Drawing.Point(72, 310);
            this.IxyValue.Name = "IxyValue";
            this.IxyValue.ReadOnly = true;
            this.IxyValue.Size = new System.Drawing.Size(312, 30);
            this.IxyValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ixy =";
            // 
            // IxzValue
            // 
            this.IxzValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IxzValue.Location = new System.Drawing.Point(72, 346);
            this.IxzValue.Name = "IxzValue";
            this.IxzValue.ReadOnly = true;
            this.IxzValue.Size = new System.Drawing.Size(312, 30);
            this.IxzValue.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ixz =";
            // 
            // IyzValue
            // 
            this.IyzValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IyzValue.Location = new System.Drawing.Point(72, 382);
            this.IyzValue.Name = "IyzValue";
            this.IyzValue.ReadOnly = true;
            this.IyzValue.Size = new System.Drawing.Size(312, 30);
            this.IyzValue.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Iyz =";
            // 
            // IxValue
            // 
            this.IxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IxValue.Location = new System.Drawing.Point(72, 418);
            this.IxValue.Name = "IxValue";
            this.IxValue.ReadOnly = true;
            this.IxValue.Size = new System.Drawing.Size(312, 30);
            this.IxValue.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ix =";
            // 
            // IyValue
            // 
            this.IyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IyValue.Location = new System.Drawing.Point(72, 454);
            this.IyValue.Name = "IyValue";
            this.IyValue.ReadOnly = true;
            this.IyValue.Size = new System.Drawing.Size(312, 30);
            this.IyValue.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Iy =";
            // 
            // IzValue
            // 
            this.IzValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IzValue.Location = new System.Drawing.Point(72, 490);
            this.IzValue.Name = "IzValue";
            this.IzValue.ReadOnly = true;
            this.IzValue.Size = new System.Drawing.Size(312, 30);
            this.IzValue.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Iz =";
            // 
            // BodyInertiaMomentsCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 584);
            this.Controls.Add(this.IzValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IyValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IxValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IyzValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IxzValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IxyValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BodyInertiaMomentsCalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчёты моментов инерции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown HValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox IxyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IxzValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IyzValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IxValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IyValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IzValue;
        private System.Windows.Forms.Label label9;
    }
}