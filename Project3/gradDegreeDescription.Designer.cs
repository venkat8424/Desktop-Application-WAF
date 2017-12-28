namespace Project3
{
    partial class gradDegreeDescription
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
            this.lbl_gradDegreeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_gradConcList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_gradDegreeName
            // 
            this.lbl_gradDegreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gradDegreeName.Location = new System.Drawing.Point(38, 29);
            this.lbl_gradDegreeName.Name = "lbl_gradDegreeName";
            this.lbl_gradDegreeName.Size = new System.Drawing.Size(659, 46);
            this.lbl_gradDegreeName.TabIndex = 0;
            this.lbl_gradDegreeName.Text = "degreeName";
            this.lbl_gradDegreeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Concentrations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_gradConcList
            // 
            this.lbl_gradConcList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gradConcList.ForeColor = System.Drawing.Color.White;
            this.lbl_gradConcList.Location = new System.Drawing.Point(167, 145);
            this.lbl_gradConcList.Name = "lbl_gradConcList";
            this.lbl_gradConcList.Size = new System.Drawing.Size(365, 175);
            this.lbl_gradConcList.TabIndex = 2;
            this.lbl_gradConcList.Text = "concentrationList";
            // 
            // gradDegreeDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(732, 449);
            this.Controls.Add(this.lbl_gradConcList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_gradDegreeName);
            this.Name = "gradDegreeDescription";
            this.Text = "gradDegreeDescription";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_gradDegreeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_gradConcList;
    }
}