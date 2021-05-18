﻿namespace UniversalDreamcastPatcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonApplyPatch = new System.Windows.Forms.Button();
            this.buttonSelectGDI = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.patchingProgressBar = new System.Windows.Forms.ProgressBar();
            this.patchingProgressDetails = new System.Windows.Forms.Label();
            this.buttonSelectPatch = new System.Windows.Forms.Button();
            this.patchingProgressPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApplyPatch
            // 
            this.buttonApplyPatch.Enabled = false;
            this.buttonApplyPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyPatch.Location = new System.Drawing.Point(8, 208);
            this.buttonApplyPatch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApplyPatch.Name = "buttonApplyPatch";
            this.buttonApplyPatch.Size = new System.Drawing.Size(424, 40);
            this.buttonApplyPatch.TabIndex = 2;
            this.buttonApplyPatch.Text = "Apply Patch";
            this.buttonApplyPatch.UseVisualStyleBackColor = true;
            this.buttonApplyPatch.Visible = false;
            this.buttonApplyPatch.Click += new System.EventHandler(this.ButtonApplyPatch_Click);
            // 
            // buttonSelectGDI
            // 
            this.buttonSelectGDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectGDI.Location = new System.Drawing.Point(8, 160);
            this.buttonSelectGDI.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectGDI.Name = "buttonSelectGDI";
            this.buttonSelectGDI.Size = new System.Drawing.Size(424, 40);
            this.buttonSelectGDI.TabIndex = 3;
            this.buttonSelectGDI.Text = "Select GDI or CUE";
            this.buttonSelectGDI.UseVisualStyleBackColor = true;
            this.buttonSelectGDI.Click += new System.EventHandler(this.ButtonSelectGDI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "v0.3 - Derek Pascarella (ateam)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(8, 256);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(424, 40);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // patchingProgressBar
            // 
            this.patchingProgressBar.Location = new System.Drawing.Point(8, 232);
            this.patchingProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.patchingProgressBar.MarqueeAnimationSpeed = 0;
            this.patchingProgressBar.Name = "patchingProgressBar";
            this.patchingProgressBar.Size = new System.Drawing.Size(424, 64);
            this.patchingProgressBar.TabIndex = 7;
            this.patchingProgressBar.UseWaitCursor = true;
            this.patchingProgressBar.Visible = false;
            // 
            // patchingProgressDetails
            // 
            this.patchingProgressDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchingProgressDetails.Location = new System.Drawing.Point(8, 168);
            this.patchingProgressDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patchingProgressDetails.Name = "patchingProgressDetails";
            this.patchingProgressDetails.Size = new System.Drawing.Size(424, 24);
            this.patchingProgressDetails.TabIndex = 8;
            this.patchingProgressDetails.Text = "Starting patching process...";
            this.patchingProgressDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.patchingProgressDetails.Visible = false;
            this.patchingProgressDetails.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // buttonSelectPatch
            // 
            this.buttonSelectPatch.Enabled = false;
            this.buttonSelectPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectPatch.Location = new System.Drawing.Point(8, 208);
            this.buttonSelectPatch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectPatch.Name = "buttonSelectPatch";
            this.buttonSelectPatch.Size = new System.Drawing.Size(424, 40);
            this.buttonSelectPatch.TabIndex = 9;
            this.buttonSelectPatch.Text = "Select Patch";
            this.buttonSelectPatch.UseVisualStyleBackColor = true;
            this.buttonSelectPatch.Click += new System.EventHandler(this.ButtonSelectPatch_Click);
            // 
            // patchingProgressPercentage
            // 
            this.patchingProgressPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchingProgressPercentage.Location = new System.Drawing.Point(8, 200);
            this.patchingProgressPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patchingProgressPercentage.Name = "patchingProgressPercentage";
            this.patchingProgressPercentage.Size = new System.Drawing.Size(424, 24);
            this.patchingProgressPercentage.TabIndex = 10;
            this.patchingProgressPercentage.Text = "0%";
            this.patchingProgressPercentage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.patchingProgressPercentage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(441, 343);
            this.Controls.Add(this.buttonSelectPatch);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSelectGDI);
            this.Controls.Add(this.buttonApplyPatch);
            this.Controls.Add(this.patchingProgressDetails);
            this.Controls.Add(this.patchingProgressPercentage);
            this.Controls.Add(this.patchingProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Universal Dreamcast Patcher (v0.3)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonApplyPatch;
        private System.Windows.Forms.Button buttonSelectGDI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.ProgressBar patchingProgressBar;
        private System.Windows.Forms.Label patchingProgressDetails;
        private System.Windows.Forms.Button buttonSelectPatch;
        private System.Windows.Forms.Label patchingProgressPercentage;
    }
}

