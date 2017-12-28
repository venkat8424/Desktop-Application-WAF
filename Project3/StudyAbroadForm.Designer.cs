namespace Project3
{
    partial class StudyAbroadForm
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
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_place1Title = new System.Windows.Forms.Label();
            this.lbl_place1desc = new System.Windows.Forms.Label();
            this.lbl_place2Title = new System.Windows.Forms.Label();
            this.lbl_place2Desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_title.Location = new System.Drawing.Point(76, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(647, 23);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Study Abroad";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(22, 82);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(755, 87);
            this.lbl_description.TabIndex = 1;
            this.lbl_description.Text = "description";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_place1Title
            // 
            this.lbl_place1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_place1Title.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_place1Title.Location = new System.Drawing.Point(22, 207);
            this.lbl_place1Title.Name = "lbl_place1Title";
            this.lbl_place1Title.Size = new System.Drawing.Size(755, 23);
            this.lbl_place1Title.TabIndex = 2;
            this.lbl_place1Title.Text = "place1Title";
            this.lbl_place1Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_place1desc
            // 
            this.lbl_place1desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_place1desc.Location = new System.Drawing.Point(22, 230);
            this.lbl_place1desc.Name = "lbl_place1desc";
            this.lbl_place1desc.Size = new System.Drawing.Size(755, 75);
            this.lbl_place1desc.TabIndex = 3;
            this.lbl_place1desc.Text = "place1desc";
            this.lbl_place1desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_place2Title
            // 
            this.lbl_place2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_place2Title.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_place2Title.Location = new System.Drawing.Point(22, 359);
            this.lbl_place2Title.Name = "lbl_place2Title";
            this.lbl_place2Title.Size = new System.Drawing.Size(755, 23);
            this.lbl_place2Title.TabIndex = 4;
            this.lbl_place2Title.Text = "place2Title";
            this.lbl_place2Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_place2Desc
            // 
            this.lbl_place2Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_place2Desc.Location = new System.Drawing.Point(22, 382);
            this.lbl_place2Desc.Name = "lbl_place2Desc";
            this.lbl_place2Desc.Size = new System.Drawing.Size(755, 75);
            this.lbl_place2Desc.TabIndex = 5;
            this.lbl_place2Desc.Text = "place2desc";
            this.lbl_place2Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudyAbroadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 564);
            this.Controls.Add(this.lbl_place2Desc);
            this.Controls.Add(this.lbl_place2Title);
            this.Controls.Add(this.lbl_place1desc);
            this.Controls.Add(this.lbl_place1Title);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Name = "StudyAbroadForm";
            this.Text = "StudyAbroad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_place1Title;
        private System.Windows.Forms.Label lbl_place1desc;
        private System.Windows.Forms.Label lbl_place2Title;
        private System.Windows.Forms.Label lbl_place2Desc;
    }
}