﻿namespace GameStructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._openGLControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // _openGLControl
            // 
            this._openGLControl.AccumBits = ((byte)(0));
            this._openGLControl.AutoCheckErrors = false;
            this._openGLControl.AutoFinish = false;
            this._openGLControl.AutoMakeCurrent = true;
            this._openGLControl.AutoSwapBuffers = true;
            this._openGLControl.BackColor = System.Drawing.Color.Black;
            this._openGLControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_openGLControl.BackgroundImage")));
            this._openGLControl.ColorBits = ((byte)(32));
            this._openGLControl.DepthBits = ((byte)(16));
            this._openGLControl.Location = new System.Drawing.Point(34, 21);
            this._openGLControl.Name = "_openGLControl";
            this._openGLControl.Size = new System.Drawing.Size(838, 370);
            this._openGLControl.StencilBits = ((byte)(0));
            this._openGLControl.TabIndex = 0;
            this._openGLControl.VSync = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 416);
            this.Controls.Add(this._openGLControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl _openGLControl;
    }
}

