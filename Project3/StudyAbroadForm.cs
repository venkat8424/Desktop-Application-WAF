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
    public partial class StudyAbroadForm : Form
    {
        public StudyAbroadForm(StudyAbroad studyAbroad)
        {
            InitializeComponent();
            lbl_description.Text = studyAbroad.description;
            lbl_place1Title.Text = studyAbroad.places[0].nameOfPlace;
            lbl_place1desc.Text = studyAbroad.places[0].description;
            lbl_place2Title.Text = studyAbroad.places[1].nameOfPlace;
            lbl_place2Desc.Text = studyAbroad.places[1].description;

        }
    }
}
