using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class MinorDescription : Form
    {
        Course[] courses;
        public MinorDescription(Minors minors, string name, Course[] coursesRecieved)
        {
            InitializeComponent();
            UgMinor result = minors.UgMinors.Find(x => x.title.Equals(name));
            lbl_minorTitle.Text = result.title;
            int liasionIndex = result.description.IndexOf("Faculty Minor Liaison:");
            lbl_minorDescription.Text = result.description.Substring(0,liasionIndex);
            int liasionStartIndex = liasionIndex + 23;
            int liasionLength = result.description.IndexOf(".", liasionStartIndex) - liasionStartIndex;
            lbl_liasion.Text = "Faculty Minor Liaison: "+ result.description.Substring(liasionStartIndex, liasionLength);
            int advisorIndex = result.description.IndexOf("Minor Advisor:");
            int advisorStartIndex = advisorIndex + 15;
            int advisorLength = (result.description.Length) - advisorStartIndex;
            lbl_advisor.Text = "Minor Advisor: "+ result.description.Substring(advisorStartIndex, advisorLength);
            for (int i=0; i< result.courses.Count; i++)
            {
                lb_courseList.Items.Add(result.courses[i]);
            }
            courses = coursesRecieved;
        }

        private void lb_courseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course result = courses.ToList().Find(x => x.courseID.Equals(lb_courseList.SelectedItem.ToString()));
            CourseDescription cd = new CourseDescription(result);
            cd.ShowDialog();
        }
    }
}
