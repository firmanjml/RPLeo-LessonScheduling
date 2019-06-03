using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPTimeSchedule
{
    public partial class Form1 : Form
    {
        private static List<string> classList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"\w{4}-[12345]\w-\w{4}-[ABCDEFGHIJ]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(txtbox1.Text);
            if (matches.Count == 1)
            {
                string[] arr = Utils.class_to_array(txtbox1.Text);
                string title = arr[0];
                string lesson = arr[1];
                string venue = arr[2];
                string mode = arr[3];
   
                MessageBox.Show(Utils.VALID_CODE, "Info");
            } else
            {
                MessageBox.Show(Utils.INVALID_CODE, "Error");
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter class code\n\nExample: C109-1B-W66P-A", "Info");
        }

        private void addListBtn_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"\w{4}-[12345]\w-\w{4}-[ABCDEFGHIJ]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(txtbox1.Text);
            if (matches.Count == 1)
            {
                bool isFound = false;
                foreach (string s in classList)
                {
                    if (s.Equals(txtbox1.Text))
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    comboList.Items.Add(txtbox1.Text);
                    classList.Add(txtbox1.Text);
                    MessageBox.Show(Utils.SAVE_TO_LIST_SUCCESS, "Info");
                } else
                {
                    MessageBox.Show(Utils.LIST_EXISTS, "Info");
                }
            }
            else
            {
                MessageBox.Show(Utils.INVALID_CODE, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            clearResBtn.Enabled = false;
            try
            {
                using (StreamReader sr = new StreamReader("class.txt"))
                {

                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Debug.WriteLine(s);
                        comboList.Items.Add(s);
                        classList.Add(s);
                    }
                    wipeBtn.Enabled = true;
                }
            }
            
            catch (Exception error)
            {
                Debug.WriteLine(error);
            }
        }

        private void clearResBtn_Click(object sender, EventArgs e)
        {
            lp1Label.Text = "Not Selected";
            lp2Label.Text = "Not Selected";
            lp3Label.Text = "Not Selected";
            breakLabel.Text = "Not Selected";
            break2Label.Text = "Not Selected";
            moduleLabel.Text = "Not Set";
            timeLabel.Text = "Not Set";
            dayLabel.Text = "Not Set";
            clearResBtn.Enabled = false;
        }

        private void ComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arr = Utils.class_to_array(comboList.SelectedItem.ToString());
            string module_code = arr[0];
            string lesson_start = arr[1];

            moduleLabel.Text = module_code;
            dayLabel.Text = Utils.getDayFromLesson(lesson_start);
            timeLabel.Text = Utils.getTimeFromLesson(lesson_start).ToString("HH:mm tt");
            //------------------------------------------//
            DateTime lp1_start = Utils.getTimeFromLesson(lesson_start);
            DateTime lp1_end = lp1_start.AddMinutes(60);

            DateTime break1_start = lp1_end;
            DateTime break1_end = break1_start.AddMinutes(45);

            DateTime lp2_start = break1_end;
            DateTime lp2_end = lp2_start.AddMinutes(90);

            DateTime break2_start = lp2_end;
            DateTime break2_end = break2_start.AddMinutes(90);

            DateTime lp3_start = break2_end;
            DateTime lp3_end = lp3_start.AddMinutes(120);
            //------------------------------------------//
            lp1Label.Text = $"{lp1_start.ToString("HH:mm")}-{lp1_end.ToString("HH:mm")}";
            breakLabel.Text = $"{break1_start.ToString("HH:mm")}-{break1_end.ToString("hh:mm")}";
            lp2Label.Text = $"{lp2_start.ToString("HH:mm")}-{lp2_end.ToString("HH:mm")}";
            break2Label.Text = $"{break2_start.ToString("HH:mm")}-{break2_end.ToString("hh:mm")}";
            lp3Label.Text = $"{lp3_start.ToString("HH:mm")}-{lp3_end.ToString("HH:mm")}";
            clearResBtn.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (classList.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter("class.txt"))
                {
                    foreach (string c in classList)
                    {
                        sw.WriteLine(c);
                    }
                    sw.Close();
                    wipeBtn.Enabled = true;
                    MessageBox.Show(Utils.SAVE_TO_FILE_SUCCESS, "Info");
                }
            } else
            {
                MessageBox.Show(Utils.SAVE_TO_FILE_WHEN_LIST_EMPTY, "Error");
            }
        }

        private void WipeBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("class.txt"))
            {
                File.Delete("class.txt");
            }
            classList.Clear();
            comboList.Items.Clear();
            wipeBtn.Enabled = false;
        }
    }
}
