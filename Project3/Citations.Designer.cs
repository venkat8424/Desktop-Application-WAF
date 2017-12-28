namespace Project3
{
    partial class Citations
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
            this.lbl_citationsTitle = new System.Windows.Forms.Label();
            this.rtb_citations = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_citationsTitle
            // 
            this.lbl_citationsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_citationsTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_citationsTitle.Location = new System.Drawing.Point(32, 27);
            this.lbl_citationsTitle.Name = "lbl_citationsTitle";
            this.lbl_citationsTitle.Size = new System.Drawing.Size(811, 23);
            this.lbl_citationsTitle.TabIndex = 0;
            this.lbl_citationsTitle.Text = "title";
            this.lbl_citationsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_citations
            // 
            this.rtb_citations.BackColor = System.Drawing.Color.DarkOrange;
            this.rtb_citations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_citations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_citations.Location = new System.Drawing.Point(36, 64);
            this.rtb_citations.Name = "rtb_citations";
            this.rtb_citations.ReadOnly = true;
            this.rtb_citations.Size = new System.Drawing.Size(827, 541);
            this.rtb_citations.TabIndex = 1;
            this.rtb_citations.Text = "";
            // 
            // Citations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(875, 617);
            this.Controls.Add(this.rtb_citations);
            this.Controls.Add(this.lbl_citationsTitle);
            this.Name = "Citations";
            this.Text = "Citations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_citationsTitle;
        private System.Windows.Forms.RichTextBox rtb_citations;
    }
}