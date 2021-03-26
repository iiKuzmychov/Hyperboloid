
namespace Hyperboloid
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GraphicsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.StepBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetStepButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResetScaleFactorButton = new System.Windows.Forms.Button();
            this.ScaleFactorBar = new System.Windows.Forms.TrackBar();
            this.AutoUpdateBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZRotationBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.YRotationBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.XRotationBar = new System.Windows.Forms.TrackBar();
            this.FormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.рассчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSurfaceVolumeCalculationgForm = new System.Windows.Forms.ToolStripMenuItem();
            this.SmoothBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFactorBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZRotationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YRotationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRotationBar)).BeginInit();
            this.FormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphicsPanel
            // 
            this.GraphicsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphicsPanel.Location = new System.Drawing.Point(12, 31);
            this.GraphicsPanel.Name = "GraphicsPanel";
            this.GraphicsPanel.Size = new System.Drawing.Size(612, 660);
            this.GraphicsPanel.TabIndex = 0;
            this.GraphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicsPanel_Paint);
            this.GraphicsPanel.Resize += new System.EventHandler(this.GraphicsPanel_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.HValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(630, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 140);
            this.groupBox1.TabIndex = 2;
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
            this.HValue.ValueChanged += new System.EventHandler(this.HValue_ValueChanged);
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
            this.CValue.ValueChanged += new System.EventHandler(this.CValue_ValueChanged);
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
            this.AValue.ValueChanged += new System.EventHandler(this.AValue_ValueChanged);
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
            // DrawButton
            // 
            this.DrawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DrawButton.Location = new System.Drawing.Point(630, 645);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(190, 46);
            this.DrawButton.TabIndex = 3;
            this.DrawButton.Text = "Нарисовать";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // StepBar
            // 
            this.StepBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepBar.AutoSize = false;
            this.StepBar.Location = new System.Drawing.Point(6, 29);
            this.StepBar.Maximum = 30;
            this.StepBar.Minimum = 1;
            this.StepBar.Name = "StepBar";
            this.StepBar.Size = new System.Drawing.Size(126, 40);
            this.StepBar.TabIndex = 4;
            this.StepBar.TickFrequency = 5;
            this.StepBar.Value = 10;
            this.StepBar.ValueChanged += new System.EventHandler(this.StepBar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ResetStepButton);
            this.groupBox2.Controls.Add(this.StepBar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(630, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шаг";
            // 
            // ResetStepButton
            // 
            this.ResetStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetStepButton.BackgroundImage = global::Hyperboloid.Properties.Resources.refresh_reload_recycle_synchronize_retry_30557;
            this.ResetStepButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetStepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResetStepButton.Location = new System.Drawing.Point(138, 23);
            this.ResetStepButton.Name = "ResetStepButton";
            this.ResetStepButton.Size = new System.Drawing.Size(46, 46);
            this.ResetStepButton.TabIndex = 9;
            this.ResetStepButton.UseVisualStyleBackColor = true;
            this.ResetStepButton.Click += new System.EventHandler(this.ResetStepButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ResetScaleFactorButton);
            this.groupBox3.Controls.Add(this.ScaleFactorBar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(630, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштаб";
            // 
            // ResetScaleFactorButton
            // 
            this.ResetScaleFactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetScaleFactorButton.BackgroundImage = global::Hyperboloid.Properties.Resources.refresh_reload_recycle_synchronize_retry_30557;
            this.ResetScaleFactorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetScaleFactorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResetScaleFactorButton.Location = new System.Drawing.Point(138, 23);
            this.ResetScaleFactorButton.Name = "ResetScaleFactorButton";
            this.ResetScaleFactorButton.Size = new System.Drawing.Size(46, 46);
            this.ResetScaleFactorButton.TabIndex = 8;
            this.ResetScaleFactorButton.UseVisualStyleBackColor = true;
            this.ResetScaleFactorButton.Click += new System.EventHandler(this.ResetScaleFactorButton_Click);
            // 
            // ScaleFactorBar
            // 
            this.ScaleFactorBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleFactorBar.AutoSize = false;
            this.ScaleFactorBar.Location = new System.Drawing.Point(6, 29);
            this.ScaleFactorBar.Maximum = 100;
            this.ScaleFactorBar.Minimum = 1;
            this.ScaleFactorBar.Name = "ScaleFactorBar";
            this.ScaleFactorBar.Size = new System.Drawing.Size(126, 40);
            this.ScaleFactorBar.TabIndex = 4;
            this.ScaleFactorBar.TickFrequency = 10;
            this.ScaleFactorBar.Value = 10;
            this.ScaleFactorBar.ValueChanged += new System.EventHandler(this.ScaleFactorBar_ValueChanged);
            // 
            // AutoUpdateBox
            // 
            this.AutoUpdateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoUpdateBox.AutoSize = true;
            this.AutoUpdateBox.Checked = true;
            this.AutoUpdateBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AutoUpdateBox.Location = new System.Drawing.Point(630, 608);
            this.AutoUpdateBox.Name = "AutoUpdateBox";
            this.AutoUpdateBox.Size = new System.Drawing.Size(190, 29);
            this.AutoUpdateBox.TabIndex = 7;
            this.AutoUpdateBox.Text = "Автообновление";
            this.AutoUpdateBox.UseVisualStyleBackColor = true;
            this.AutoUpdateBox.CheckedChanged += new System.EventHandler(this.AutoUpdateBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Hyperboloid.Properties.Resources._826e99846928fc5a08bd99a1a320bb971;
            this.pictureBox1.Location = new System.Drawing.Point(630, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.ZRotationBar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.YRotationBar);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.XRotationBar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(630, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 155);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вращение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Z";
            // 
            // ZRotationBar
            // 
            this.ZRotationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZRotationBar.AutoSize = false;
            this.ZRotationBar.Location = new System.Drawing.Point(34, 113);
            this.ZRotationBar.Maximum = 360;
            this.ZRotationBar.Name = "ZRotationBar";
            this.ZRotationBar.Size = new System.Drawing.Size(150, 35);
            this.ZRotationBar.TabIndex = 8;
            this.ZRotationBar.TickFrequency = 60;
            this.ZRotationBar.Scroll += new System.EventHandler(this.ZRotationBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // YRotationBar
            // 
            this.YRotationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YRotationBar.AutoSize = false;
            this.YRotationBar.Location = new System.Drawing.Point(34, 71);
            this.YRotationBar.Maximum = 360;
            this.YRotationBar.Name = "YRotationBar";
            this.YRotationBar.Size = new System.Drawing.Size(150, 35);
            this.YRotationBar.TabIndex = 6;
            this.YRotationBar.TickFrequency = 60;
            this.YRotationBar.Scroll += new System.EventHandler(this.YRotationBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // XRotationBar
            // 
            this.XRotationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XRotationBar.AutoSize = false;
            this.XRotationBar.Location = new System.Drawing.Point(34, 29);
            this.XRotationBar.Maximum = 360;
            this.XRotationBar.Name = "XRotationBar";
            this.XRotationBar.Size = new System.Drawing.Size(150, 35);
            this.XRotationBar.TabIndex = 4;
            this.XRotationBar.TickFrequency = 60;
            this.XRotationBar.Value = 90;
            this.XRotationBar.Scroll += new System.EventHandler(this.XRotationBar_Scroll);
            // 
            // FormMenuStrip
            // 
            this.FormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчётыToolStripMenuItem});
            this.FormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FormMenuStrip.Name = "FormMenuStrip";
            this.FormMenuStrip.Size = new System.Drawing.Size(832, 28);
            this.FormMenuStrip.TabIndex = 10;
            this.FormMenuStrip.Text = "FormMenuStrip";
            // 
            // рассчётыToolStripMenuItem
            // 
            this.рассчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSurfaceVolumeCalculationgForm});
            this.рассчётыToolStripMenuItem.Name = "рассчётыToolStripMenuItem";
            this.рассчётыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.рассчётыToolStripMenuItem.Text = "Рассчёты";
            // 
            // OpenSurfaceVolumeCalculationgForm
            // 
            this.OpenSurfaceVolumeCalculationgForm.Name = "OpenSurfaceVolumeCalculationgForm";
            this.OpenSurfaceVolumeCalculationgForm.Size = new System.Drawing.Size(234, 26);
            this.OpenSurfaceVolumeCalculationgForm.Text = "Объём поверхности";
            this.OpenSurfaceVolumeCalculationgForm.Click += new System.EventHandler(this.OpenSurfaceVolumeCalculationgForm_Click);
            // 
            // SmoothBox
            // 
            this.SmoothBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmoothBox.AutoSize = true;
            this.SmoothBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SmoothBox.Location = new System.Drawing.Point(630, 573);
            this.SmoothBox.Name = "SmoothBox";
            this.SmoothBox.Size = new System.Drawing.Size(158, 29);
            this.SmoothBox.TabIndex = 11;
            this.SmoothBox.Text = "Сглаживание";
            this.SmoothBox.UseVisualStyleBackColor = true;
            this.SmoothBox.CheckedChanged += new System.EventHandler(this.SmoothBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 703);
            this.Controls.Add(this.SmoothBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AutoUpdateBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GraphicsPanel);
            this.Controls.Add(this.FormMenuStrip);
            this.MinimumSize = new System.Drawing.Size(850, 750);
            this.Name = "MainForm";
            this.Text = "Однополостная гиперболоида";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFactorBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZRotationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YRotationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRotationBar)).EndInit();
            this.FormMenuStrip.ResumeLayout(false);
            this.FormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GraphicsPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown CValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.TrackBar StepBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar ScaleFactorBar;
        private System.Windows.Forms.Button ResetScaleFactorButton;
        private System.Windows.Forms.CheckBox AutoUpdateBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar ZRotationBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar YRotationBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar XRotationBar;
        private System.Windows.Forms.NumericUpDown HValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip FormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem рассчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSurfaceVolumeCalculationgForm;
        private System.Windows.Forms.Button ResetStepButton;
        private System.Windows.Forms.CheckBox SmoothBox;
    }
}

