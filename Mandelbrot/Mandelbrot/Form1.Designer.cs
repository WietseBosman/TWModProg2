﻿using System.Drawing;

namespace Mandelbrot
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMidX
            // 
            this.textBoxMidX.Location = new System.Drawing.Point(39, 23);
            this.textBoxMidX.Name = "textBoxMidX";
            this.textBoxMidX.Size = new System.Drawing.Size(100, 22);
            this.textBoxMidX.TabIndex = 0;
            this.textBoxMidX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(185, 23);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(100, 22);
            this.textBoxScale.TabIndex = 1;
            this.textBoxScale.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(185, 67);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(100, 22);
            this.textBoxIterations.TabIndex = 2;
            this.textBoxIterations.TextChanged += new System.EventHandler(this.textBoxIterations_TextChanged);
            // 
            // textBoxMidY
            // 
            this.textBoxMidY.Location = new System.Drawing.Point(39, 67);
            this.textBoxMidY.Name = "textBoxMidY";
            this.textBoxMidY.Size = new System.Drawing.Size(100, 22);
            this.textBoxMidY.TabIndex = 3;
            this.textBoxMidY.TextChanged += new System.EventHandler(this.textBoxMidY_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(637, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(149, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 173);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxMidY);
            this.Controls.Add(this.textBoxIterations);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.textBoxMidX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMidX;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.TextBox textBoxMidY;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

