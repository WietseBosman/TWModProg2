using System.Drawing;

namespace Mandelbrot
{
    partial class MainForm
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
            this.textBoxMidX = new System.Windows.Forms.TextBox();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.textBoxMidY = new System.Windows.Forms.TextBox();
            this.listBoxPalettes = new System.Windows.Forms.ListBox();
            this.buttonResetZoom = new System.Windows.Forms.Button();
            this.pictureBoxMandelbrot = new System.Windows.Forms.PictureBox();
            this.checkBoxDisableMaxIterations = new System.Windows.Forms.CheckBox();
            this.listBoxPresets = new System.Windows.Forms.ListBox();
            this.labelMidx = new System.Windows.Forms.Label();
            this.labelMidy = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.labelIterations = new System.Windows.Forms.Label();
            this.labelPresets = new System.Windows.Forms.Label();
            this.labelPalettes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMandelbrot)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMidX
            // 
            this.textBoxMidX.Location = new System.Drawing.Point(50, 50);
            this.textBoxMidX.Name = "textBoxMidX";
            this.textBoxMidX.Size = new System.Drawing.Size(200, 22);
            this.textBoxMidX.TabIndex = 0;
            this.textBoxMidX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(300, 50);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(200, 22);
            this.textBoxScale.TabIndex = 1;
            this.textBoxScale.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(300, 100);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(200, 22);
            this.textBoxIterations.TabIndex = 2;
            this.textBoxIterations.TextChanged += new System.EventHandler(this.textBoxIterations_TextChanged);
            // 
            // textBoxMidY
            // 
            this.textBoxMidY.Location = new System.Drawing.Point(50, 100);
            this.textBoxMidY.Name = "textBoxMidY";
            this.textBoxMidY.Size = new System.Drawing.Size(200, 22);
            this.textBoxMidY.TabIndex = 3;
            this.textBoxMidY.TextChanged += new System.EventHandler(this.textBoxMidY_TextChanged);
            // 
            // listBoxPalettes
            // 
            this.listBoxPalettes.FormattingEnabled = true;
            this.listBoxPalettes.ItemHeight = 16;
            this.listBoxPalettes.Items.AddRange(new object[] {
            "Black and white",
            "Waves",
            "Lightning",
            "Colourful"});
            this.listBoxPalettes.Location = new System.Drawing.Point(600, 150);
            this.listBoxPalettes.Name = "listBoxPalettes";
            this.listBoxPalettes.Size = new System.Drawing.Size(120, 68);
            this.listBoxPalettes.TabIndex = 4;
            this.listBoxPalettes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonResetZoom
            // 
            this.buttonResetZoom.Location = new System.Drawing.Point(550, 50);
            this.buttonResetZoom.Name = "buttonResetZoom";
            this.buttonResetZoom.Size = new System.Drawing.Size(125, 23);
            this.buttonResetZoom.TabIndex = 5;
            this.buttonResetZoom.Text = "Reset zoom";
            this.buttonResetZoom.UseVisualStyleBackColor = true;
            this.buttonResetZoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxMandelbrot
            // 
            this.pictureBoxMandelbrot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxMandelbrot.Location = new System.Drawing.Point(50, 150);
            this.pictureBoxMandelbrot.Name = "pictureBoxMandelbrot";
            this.pictureBoxMandelbrot.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxMandelbrot.TabIndex = 6;
            this.pictureBoxMandelbrot.TabStop = false;
            this.pictureBoxMandelbrot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // checkBoxDisableMaxIterations
            // 
            this.checkBoxDisableMaxIterations.AutoSize = true;
            this.checkBoxDisableMaxIterations.Location = new System.Drawing.Point(550, 100);
            this.checkBoxDisableMaxIterations.Name = "checkBoxDisableMaxIterations";
            this.checkBoxDisableMaxIterations.Size = new System.Drawing.Size(213, 21);
            this.checkBoxDisableMaxIterations.TabIndex = 7;
            this.checkBoxDisableMaxIterations.Text = "Disable iterations limit (2000)";
            this.checkBoxDisableMaxIterations.UseVisualStyleBackColor = true;
            // 
            // listBoxPresets
            // 
            this.listBoxPresets.FormattingEnabled = true;
            this.listBoxPresets.ItemHeight = 16;
            this.listBoxPresets.Items.AddRange(new object[] {
            "Magic",
            "Spiral",
            "Icy",
            "Disco"});
            this.listBoxPresets.Location = new System.Drawing.Point(600, 250);
            this.listBoxPresets.Name = "listBoxPresets";
            this.listBoxPresets.Size = new System.Drawing.Size(120, 68);
            this.listBoxPresets.TabIndex = 8;
            this.listBoxPresets.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // labelMidx
            // 
            this.labelMidx.AutoSize = true;
            this.labelMidx.Location = new System.Drawing.Point(50, 30);
            this.labelMidx.Name = "labelMidx";
            this.labelMidx.Size = new System.Drawing.Size(40, 17);
            this.labelMidx.TabIndex = 9;
            this.labelMidx.Text = "Mid x";
            // 
            // labelMidy
            // 
            this.labelMidy.AutoSize = true;
            this.labelMidy.Location = new System.Drawing.Point(50, 80);
            this.labelMidy.Name = "labelMidy";
            this.labelMidy.Size = new System.Drawing.Size(41, 17);
            this.labelMidy.TabIndex = 10;
            this.labelMidy.Text = "Mid y";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(300, 30);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(43, 17);
            this.labelScale.TabIndex = 11;
            this.labelScale.Text = "Scale";
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(300, 80);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(95, 17);
            this.labelIterations.TabIndex = 12;
            this.labelIterations.Text = "Max iterations";
            // 
            // labelPresets
            // 
            this.labelPresets.AutoSize = true;
            this.labelPresets.Location = new System.Drawing.Point(600, 230);
            this.labelPresets.Name = "labelPresets";
            this.labelPresets.Size = new System.Drawing.Size(56, 17);
            this.labelPresets.TabIndex = 13;
            this.labelPresets.Text = "Presets";
            // 
            // labelPalettes
            // 
            this.labelPalettes.AutoSize = true;
            this.labelPalettes.Location = new System.Drawing.Point(600, 130);
            this.labelPalettes.Name = "labelPalettes";
            this.labelPalettes.Size = new System.Drawing.Size(59, 17);
            this.labelPalettes.TabIndex = 14;
            this.labelPalettes.Text = "Palettes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(832, 703);
            this.Controls.Add(this.labelPalettes);
            this.Controls.Add(this.labelPresets);
            this.Controls.Add(this.labelIterations);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.labelMidy);
            this.Controls.Add(this.labelMidx);
            this.Controls.Add(this.listBoxPresets);
            this.Controls.Add(this.checkBoxDisableMaxIterations);
            this.Controls.Add(this.pictureBoxMandelbrot);
            this.Controls.Add(this.buttonResetZoom);
            this.Controls.Add(this.listBoxPalettes);
            this.Controls.Add(this.textBoxMidY);
            this.Controls.Add(this.textBoxIterations);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.textBoxMidX);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMandelbrot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMidX;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.TextBox textBoxMidY;
        private System.Windows.Forms.ListBox listBoxPalettes;
        private System.Windows.Forms.Button buttonResetZoom;
        private System.Windows.Forms.PictureBox pictureBoxMandelbrot;
        private System.Windows.Forms.CheckBox checkBoxDisableMaxIterations;
        private System.Windows.Forms.ListBox listBoxPresets;
        private System.Windows.Forms.Label labelMidx;
        private System.Windows.Forms.Label labelMidy;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Label labelPresets;
        private System.Windows.Forms.Label labelPalettes;
    }
}

