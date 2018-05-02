namespace Routes
{
    partial class Newnum
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbloldroute = new System.Windows.Forms.Label();
            this.lblOldbus = new System.Windows.Forms.Label();
            this.txtOldroute = new System.Windows.Forms.TextBox();
            this.txtOldbus = new System.Windows.Forms.TextBox();
            this.cmdAddnum = new System.Windows.Forms.Button();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.lblRouteNumber = new System.Windows.Forms.Label();
            this.lblBusNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(360, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "updateStop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbloldroute
            // 
            this.lbloldroute.AutoSize = true;
            this.lbloldroute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldroute.ForeColor = System.Drawing.Color.Navy;
            this.lbloldroute.Location = new System.Drawing.Point(12, 172);
            this.lbloldroute.Name = "lbloldroute";
            this.lbloldroute.Size = new System.Drawing.Size(152, 20);
            this.lbloldroute.TabIndex = 36;
            this.lbloldroute.Text = "Old RouteNumber";
            // 
            // lblOldbus
            // 
            this.lblOldbus.AutoSize = true;
            this.lblOldbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldbus.ForeColor = System.Drawing.Color.Navy;
            this.lblOldbus.Location = new System.Drawing.Point(19, 96);
            this.lblOldbus.Name = "lblOldbus";
            this.lblOldbus.Size = new System.Drawing.Size(134, 20);
            this.lblOldbus.TabIndex = 35;
            this.lblOldbus.Text = "Old BusNumber";
            // 
            // txtOldroute
            // 
            this.txtOldroute.Location = new System.Drawing.Point(206, 159);
            this.txtOldroute.Multiline = true;
            this.txtOldroute.Name = "txtOldroute";
            this.txtOldroute.Size = new System.Drawing.Size(120, 33);
            this.txtOldroute.TabIndex = 34;
            // 
            // txtOldbus
            // 
            this.txtOldbus.Location = new System.Drawing.Point(206, 96);
            this.txtOldbus.Multiline = true;
            this.txtOldbus.Name = "txtOldbus";
            this.txtOldbus.Size = new System.Drawing.Size(120, 33);
            this.txtOldbus.TabIndex = 33;
            // 
            // cmdAddnum
            // 
            this.cmdAddnum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdAddnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddnum.ForeColor = System.Drawing.Color.Maroon;
            this.cmdAddnum.Location = new System.Drawing.Point(374, 373);
            this.cmdAddnum.Name = "cmdAddnum";
            this.cmdAddnum.Size = new System.Drawing.Size(104, 38);
            this.cmdAddnum.TabIndex = 32;
            this.cmdAddnum.Text = "Change";
            this.cmdAddnum.UseVisualStyleBackColor = false;
            this.cmdAddnum.Click += new System.EventHandler(this.cmdAddnum_Click);
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(206, 287);
            this.txtRouteNumber.Multiline = true;
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(120, 34);
            this.txtRouteNumber.TabIndex = 31;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(206, 213);
            this.txtBusNumber.Multiline = true;
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(120, 33);
            this.txtBusNumber.TabIndex = 30;
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblRouteNumber.Location = new System.Drawing.Point(12, 287);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(159, 20);
            this.lblRouteNumber.TabIndex = 29;
            this.lblRouteNumber.Text = "New RouteNumber";
            // 
            // lblBusNumber
            // 
            this.lblBusNumber.AutoSize = true;
            this.lblBusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblBusNumber.Location = new System.Drawing.Point(19, 226);
            this.lblBusNumber.Name = "lblBusNumber";
            this.lblBusNumber.Size = new System.Drawing.Size(141, 20);
            this.lblBusNumber.TabIndex = 28;
            this.lblBusNumber.Text = "New BusNumber";
            // 
            // Newnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbloldroute);
            this.Controls.Add(this.lblOldbus);
            this.Controls.Add(this.txtOldroute);
            this.Controls.Add(this.txtOldbus);
            this.Controls.Add(this.cmdAddnum);
            this.Controls.Add(this.txtRouteNumber);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.lblRouteNumber);
            this.Controls.Add(this.lblBusNumber);
            this.Name = "Newnum";
            this.Text = "Newnum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbloldroute;
        private System.Windows.Forms.Label lblOldbus;
        private System.Windows.Forms.TextBox txtOldroute;
        private System.Windows.Forms.TextBox txtOldbus;
        private System.Windows.Forms.Button cmdAddnum;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label lblRouteNumber;
        private System.Windows.Forms.Label lblBusNumber;
    }
}