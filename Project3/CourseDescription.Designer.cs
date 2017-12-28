namespace Project3
{
    partial class CourseDescription
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
            this.lbl_courseDescTitle = new System.Windows.Forms.Label();
            this.lbl_courseDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_courseDescTitle
            // 
            this.lbl_courseDescTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_courseDescTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_courseDescTitle.Location = new System.Drawing.Point(12, 32);
            this.lbl_courseDescTitle.Name = "lbl_courseDescTitle";
            this.lbl_courseDescTitle.Size = new System.Drawing.Size(988, 39);
            this.lbl_courseDescTitle.TabIndex = 0;
            this.lbl_courseDescTitle.Text = "title";
            this.lbl_courseDescTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_courseDesc
            // 
            this.lbl_courseDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_courseDesc.ForeColor = System.Drawing.Color.Black;
            this.lbl_courseDesc.Location = new System.Drawing.Point(12, 71);
            this.lbl_courseDesc.Name = "lbl_courseDesc";
            this.lbl_courseDesc.Size = new System.Drawing.Size(988, 201);
            this.lbl_courseDesc.TabIndex = 1;
            this.lbl_courseDesc.Text = "description";
            // 
            // CourseDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 281);
            this.Controls.Add(this.lbl_courseDesc);
            this.Controls.Add(this.lbl_courseDescTitle);
            this.Name = "CourseDescription";
            this.Text = "CourseDescription";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_courseDescTitle;
        private System.Windows.Forms.Label lbl_courseDesc;
    }
}