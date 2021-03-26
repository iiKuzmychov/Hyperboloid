
namespace Hyperboloid
{
    partial class HyperboloidSurfaceVolumeCalculatingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SurfaceVolumeValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 140);
            this.groupBox1.TabIndex = 3;
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
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CalculateButton.Location = new System.Drawing.Point(12, 264);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(298, 46);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Hyperboloid.Properties.Resources._8e0d3b9522bc09eed00e847e45aba3d4;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Hyperboloid.Properties.Resources.example1;
            this.pictureBox2.Location = new System.Drawing.Point(208, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "V =";
            // 
            // SurfaceVolumeValue
            // 
            this.SurfaceVolumeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SurfaceVolumeValue.Location = new System.Drawing.Point(61, 228);
            this.SurfaceVolumeValue.Name = "SurfaceVolumeValue";
            this.SurfaceVolumeValue.ReadOnly = true;
            this.SurfaceVolumeValue.Size = new System.Drawing.Size(249, 30);
            this.SurfaceVolumeValue.TabIndex = 7;
            // 
            // HyperboloidSurfaceVolumeCalculatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 322);
            this.Controls.Add(this.SurfaceVolumeValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HyperboloidSurfaceVolumeCalculatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Объём поверхности";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown HValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurfaceVolumeValue;
    }
}