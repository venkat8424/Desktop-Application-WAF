namespace Project3
{
    partial class MinorDescription
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
            this.lbl_minorTitle = new System.Windows.Forms.Label();
            this.lbl_minorDescription = new System.Windows.Forms.Label();
            this.lbl_liasion = new System.Windows.Forms.Label();
            this.lbl_advisor = new System.Windows.Forms.Label();
            this.lbl_coursesTitle = new System.Windows.Forms.Label();
            this.lb_courseList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_minorTitle
            // 
            this.lbl_minorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minorTitle.Location = new System.Drawing.Point(57, 28);
            this.lbl_minorTitle.Name = "lbl_minorTitle";
            this.lbl_minorTitle.Size = new System.Drawing.Size(826, 34);
            this.lbl_minorTitle.TabIndex = 0;
            this.lbl_minorTitle.Text = "title";
            this.lbl_minorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_minorDescription
            // 
            this.lbl_minorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minorDescription.Location = new System.Drawing.Point(57, 76);
            this.lbl_minorDescription.Name = "lbl_minorDescription";
            this.lbl_minorDescription.Size = new System.Drawing.Size(826, 158);
            this.lbl_minorDescription.TabIndex = 1;
            this.lbl_minorDescription.Text = "description";
            // 
            // lbl_liasion
            // 
            this.lbl_liasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_liasion.Location = new System.Drawing.Point(57, 234);
            this.lbl_liasion.Name = "lbl_liasion";
            this.lbl_liasion.Size = new System.Drawing.Size(826, 30);
            this.lbl_liasion.TabIndex = 2;
            this.lbl_liasion.Text = "liasion";
            this.lbl_liasion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_advisor
            // 
            this.lbl_advisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_advisor.Location = new System.Drawing.Point(57, 264);
            this.lbl_advisor.Name = "lbl_advisor";
            this.lbl_advisor.Size = new System.Drawing.Size(826, 30);
            this.lbl_advisor.TabIndex = 3;
            this.lbl_advisor.Text = "advisor";
            this.lbl_advisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_coursesTitle
            // 
            this.lbl_coursesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursesTitle.Location = new System.Drawing.Point(57, 325);
            this.lbl_coursesTitle.Name = "lbl_coursesTitle";
            this.lbl_coursesTitle.Size = new System.Drawing.Size(826, 23);
            this.lbl_coursesTitle.TabIndex = 4;
            this.lbl_coursesTitle.Text = "Courses";
            this.lbl_coursesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_courseList
            // 
            this.lb_courseList.BackColor = System.Drawing.Color.Bisque;
            this.lb_courseList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_courseList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_courseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_courseList.ForeColor = System.Drawing.Color.Red;
            this.lb_courseList.FormattingEnabled = true;
            this.lb_courseList.ItemHeight = 16;
            this.lb_courseList.Location = new System.Drawing.Point(426, 351);
            this.lb_courseList.Name = "lb_courseList";
            this.lb_courseList.Size = new System.Drawing.Size(91, 146);
            this.lb_courseList.TabIndex = 5;
            this.lb_courseList.SelectedIndexChanged += new System.EventHandler(this.lb_courseList_SelectedIndexChanged);
            // 
            // MinorDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(944, 632);
            this.Controls.Add(this.lb_courseList);
            this.Controls.Add(this.lbl_coursesTitle);
            this.Controls.Add(this.lbl_advisor);
            this.Controls.Add(this.lbl_liasion);
            this.Controls.Add(this.lbl_minorDescription);
            this.Controls.Add(this.lbl_minorTitle);
            this.Name = "MinorDescription";
            this.Text = "MinorDescription";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_minorTitle;
        private System.Windows.Forms.Label lbl_minorDescription;
        private System.Windows.Forms.Label lbl_liasion;
        private System.Windows.Forms.Label lbl_advisor;
        private System.Windows.Forms.Label lbl_coursesTitle;
        private System.Windows.Forms.ListBox lb_courseList;
    }
}