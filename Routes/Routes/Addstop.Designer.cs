﻿namespace Routes
{
    partial class Addstop
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdAddStop = new System.Windows.Forms.Button();
            this.txtStopName = new System.Windows.Forms.TextBox();
            this.lblStopName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 321);
            this.dataGridView1.TabIndex = 7;
            // 
            // cmdAddStop
            // 
            this.cmdAddStop.BackColor = System.Drawing.Color.White;
            this.cmdAddStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddStop.ForeColor = System.Drawing.Color.Maroon;
            this.cmdAddStop.Location = new System.Drawing.Point(398, 152);
            this.cmdAddStop.Name = "cmdAddStop";
            this.cmdAddStop.Size = new System.Drawing.Size(100, 33);
            this.cmdAddStop.TabIndex = 6;
            this.cmdAddStop.Text = "Add Stop";
            this.cmdAddStop.UseVisualStyleBackColor = false;
            this.cmdAddStop.Click += new System.EventHandler(this.cmdAddStop_Click);
            // 
            // txtStopName
            // 
            this.txtStopName.Location = new System.Drawing.Point(307, 70);
            this.txtStopName.Multiline = true;
            this.txtStopName.Name = "txtStopName";
            this.txtStopName.Size = new System.Drawing.Size(203, 41);
            this.txtStopName.TabIndex = 5;
            // 
            // lblStopName
            // 
            this.lblStopName.AutoSize = true;
            this.lblStopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopName.ForeColor = System.Drawing.Color.Navy;
            this.lblStopName.Location = new System.Drawing.Point(303, 23);
            this.lblStopName.Name = "lblStopName";
            this.lblStopName.Size = new System.Drawing.Size(93, 20);
            this.lblStopName.TabIndex = 4;
            this.lblStopName.Text = "StopName";
            // 
            // Addstop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 336);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdAddStop);
            this.Controls.Add(this.txtStopName);
            this.Controls.Add(this.lblStopName);
            this.Name = "Addstop";
            this.Text = "Addstop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdAddStop;
        private System.Windows.Forms.TextBox txtStopName;
        private System.Windows.Forms.Label lblStopName;
    }
}