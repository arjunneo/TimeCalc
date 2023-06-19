using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace TimeCalc
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimeCalculator();
            }
        }

        private string FormatListItem(int hours, int mins, int seconds)
        {
            string? listStringItem = "";

            if (hours == 0)
            {
                listStringItem = "00";
            }
            else if (hours.ToString().Length < 2)
            {
                listStringItem = "0" + hours.ToString();
            }
            else
            {
                listStringItem = hours.ToString();
            }

            if (mins == 0)
            {
                listStringItem = listStringItem + ":" + "00";
            }
            else if (mins.ToString().Length < 2)
            {
                listStringItem = listStringItem + ":" + "0" + mins.ToString();
            }
            else
            {
                listStringItem = listStringItem + ":" + mins.ToString();
            }

            if (seconds == 0)
            {
                listStringItem = listStringItem + ":" + "00";
            }
            else if (seconds.ToString().Length < 2)
            {
                listStringItem = listStringItem + ":" + "0" + seconds.ToString();
            }
            else
            {
                listStringItem = listStringItem + ":" + seconds.ToString();
            }

            return listStringItem;
        }

        private void AddListItems(List<string> listObj)
        {
            lstbTimeLists.Items.Clear();
            //foreach (string str in listObj)
            //{
            //    lstbTimeLists.Items.Add(str);
            //}

            for (int i = 0; i < listObj.Count; i++)
            {
                int j = i;
                j++;
                string str = Convert.ToString(j) + ". " + listObj[i].ToString();
                lstbTimeLists.Items.Add(str);
            }


            int visibleItems = lstbTimeLists.ClientSize.Height / lstbTimeLists.ItemHeight;
            lstbTimeLists.TopIndex = Math.Max(lstbTimeLists.Items.Count - visibleItems + 1, 0);
        }

        private void TimeCalculator()
        {
            int hrs = tbHours.Text != "" ? Convert.ToInt32(tbHours.Text) : 0;
            int mins = tbMins.Text != "" ? Convert.ToInt32(tbMins.Text) : 0;
            int secs = tbSecs.Text != "" ? Convert.ToInt32(tbSecs.Text) : 0;

            if (list.Count == 0)
            {
                string formatedTime = FormatListItem(hrs, mins, secs);
                list.Add(formatedTime);
                AddListItems(list);

                //totalTime.Text = hrs.ToString() + ":" + mins.ToString() + ":" + secs.ToString();
                totalTime.Text = formatedTime;
                clearFields();
            }
            else if (list.Count > 0)
            {
                //string? strListitem = lstbTimeLists.Items[lstbTimeLists.Items.Count - 1].ToString();
                string? strListitem = totalTime.Text;
                string[] strValues = strListitem.Split(":");

                int prevhrs = Convert.ToInt32(strValues[0]);
                int prevmins = Convert.ToInt32(strValues[1]);
                int prevsecs = Convert.ToInt32(strValues[2]);

                int calcSecs = secs + prevsecs;
                if (calcSecs > 60)
                {
                    calcSecs -= 60;
                    prevmins++;
                }

                int calcMins = mins + prevmins;
                if (calcMins > 60)
                {
                    calcMins -= 60;
                    prevhrs++;
                }

                int calcHrs = hrs + prevhrs;
                //totalTime.Text = calcHrs.ToString() + ":" + calcMins.ToString() + ":" + calcSecs.ToString();
                totalTime.Text = FormatListItem(calcHrs, calcMins, calcSecs);

                list.Add(FormatListItem(hrs, mins, secs));
                AddListItems(list);

                clearFields();
            }
        }

        private void clearFields()
        {
            tbHours.Text = "";
            tbMins.Text = "";
            tbSecs.Text = "";
            tbHours.Focus();
        }

        private void clearAllFields()
        {
            clearFields();
            list.Clear();
            totalTime.Text = "";
            lstbTimeLists.Items.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void tbHours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimeCalculator();
            }
        }

        private void tbMins_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimeCalculator();
            }
        }
    }
}