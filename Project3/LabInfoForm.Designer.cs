namespace Project3
{
    partial class LabInfoForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.link_labSchedule = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_title.Location = new System.Drawing.Point(34, 44);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(751, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_desc
            // 
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(34, 100);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(751, 190);
            this.lbl_desc.TabIndex = 1;
            this.lbl_desc.Text = "description";
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_labSchedule
            // 
            this.link_labSchedule.AutoSize = true;
            this.link_labSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_labSchedule.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_labSchedule.LinkColor = System.Drawing.Color.DarkOrange;
            this.link_labSchedule.Location = new System.Drawing.Point(34, 349);
            this.link_labSchedule.Name = "link_labSchedule";
            this.link_labSchedule.Size = new System.Drawing.Size(250, 24);
            this.link_labSchedule.TabIndex = 2;
            this.link_labSchedule.TabStop = true;
            this.link_labSchedule.Text = "Lab Hours and TA Schedule";
            this.link_labSchedule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_labSchedule_LinkClicked);
            // 
            // LabInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 582);
            this.Controls.Add(this.link_labSchedule);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_title);
            this.Name = "LabInfoForm";
            this.Text = "LabInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.LinkLabel link_labSchedule;
    }
}