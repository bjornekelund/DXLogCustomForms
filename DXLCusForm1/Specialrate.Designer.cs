﻿namespace DXLog.net
{
    partial class SpecialRate
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Andale Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInfo.Location = new System.Drawing.Point(0, -1);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(266, 101);
            this.lbInfo.TabIndex = 1;
            // 
            // SpecialRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(266, 100);
            this.Controls.Add(this.lbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.FormID = 1001;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpecialRate";
            this.Text = "Special rate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
    }
}