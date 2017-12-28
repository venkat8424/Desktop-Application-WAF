namespace Project3
{
    partial class ugDegreeDescription
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
            this.lbl_concentratonList = new System.Windows.Forms.Label();
            this.lbl_concTitle = new System.Windows.Forms.Label();
            this.lbl_ugDegreeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_concentratonList
            // 
            this.lbl_concentratonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concentratonList.ForeColor = System.Drawing.Color.White;
            this.lbl_concentratonList.Location = new System.Drawing.Point(235, 147);
            this.lbl_concentratonList.Name = "lbl_concentratonList";
            this.lbl_concentratonList.Size = new System.Drawing.Size(365, 175);
            this.lbl_concentratonList.TabIndex = 0;
            this.lbl_concentratonList.Text = "concentrations";
            // 
            // lbl_concTitle
            // 
            this.lbl_concTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concTitle.Location = new System.Drawing.Point(235, 124);
            this.lbl_concTitle.Name = "lbl_concTitle";
            this.lbl_concTitle.Size = new System.Drawing.Size(174, 23);
            this.lbl_concTitle.TabIndex = 1;
            this.lbl_concTitle.Text = "Concentrations:";
            // 
            // lbl_ugDegreeName
            // 
            this.lbl_ugDegreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ugDegreeName.Location = new System.Drawing.Point(51, 29);
            this.lbl_ugDegreeName.Name = "lbl_ugDegreeName";
            this.lbl_ugDegreeName.Size = new System.Drawing.Size(725, 50);
            this.lbl_ugDegreeName.TabIndex = 2;
            this.lbl_ugDegreeName.Text = "degreeName";
            this.lbl_ugDegreeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ugDegreeDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(827, 464);
            this.Controls.Add(this.lbl_ugDegreeName);
            this.Controls.Add(this.lbl_concTitle);
            this.Controls.Add(this.lbl_concentratonList);
            this.Name = "ugDegreeDescription";
            this.Text = "degreeDescription";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_concentratonList;
        private System.Windows.Forms.Label lbl_concTitle;
        private System.Windows.Forms.Label lbl_ugDegreeName;
    }
}