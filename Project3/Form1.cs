/*
 * Author: Sai Venkat Kotha, sxk2606@rit.edu
 * Client Design and Development - Project 3
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        About about;
        Degrees degrees;
        Minors minors;
        Employment employment;
        People people;
        Research research;
        Resources resources;
        News news;
        Footer footer;
        Course[] courses;

        Rest rj = new Rest("http://ist.rit.edu/api");

        public Form1()
        {
            InitializeComponent();
        }

        //reading 'about' data from the api and loading it onto the form
        private void Form1_Load(object sender, EventArgs e)
        {
            getAbout();
        }

        /* loading the required data on selecting a tab, the data will be read from the api
        only if its corresponding object is empty (reading only once from the api) */
        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = tabMenu.SelectedIndex;

            if (tabIndex == 1)
            {
                if (degrees == null)
                {
                    getDegrees();
                }

            }
            else if (tabIndex == 2)
            {
                if (minors == null)
                {
                    getMinors();
                }
            }
            else if (tabIndex == 3)
            {
                if (employment == null)
                {
                    getEmployment();
                }
            }
            else if (tabIndex == 4)
            {
                if (employment == null)
                {
                    getEmployment();
                }
            }
            else if (tabIndex == 5)
            {
                if (people == null)
                {
                    getPeople();
                }
            }
            else if (tabIndex == 6)
            {
                if (research == null)
                {
                    getResearch();
                }
            }
            else if (tabIndex == 7)
            {
                if (resources == null)
                {
                    getResources();
                }
            }
            else if (tabIndex == 8)
            {
                if (news == null)
                {
                    getNews();
                }
            }
            else if (tabIndex == 9)
            {
                if (footer == null)
                {
                    getFooter();
                }
            }

        }
        private void getAbout()
        {
            //getting about
            string jsonAbout = rj.getJSON("/about/");
            about = JToken.Parse(jsonAbout).ToObject<About>();
            lbl_about_title.Text = about.title;
            lbl_about_desc.Text = about.description;
            lbl_about_quote.Text = "\"" + about.quote + "\"" + Environment.NewLine + about.quoteAuthor;
        }

        private async void getDegrees()
        {
            //getting degrees
            spinner_degrees.Visible = true;

            await Task.Run(() =>
            {
                string jsonDegrees = rj.getJSON("/degrees/");
                degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();
            });

            lbl_ugDegree1Title.Tag = degrees.undergraduate[0].degreeName;
            lbl_ugDegree1Title.Text = degrees.undergraduate[0].title;
            lbl_ugDegree1Desc.Tag = degrees.undergraduate[0].degreeName;
            lbl_ugDegree1Desc.Text = degrees.undergraduate[0].description;

            lbl_ugDegree2Title.Tag = degrees.undergraduate[1].degreeName;
            lbl_ugDegree2Title.Text = degrees.undergraduate[1].title;
            lbl_ugDegree2Desc.Text = degrees.undergraduate[1].description;
            lbl_ugDegree2Desc.Tag = degrees.undergraduate[1].degreeName;

            lbl_ugDegree3Title.Tag = degrees.undergraduate[2].degreeName;
            lbl_ugDegree3Title.Text = degrees.undergraduate[2].title;
            lbl_ugDegree3Desc.Tag = degrees.undergraduate[2].degreeName;
            lbl_ugDegree3Desc.Text = degrees.undergraduate[2].description;

            lbl_gradDegree1Title.Tag = degrees.graduate[0].degreeName;
            lbl_gradDegree1Title.Text = degrees.graduate[0].title;
            lbl_gradDegree1Desc.Tag = degrees.graduate[0].degreeName;
            lbl_gradDegree1Desc.Text = degrees.graduate[0].description;

            lbl_gradDegree2Title.Tag = degrees.graduate[1].degreeName;
            lbl_gradDegree2Title.Text = degrees.graduate[1].title;
            lbl_gradDegree2Desc.Tag = degrees.graduate[1].degreeName;
            lbl_gradDegree2Desc.Text = degrees.graduate[1].description;

            lbl_gradDegree3Title.Tag = degrees.graduate[2].degreeName;
            lbl_gradDegree3Title.Text = degrees.graduate[2].title;
            lbl_gradDegree3Desc.Tag = degrees.graduate[2].degreeName;
            lbl_gradDegree3Desc.Text = degrees.graduate[2].description;

            lbl_advCert.Text = "Advanced Certificates";
            lbl_advCertiDesc.Text = degrees.graduate[3].availableCertificates[0] + Environment.NewLine + degrees.graduate[3].availableCertificates[1];

            spinner_degrees.Visible = false;
        }

        private async void getMinors()
        {
            //getting minors
            spinner_minors.Visible = true;

            await Task.Run(() =>
            {
                string jsonMinors = rj.getJSON("/minors/");
                minors = JToken.Parse(jsonMinors).ToObject<Minors>();
                //getting course information
                string jsonCourse = rj.getJSON("/course/");
                courses = JsonConvert.DeserializeObject<Course[]>(jsonCourse);
            });

            lbl_minor1.Text = minors.UgMinors[0].title;
            lbl_minor2.Text = minors.UgMinors[1].title;
            lbl_minor3.Text = minors.UgMinors[2].title;
            lbl_minor4.Text = minors.UgMinors[3].title;
            lbl_minor5.Text = minors.UgMinors[4].title;
            lbl_minor6.Text = minors.UgMinors[5].title;
            lbl_minor7.Text = minors.UgMinors[6].title;
            lbl_minor8.Text = minors.UgMinors[7].title;

            spinner_minors.Visible = false;
        }

        private async void getEmployment()
        {
            //getting employment
            spinner_employment.Visible = true;
            spinner_empLocations.Visible = true;

            await Task.Run(() =>
            {
                string jsonEmp = rj.getJSON("/employment/");
                employment = JToken.Parse(jsonEmp).ToObject<Employment>();
            });

            lbl_empTitle.Text = employment.introduction.title;
            lbl_empContentTitle.Text = employment.introduction.content[0].title;
            lbl_empDescription.Text = employment.introduction.content[0].description;
            lbl_coopContentTitle.Text = employment.introduction.content[1].title;
            lbl_coopDescription.Text = employment.introduction.content[1].description;
            lbl_ds1Value.Text = employment.degreeStatistics.statistics[0].value;
            lbl_ds1Desc.Text = employment.degreeStatistics.statistics[0].description;
            lbl_ds2Value.Text = employment.degreeStatistics.statistics[1].value;
            lbl_ds2Desc.Text = employment.degreeStatistics.statistics[1].description;
            lbl_ds3Value.Text = employment.degreeStatistics.statistics[2].value;
            lbl_ds3Desc.Text = employment.degreeStatistics.statistics[2].description;
            lbl_ds4Value.Text = employment.degreeStatistics.statistics[3].value;
            lbl_ds4Desc.Text = employment.degreeStatistics.statistics[3].description;
            string empNames = "";
            for (int i = 0; i < employment.employers.employerNames.Count - 1; i++)
            {
                empNames += employment.employers.employerNames[i] + "      ";
            }
            empNames += employment.employers.employerNames[employment.employers.employerNames.Count - 1];
            lbl_empList.Text = empNames;
            string careerNames = "";
            for (int i = 0; i < employment.careers.careerNames.Count - 1; i++)
            {
                careerNames += employment.careers.careerNames[i] + "      ";
            }
            careerNames += employment.careers.careerNames[employment.careers.careerNames.Count - 1];
            lbl_careersList.Text = careerNames;

            //filling up coop table
            lv_coopTable.Columns.Add("DEGREE", 200);
            lv_coopTable.Columns.Add("EMPLOYER", 260);
            lv_coopTable.Columns.Add("LOCATION", 260);
            lv_coopTable.Columns.Add("TERM", 200);

            ListViewItem item;
            for (int i = 0; i < employment.coopTable.coopInformation.Count; i++)
            {
                item = new ListViewItem(new String[] {
                    employment.coopTable.coopInformation[i].degree,
                    employment.coopTable.coopInformation[i].employer,
                    employment.coopTable.coopInformation[i].city,
                    employment.coopTable.coopInformation[i].term
                });
                lv_coopTable.Items.Add(item);
            }

            //filling up professional table
            lv_profTable.Columns.Add("DEGREE", 170);
            lv_profTable.Columns.Add("EMPLOYER", 195);
            lv_profTable.Columns.Add("LOCATION", 195);
            lv_profTable.Columns.Add("TITLE", 195);
            lv_profTable.Columns.Add("START DATE", 170);

            for (int i = 0; i < employment.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                item = new ListViewItem(new String[] {
                    employment.employmentTable.professionalEmploymentInformation[i].degree,
                    employment.employmentTable.professionalEmploymentInformation[i].employer,
                    employment.employmentTable.professionalEmploymentInformation[i].city,
                    employment.employmentTable.professionalEmploymentInformation[i].title,
                    employment.employmentTable.professionalEmploymentInformation[i].startDate
                });
                lv_profTable.Items.Add(item);
            }

            spinner_employment.Visible = false;
            spinner_empLocations.Visible = false;
        }

        private async void getPeople()
        {
            //getting people
            spinner_people.Visible = true;

            await Task.Run(() =>
            {
                string jsonPeople = rj.getJSON("/people/");
                people = JToken.Parse(jsonPeople).ToObject<People>();
            });

            //adding faculty names
            for (int i = 0; i < people.faculty.Count; i++)
            {
                lb_faculty.Items.Add(people.faculty[i].name);
            }
            //adding staff names
            for (int i = 0; i < people.staff.Count; i++)
            {
                lb_staff.Items.Add(people.staff[i].name);
            }

            spinner_people.Visible = false;
        }

        private async void getResearch()
        {
            //getting research
            spinner_research.Visible = true;

            await Task.Run(() =>
            {
                string jsonResearch = rj.getJSON("/research/");
                research = JToken.Parse(jsonResearch).ToObject<Research>();
            });
            
            //by area
            lbl_researchArea1.Text = research.byInterestArea[0].areaName;
            lbl_researchArea2.Text = research.byInterestArea[1].areaName;
            lbl_researchArea3.Text = research.byInterestArea[2].areaName;
            lbl_researchArea4.Text = research.byInterestArea[3].areaName;
            lbl_researchArea5.Text = research.byInterestArea[4].areaName;
            lbl_researchArea6.Text = research.byInterestArea[5].areaName;
            lbl_researchArea7.Text = research.byInterestArea[6].areaName;
            lbl_researchArea8.Text = research.byInterestArea[7].areaName;
            lbl_researchArea9.Text = research.byInterestArea[8].areaName;
            lbl_researchArea10.Text = research.byInterestArea[9].areaName;
            lbl_researchArea11.Text = research.byInterestArea[10].areaName;
            lbl_researchArea12.Text = research.byInterestArea[11].areaName;
            //by faculty
            foreach (ByFaculty thisFac in research.byFaculty)
            {
                lb_researchFaculty.Items.Add(thisFac.facultyName);
            }

            spinner_research.Visible = false;
        }

        private async void getResources()
        {
            //getting resources
            spinner_resources.Visible = true;

            await Task.Run(() =>
            {
                string jsonResources = rj.getJSON("/resources/");
                resources = JToken.Parse(jsonResources).ToObject<Resources>();
            });
            
            lbl_resource1.Text = resources.studyAbroad.title;
            lbl_resource2.Text = resources.studentServices.title;
            lbl_resource3.Text = resources.studentAmbassadors.title;
            lbl_resource4.Text = resources.tutorsAndLabInformation.title;
            lbl_resource5.Text = resources.coopEnrollment.title;
            lbl_resource6.Text = "Forms";

            spinner_resources.Visible = false;
        }

        private async void getNews()
        {
            //getting news
            spinner_news.Visible = true;

            await Task.Run(() =>
            {
                string jsonNews = rj.getJSON("/news/");
                news = JToken.Parse(jsonNews).ToObject<News>();
            });
            
            for (int i = 0; i < news.older.Count; i++)
            {
                rtb_news.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                rtb_news.SelectionColor = Color.DarkOrange;
                rtb_news.AppendText(news.older[i].title);
                rtb_news.AppendText(Environment.NewLine);
                rtb_news.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
                rtb_news.SelectionColor = Color.Black;
                if (news.older[i].description != null)
                {
                    rtb_news.AppendText(news.older[i].description);
                }
                rtb_news.AppendText(Environment.NewLine);
                rtb_news.AppendText(Environment.NewLine);
            }

            spinner_news.Visible = false;
        }

        private async void getFooter()
        {
            // getting footer content
            spinner_social.Visible = true;

            await Task.Run(() =>
            {
                string jsonFooter = rj.getJSON("/footer/");
                footer = JToken.Parse(jsonFooter).ToObject<Footer>();
            });

            lbl_socialTitle.Text = footer.social.title;
            lbl_socialTweet.Text = footer.social.tweet;
            lbl_socialBy.Text = footer.social.by;
            link_twitter.Tag = footer.social.twitter;
            link_facebook.Tag = footer.social.facebook;

            quickLink1.Text = footer.quickLinks[0].title;
            quickLink1.Tag = footer.quickLinks[0].href;

            quickLink2.Text = footer.quickLinks[1].title;
            quickLink2.Tag = footer.quickLinks[1].href;

            quickLink3.Text = footer.quickLinks[2].title;
            quickLink3.Tag = footer.quickLinks[2].href;

            quickLink4.Text = footer.quickLinks[3].title;
            quickLink4.Tag = footer.quickLinks[3].href;

            link_RIT.Tag = "www.rit.edu";

            lbl_socialAddress.Text = "One Lomb Memorial Drive, Rochester, NY 14623-5603";

            spinner_social.Visible = false;
        }

        // displaying selected faculty details
        private void lb_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_peopleName.Text = lb_faculty.SelectedItem.ToString();
            Faculty result = people.faculty.Find(x => x.name.Equals(lb_faculty.SelectedItem.ToString()));
            lbl_peopleTitle.Text = result.title;
            pnl_peopleDetails.Visible = true;
            lbl_office.Text = result.office;
            lbl_phone.Text = result.phone;
            lbl_email.Text = result.email;
            lbl_website.Text = result.website;
            pb_people.Load(result.imagePath);
        }

        // displying selected staff details
        private void lb_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_peopleName.Text = lb_staff.SelectedItem.ToString();
            Staff result = people.staff.Find(x => x.name.Equals(lb_staff.SelectedItem.ToString()));
            lbl_peopleTitle.Text = result.title;
            pnl_peopleDetails.Visible = true;
            lbl_office.Text = result.office;
            lbl_phone.Text = result.phone;
            lbl_email.Text = result.email;
            lbl_website.Text = result.website;
            pb_people.Load(result.imagePath);
        }

        // displaying undergraduate degree concentrations
        private void ugDegreeClicked(object sender, EventArgs e)
        {
            Label degreeLabel = sender as Label;
            ugDegreeDescription desc = new ugDegreeDescription(degrees, degreeLabel.Tag.ToString());
            desc.ShowDialog();
        }

        // displaying graduate degree concentrations
        private void gradDegreeClicked(object sender, EventArgs e)
        {
            Label degreeLabel = sender as Label;
            gradDegreeDescription desc = new gradDegreeDescription(degrees, degreeLabel.Tag.ToString());
            desc.ShowDialog();
        }

        // displaying minor's description and courses
        private void minorClicked(object sender, EventArgs e)
        {
            Label minorLabel = sender as Label;
            MinorDescription minorDesc = new MinorDescription(minors, minorLabel.Text, courses);
            minorDesc.ShowDialog();
        }

        // displaying citations for the research area
        private void researchAreaClicked(object sender, EventArgs e)
        {
            Label researchAreaLabel = sender as Label;
            Citations cit = new Citations(research.byInterestArea, researchAreaLabel.Text);
            cit.ShowDialog();
        }

        // displaying citations for research by faculty
        private void lb_researchFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Citations cit = new Citations(research.byFaculty, lb_researchFaculty.SelectedItem.ToString());
            cit.ShowDialog();
        }
           
        // expanding study abroad
        private void lbl_resource1_Click(object sender, EventArgs e)
        {
            StudyAbroadForm sa = new StudyAbroadForm(resources.studyAbroad);
            sa.ShowDialog();
        }

        // expanding advising services
        private void lbl_resource2_Click(object sender, EventArgs e)
        {
            AdvisingForm adv = new AdvisingForm(resources.studentServices);
            adv.ShowDialog();
        }

        // expanding student ambassadors
        private void lbl_resource3_Click(object sender, EventArgs e)
        {
            StudentAmbassadorsForm samb = new StudentAmbassadorsForm(resources.studentAmbassadors);
            samb.ShowDialog();
        }

        // expanding lab information
        private void lbl_resource4_Click(object sender, EventArgs e)
        {
            LabInfoForm labInfo = new LabInfoForm(resources.tutorsAndLabInformation);
            labInfo.ShowDialog();
        }

        // expanding coop enrollment information
        private void lbl_resource5_Click(object sender, EventArgs e)
        {
            CoopForm coop = new CoopForm(resources.coopEnrollment);
            coop.ShowDialog();
        }

        // expanding forms
        private void lbl_resource6_Click(object sender, EventArgs e)
        {
            ResourceForms rf = new ResourceForms(resources.forms);
            rf.ShowDialog();
        }

        // an event handler for all the links clicked in the social tab
        private void socialLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            ll.LinkVisited = true;
            Process.Start(ll.Tag.ToString());
        }
    }
}
