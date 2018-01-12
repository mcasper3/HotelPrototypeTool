namespace HotelPrototypeTool
{
    partial class frmHotelModificationTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.newname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi Nate! ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newname
            // 
            this.newname.Location = new System.Drawing.Point(61, 121);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(138, 34);
            this.newname.TabIndex = 1;
            this.newname.Text = "cooler button name";
            this.newname.UseVisualStyleBackColor = true;
            this.newname.Click += new System.EventHandler(this.newname_Click);
            // 
            // frmHotelModificationTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.label1);
            this.Name = "frmHotelModificationTool";
            this.Text = "fghj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newname;
    }
}

