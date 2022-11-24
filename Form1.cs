using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
namespace new_calendars
{

    public partial class Form1 : Form
    {

        //panel3 顯示月份的視窗
        //main 顯示年份的視窗
        //daycontainer 顯示日子的視窗
        //panel2 標題文字
        //label - label 7  星期幾文字
        //label8 標題文字
        private static int DateButtonNum = 42;
        public Panel[] DateButtons = new Panel[DateButtonNum];
        private Label[] ButtonText = new Label[DateButtonNum];
        //private  Label[] ButtonText = new Label[] { a1, a2, a3, a4 };
        
        public static string static_years, static_months , static_days;
        public int year, month, aday;
        int o = 0;
        int i = 1;
        int k = 1;
        int h = 1;
        int y = 1;
        int r = 1;
        int q = 1;
        UserControl1[] ucblank = new UserControl1[45];
        //var pnl = new List<Panel> { existingPanel1, existingPanel2, existingPanel3 };
        UserControl2[] ucdays = new UserControl2[45];
        public Form1()
        {
            InitializeComponent();
            //for (int i = 0; i <= DateButtonNum; i++) ButtonText = new Label[i];
           
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displays();
            label10.Text = year.ToString() ;
            label11.Text = month.ToString() ;
            label12.Text = aday.ToString() ;
            //string ButtonText[].Text = { "1","2" };

            
           
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Left_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            daycontainer.BringToFront();
            daycontainer.Controls.Clear();
            month--;

            if (month < 1)
            {
                year--;
                month = 12;
            }
            if (month > 12)
            {
                ++year;
                month = 1;
            }
            // i = 1;
             k = 1;
             h = 1;
             y = 1;
             r = 1;
             q = 1;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + "" + year;
            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            int u = dayoftheweek;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ucblank[i] = new UserControl1();
                int g = 5 + ((i - 1) * 55);
                ucblank[i].Location = new Point(g, 10);
                daycontainer.Controls.Add(ucblank[i]);



            }




            for (int j = 1; j <= days; j++)
            {

                ucdays[j] = new UserControl2();


                //if(j+ dayoftheweek == 7)
                if (j + dayoftheweek - 1 <= 7)
                {
                    ucdays[j].Location = new Point(5 + ((u - 1) * 55), 10);
                    ucdays[j].days(j);

                    daycontainer.Controls.Add(ucdays[j]);

                    u++;
                }
                if (j + dayoftheweek - 1 > 7 && j + dayoftheweek - 1 <= 14)
                {

                    if (k > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 55);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }

                    if (k == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 55);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        k++;

                    }

                }

                if (j + dayoftheweek - 1 > 14 && j + dayoftheweek - 1 <= 21)
                {
                    if (h > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 100);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }

                    if (h == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 100);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        h++;

                    }

                }
                else if (j + dayoftheweek - 1 > 21 && j + dayoftheweek - 1 <= 28)
                {
                    if (y > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 145);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }
                    if (y == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 145);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        y++;

                    }

                }
                if (j + dayoftheweek - 1 > 28 && j + dayoftheweek - 1 <= 35)
                {
                    if (r > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 190);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }
                    if (r == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 190);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        r++;

                    }

                }
                if (j + dayoftheweek - 1 > 35 && j + dayoftheweek - 1 <= 42)
                {
                    if (q > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 235);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }
                    if (q == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 235);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        q++;

                    }

                }
                // if (j + dayoftheweek == 14)
                //   ucdays[j].Location = new Point(5 + ((i - 1) * 55), 80);



                if (j  == aday && month == now.Month && year == now.Year)
                {
                    ucdays[j].BackColor = Color.DodgerBlue;

                    daycontainer.Controls.Add(ucdays[j]);
                    //daycontainer.BackColor = SystemColors.Control;

                }

                // if (j + dayoftheweek == 14)
                //   ucdays[j].Location = new Point(5 + ((i - 1) * 55), 80);



           

            }
        }

        /*
        private void Year_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var panel = (Panel)sender;
            var label = (Label)panel.Controls[0];
            int x = Int32.Parse(label10.Text);
            
            label10.Text= x > now.Year ? label10.Text : now.Year.ToString();
        }
        */

        private void Left_Leave(object sender, EventArgs e)
        {
            left_Panel.BackColor = SystemColors.Control;
        }

        private void Left_Enter(object sender, EventArgs e)
        {
            left_Panel.BackColor = Color.DodgerBlue;
        }

        private void Right_Leave(object sender, EventArgs e)
        {
            right_Panel.BackColor = SystemColors.Control;
        }

        private void Right_Enter(object sender, EventArgs e)
        {
            right_Panel.BackColor = Color.DodgerBlue;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            daycontainer.BringToFront();
            daycontainer.Controls.Clear();
            month++;

            if (month < 1)
            {
                year--;
                month = 12;
            }
            if (month > 12)
            {
                ++year;
                month = 1;
            }
            // i = 1;
            k = 1;
            h = 1;
            y = 1;
            r = 1;
            q = 1;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + "" + year;
            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            int u = dayoftheweek;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ucblank[i] = new UserControl1();
                int g = 5 + ((i - 1) * 55);
                ucblank[i].Location = new Point(g, 10);
                daycontainer.Controls.Add(ucblank[i]);



            }




            for (int j = 1; j <= days; j++)
            {

                ucdays[j] = new UserControl2();


                //if(j+ dayoftheweek == 7)
                if (j + dayoftheweek - 1 <= 7)
                {
                    ucdays[j].Location = new Point(5 + ((u - 1) * 55), 10);
                    ucdays[j].days(j);

                    daycontainer.Controls.Add(ucdays[j]);

                    u++;
                }
                if (j + dayoftheweek - 1 > 7 && j + dayoftheweek - 1 <= 14)
                {

                    if (k > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 55);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }

                    if (k == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 55);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        k++;

                    }

                }

                if (j + dayoftheweek - 1 > 14 && j + dayoftheweek - 1 <= 21)
                {
                    if (h > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 100);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }

                    if (h == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 100);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        h++;

                    }

                }
                else if (j + dayoftheweek - 1 > 21 && j + dayoftheweek - 1 <= 28)
                {
                    if (y > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 145);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }
                    if (y == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 145);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        y++;

                    }

                }
                if (j + dayoftheweek - 1 > 28 && j + dayoftheweek - 1 <= 35)
                {
                    if (r > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 190);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }
                    if (r == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 190);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        r++;

                    }

                }
                if (j + dayoftheweek - 1 > 35 && j + dayoftheweek - 1 <= 42)
                {
                    if (q > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 235);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }
                    if (q == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 235);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        q++;

                    }

                }
                // if (j + dayoftheweek == 14)
                //   ucdays[j].Location = new Point(5 + ((i - 1) * 55), 80);



                if (j  == aday && month == now.Month && year == now.Year)
                {
                    ucdays[j].BackColor = Color.DodgerBlue;

                    daycontainer.Controls.Add(ucdays[j]);
                    //daycontainer.BackColor = SystemColors.Control;

                }

                // if (j + dayoftheweek == 14)
                //   ucdays[j].Location = new Point(5 + ((i - 1) * 55), 80);





            }
        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point v = this.PointToClient(Cursor.Position);

            v = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);


            label9.Text = v.ToString();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            //daycontainer.Controls.Clear();
            //main.Controls.Clear();
            //panel3.Controls.Clear();

            DateTime now = DateTime.Now;
           
            if (o == 1)
            {
                daycontainer.Controls.Clear();
                panel4.Controls.Clear();
                main.BringToFront();
                label8.Text = "年份";
                int i = 2020;
                int s = 1;
                int x = 1;
                int k = 1;
                for (int j = 1; j <= 21; j++)
                {
                   

                    if (j <= 7)
                    {
                        
                        //int k = 1;
                        //ucdays[j] = new UserControl2();
                        //ucdays.Years(times[k] = j);

                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")

                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((j - 1) * 55), 10),
                        };
                        //int g = 5 + ((j - 1) * 55);
                        //DateButtons[j].Location = new Point(g, 10);
                        Label a1 = new Label();
                        //a1.Name = a1 + i.ToString();
                        if (j == k) a1.Text = i.ToString();
                        a1.Click += delegate (object sender1, EventArgs e1) { Label_Click_year(sender, e, a1.Text); };
                        ButtonText[j] = a1;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        main.Controls.Add(DateButtons[j]);
                        
                        ++i;
                        
                    }
                    if (j > 7 && j <= 14)
                    {
                        /*
                        ucdays[j] = new UserControl2();
                        //ucdays.Years(times[k] = j);
                        int g = 5 + ((s - 1) * 55);
                        ucdays[j].Location = new Point(g, 55);
                        ucdays[j].Years(i);
                        main.Controls.Add(ucdays[j]);
                        ++i;
                        s++;
                        */
                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((s - 1) * 55), 55),
                        };
                        //int g = 5 + ((j - 1) * 55);
                        //DateButtons[j].Location = new Point(g, 10);
                        

                        Label a1 = new Label();
                        //a1.Name = a1 + i.ToString();
                        if (j == k) a1.Text = i.ToString();
                        a1.Click += delegate (object sender1, EventArgs e1) { Label_Click_year(sender, e, a1.Text); };
                        ButtonText[j] = a1;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        main.Controls.Add(DateButtons[j]);
                        ++i;
                        ++s;
                    }
                    if (j > 14 && j <= 21)
                    {
                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((x - 1) * 55), 100),
                        };

                        Label a1 = new Label();
                        //a1.Name = a1 + i.ToString();
                        if (j == k) a1.Text = i.ToString();

                        a1.Click += delegate (object sender1, EventArgs e1) { Label_Click_year(sender, e, a1.Text); };
                        ButtonText[j] = a1;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        main.Controls.Add(DateButtons[j]);
                        ++i;
                        ++x;

                        /*
                        ucdays[j] = new UserControl2();
                        //ucdays.Years(times[k] = j);
                        int g = 5 + ((x - 1) * 55);
                        ucdays[j].Location = new Point(g, 100);
                        ucdays[j].Years(i);
                        main.Controls.Add(ucdays[j]);
                        ++i;
                        x++;
                        */
                    }
                    if (i-1== now.Year)
                    {
                       
                        DateButtons[j].BackColor = Color.DodgerBlue;

                        //daycontainer.Controls.Add(ucdays[j]);
                        //daycontainer.BackColor = SystemColors.Control;

                    }
                    k++; 
                }
               

                }
            if(o==2) label8.Text = "月";
            if (label8.Text == "月")
            {
                main.Controls.Clear();
                daycontainer.Controls.Clear();
                panel3.BringToFront();
                //label8.Text = "月";
                //int i = 1;
                int s = 1;
                int k = 1;
                //int x = 1;
                for (int j =1; j<=12;j++)
                {
                    if (j <= 7)
                    {

                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((j - 1) * 55), 10),
                        };
                        //int g = 5 + ((j - 1) * 55);
                        //DateButtons[j].Location = new Point(g, 10);


                        Label a2 = new Label();
                        //a1.Name = a1 + i.ToString();
                         a2.Text = j.ToString();

                        a2.Click += delegate (object sender1, EventArgs e1) { Label_Click_month(sender, e, a2.Text); };
                        ButtonText[j] = a2;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        
                         DateButtons[j].Controls.Add(ButtonText[j]);
                         panel3.Controls.Add(DateButtons[j]);
                        
                        /*
                        //int k = 1;
                        ucdays[j] = new UserControl2();
                        //ucdays.Years(times[k] = j);
                        int g = 5 + ((j - 1) * 55);
                        ucdays[j].Location = new Point(g, 10);
                        ucdays[j].Months(j);
                        panel3.Controls.Add(ucdays[j]);
                        */
                    }
                    if (j > 7 && j <= 14)
                    {
                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((s - 1) * 55), 55),
                        };
                        //int g = 5 + ((j - 1) * 55);
                        //DateButtons[j].Location = new Point(g, 10);
                        ButtonText[j].Text = j.ToString();
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel3.Controls.Add(DateButtons[j]);

                        ++s;
                    }
                    if (j == now.Month)
                    {
                        DateButtons[j].BackColor = Color.DodgerBlue;

                        //daycontainer.Controls.Add(ucdays[j]);
                        //daycontainer.BackColor = SystemColors.Control;

                    }
                    
                }
            }
            if (o == 3) label8.Text = "日";
            if (label8.Text == "日")
            {
                main.Controls.Clear();
                panel3.Controls.Clear();
                daycontainer.Controls.Clear();
                panel4.BringToFront();
                panel1.BringToFront();
                 
                 k = 1;
                 h = 1;
                 y = 1;
                 r = 1;
                 q = 1;
                String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                
                //DateTime now = DateTime.Now;

                DateTime startofthemonth = new DateTime(year, month, 1);

                int days = DateTime.DaysInMonth(year, month);

                int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
                int u = dayoftheweek;

                for (int i = 1; i < dayoftheweek; i++)
                {
                    ucblank[i] = new UserControl1();
                    int g = 5 + ((i - 1) * 55);
                    ucblank[i].Location = new Point(g, 10);
                    daycontainer.Controls.Add(ucblank[i]);



                }




                for (int j = 1; j <= days; j++)
                {



                    //if(j+ dayoftheweek == 7)
                    if (j + dayoftheweek - 1 <= 7)
                    {


                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 10),
                        };

                        ButtonText[j].Text = j.ToString();
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);

                        //ucdays[j].Location = new Point(5 + ((u - 1) * 55), 10);


                        u++;
                    }
                    if (j + dayoftheweek - 1 > 7 && j + dayoftheweek - 1 <= 14)
                    {

                        if (k > 1)
                        {


                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 55),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);


                            u++;
                        }

                        if (k == 1)
                        {
                            u = 1;


                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 55),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);



                            u++;
                            k++;

                        }

                    }

                    if (j + dayoftheweek - 1 > 14 && j + dayoftheweek - 1 <= 21)
                    {
                        if (h > 1)
                        {

                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 100),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);



                            u++;
                        }

                        if (h == 1)
                        {
                            u = 1;

                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 100),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);


                            u++;
                            h++;

                        }

                    }
                    else if (j + dayoftheweek - 1 > 21 && j + dayoftheweek - 1 <= 28)
                    {
                        if (y > 1)
                        {

                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 145),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);


                            u++;
                        }
                        if (y == 1)
                        {
                            u = 1;


                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 145),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);


                            u++;
                            y++;

                        }

                    }
                    if (j + dayoftheweek - 1 > 28 && j + dayoftheweek - 1 <= 35)
                    {
                        if (r > 1)
                        {


                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 190),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);




                            u++;
                        }
                        if (r == 1)
                        {
                            u = 1;


                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 190),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);

                            u++;
                            r++;

                        }

                    }
                    if (j + dayoftheweek - 1 > 35 && j + dayoftheweek - 1 <= 42)
                    {
                        if (q > 1)
                        {

                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 235),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);

                            u++;
                        }
                        if (q == 1)
                        {
                            u = 1;


                            ButtonText[j] = new Label()
                            {
                                Size = new Size(48, 20),
                                Location = new Point(6, 8),
                                Font = new Font("Arail", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                //Text = i.ToString("00")
                            };

                            DateButtons[j] = new Panel()
                            {
                                Size = new Size(50, 40),
                                BackColor = Color.White,
                                Location = new Point(5 + ((u - 1) * 55), 235),
                            };

                            ButtonText[j].Text = j.ToString();
                            DateButtons[j].Controls.Add(ButtonText[j]);
                            panel4.Controls.Add(DateButtons[j]);

                            u++;
                            q++;

                        }

                    }
                    // if (j + dayoftheweek == 14)
                    //   ucdays[j].Location = new Point(5 + ((i - 1) * 55), 80);



                    if (j == aday)
                    {
                        DateButtons[j].BackColor = Color.DodgerBlue;

                        panel4.Controls.Add(DateButtons[j]);
                        //daycontainer.BackColor = SystemColors.Control;

                    }
                }

                }
                o++;
            if (o > 3) o = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //for (var i = 0; i < DateButtons.Length; i++) { DateButtons[i].Click += Year_Click; }
        }

        private void Label_Click_year(object sender, EventArgs e,string k)
        {
            label10.Text = k;
            label8.Text = "月";
            DateTime now = DateTime.Now;
            main.Controls.Clear();
            daycontainer.Controls.Clear();
            panel3.BringToFront();
            //label8.Text = "月";
            //int i = 1;
            int s = 1;
            //int x = 1;
            for (int j = 1; j <= 12; j++)
            {
                if (j <= 7)
                {

                    ButtonText[j] = new Label()
                    {
                        Size = new Size(48, 20),
                        Location = new Point(6, 8),
                        Font = new Font("Arail", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        //Text = i.ToString("00")
                       
                };

                    DateButtons[j] = new Panel()
                    {
                        Size = new Size(50, 40),
                        BackColor = Color.White,
                        Location = new Point(5 + ((j - 1) * 55), 10),
                    };
                    //int g = 5 + ((j - 1) * 55);
                    //DateButtons[j].Location = new Point(g, 10);
                    Label a2 = new Label();
                    //a1.Name = a1 + i.ToString();
                    a2.Text = j.ToString();

                    a2.Click += delegate (object sender1, EventArgs e1) { Label_Click_month(sender, e, a2.Text); };
                    ButtonText[j] = a2;

                    ButtonText[j].Size = new Size(48, 20);
                    ButtonText[j].Location = new Point(6, 8);
                    ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                    
                    DateButtons[j].Controls.Add(ButtonText[j]);
                    panel3.Controls.Add(DateButtons[j]);
                    
                    /*
                    //int k = 1;
                    ucdays[j] = new UserControl2();
                    //ucdays.Years(times[k] = j);
                    int g = 5 + ((j - 1) * 55);
                    ucdays[j].Location = new Point(g, 10);
                    ucdays[j].Months(j);
                    panel3.Controls.Add(ucdays[j]);
                    */
                }
                if (j > 7 && j <= 14)
                {
                    ButtonText[j] = new Label()
                    {
                        Size = new Size(48, 20),
                        Location = new Point(6, 8),
                        Font = new Font("Arail", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        //Text = i.ToString("00")
                    };

                    DateButtons[j] = new Panel()
                    {
                        Size = new Size(50, 40),
                        BackColor = Color.White,
                        Location = new Point(5 + ((s - 1) * 55), 55),
                    };
                    //int g = 5 + ((j - 1) * 55);
                    //DateButtons[j].Location = new Point(g, 10);
                    Label a2 = new Label();                  
                    a2.Text = j.ToString();

                    a2.Click += delegate (object sender1, EventArgs e1) { Label_Click_month(sender, e, a2.Text); };
                    ButtonText[j] = a2;

                    ButtonText[j].Size = new Size(48, 20);
                    ButtonText[j].Location = new Point(6, 8);
                    ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                    DateButtons[j].Controls.Add(ButtonText[j]);
                    panel3.Controls.Add(DateButtons[j]);

                    ++s;
                }
                if (j == now.Month)
                {
                    DateButtons[j].BackColor = Color.DodgerBlue;

                    //daycontainer.Controls.Add(ucdays[j]);
                    //daycontainer.BackColor = SystemColors.Control;

                }
            }
        }

        private void Label_Click_month(object sender, EventArgs e, string w)
        {
            
            label11.Text = w;
            label8.Text = "日";
            main.Controls.Clear();
            panel3.Controls.Clear();
            daycontainer.Controls.Clear();
            panel4.BringToFront();
            panel1.BringToFront();
            DateTime now = DateTime.Now;
            //label8.Text = "月";
            //int i = 1;
            int s = 1;
            //int x = 1;
           year = Int32.Parse(label10.Text);
           month = Int32.Parse(label11.Text);


            k = 1;
            h = 1;
            y = 1;
            r = 1;
            q = 1;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            //DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            int u = dayoftheweek;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ucblank[i] = new UserControl1();
                int g = 5 + ((i - 1) * 55);
                ucblank[i].Location = new Point(g, 10);
                daycontainer.Controls.Add(ucblank[i]);



            }




            for (int j = 1; j <= days; j++)
            {



                //if(j+ dayoftheweek == 7)
                if (j + dayoftheweek - 1 <= 7)
                {


                    ButtonText[j] = new Label()
                    {
                        Size = new Size(48, 20),
                        Location = new Point(6, 8),
                        Font = new Font("Arail", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        //Text = i.ToString("00")
                    };

                    DateButtons[j] = new Panel()
                    {
                        Size = new Size(50, 40),
                        BackColor = Color.White,
                        Location = new Point(5 + ((u - 1) * 55), 10),
                    };

                    Label a3 = new Label();
                    a3.Text = j.ToString();

                    a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                    ButtonText[j] = a3;

                    ButtonText[j].Size = new Size(48, 20);
                    ButtonText[j].Location = new Point(6, 8);
                    ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);

                    
                    DateButtons[j].Controls.Add(ButtonText[j]);
                    panel4.Controls.Add(DateButtons[j]);

                    //ucdays[j].Location = new Point(5 + ((u - 1) * 55), 10);


                    u++;
                }
                if (j + dayoftheweek - 1 > 7 && j + dayoftheweek - 1 <= 14)
                {

                    if (k > 1)
                    {


                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 55),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);


                        u++;
                    }

                    if (k == 1)
                    {
                        u = 1;


                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 55),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);



                        u++;
                        k++;

                    }

                }

                if (j + dayoftheweek - 1 > 14 && j + dayoftheweek - 1 <= 21)
                {
                    if (h > 1)
                    {

                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 100),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);



                        u++;
                    }

                    if (h == 1)
                    {
                        u = 1;

                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 100),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);


                        u++;
                        h++;

                    }

                }
                else if (j + dayoftheweek - 1 > 21 && j + dayoftheweek - 1 <= 28)
                {
                    if (y > 1)
                    {

                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 145),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);


                        u++;
                    }
                    if (y == 1)
                    {
                        u = 1;


                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 145),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);


                        u++;
                        y++;

                    }

                }
                if (j + dayoftheweek - 1 > 28 && j + dayoftheweek - 1 <= 35)
                {
                    if (r > 1)
                    {


                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 190),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);




                        u++;
                    }
                    if (r == 1)
                    {
                        u = 1;


                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 190),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);

                        u++;
                        r++;

                    }

                }
                if (j + dayoftheweek - 1 > 35 && j + dayoftheweek - 1 <= 42)
                {
                    if (q > 1)
                    {

                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 235),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);

                        u++;
                    }
                    if (q == 1)
                    {
                        u = 1;


                        ButtonText[j] = new Label()
                        {
                            Size = new Size(48, 20),
                            Location = new Point(6, 8),
                            Font = new Font("Arail", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            //Text = i.ToString("00")
                        };

                        DateButtons[j] = new Panel()
                        {
                            Size = new Size(50, 40),
                            BackColor = Color.White,
                            Location = new Point(5 + ((u - 1) * 55), 235),
                        };

                        Label a3 = new Label();
                        a3.Text = j.ToString();

                        a3.Click += delegate (object sender1, EventArgs e1) { Label_Click_day(sender, e, a3.Text); };
                        ButtonText[j] = a3;

                        ButtonText[j].Size = new Size(48, 20);
                        ButtonText[j].Location = new Point(6, 8);
                        ButtonText[j].Font = new Font("Arail", 12, FontStyle.Regular);
                        DateButtons[j].Controls.Add(ButtonText[j]);
                        panel4.Controls.Add(DateButtons[j]);

                        u++;
                        q++;

                    }

                }
                // if (j + dayoftheweek == 14)
                //   ucdays[j].Location = new Point(5 + ((i - 1) * 55), 80);



                if (j == aday)
                {
                    DateButtons[j].BackColor = Color.DodgerBlue;

                    panel4.Controls.Add(DateButtons[j]);
                    //daycontainer.BackColor = SystemColors.Control;

                }
            }
        }


        private void Label_Click_day(object sender, EventArgs e, string p)
        {

            label12.Text = p;
            static_years = label10.Text;
            static_months = label11.Text;
            static_days = label12.Text;
            this.Enabled = false;
            Ensure_Form ensure_form = new Ensure_Form();

            
             ensure_form.FormClosed += F2_FormClosed;

             ensure_form.Show();

        }
        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
        private void displays()
        {
            
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            aday = now.Day;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + "" + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;
            int u = dayoftheweek;

            for (int i = 1; i <dayoftheweek; i++)
            {
                ucblank[i] = new UserControl1();
                int g = 5 + ((i - 1) * 55);
                ucblank[i].Location = new Point(g,10);
                daycontainer.Controls.Add(ucblank[i]);



            }
            


            
            for (int j = 1; j <= days; j++)
            {
               
                ucdays[j] = new UserControl2();


                //if(j+ dayoftheweek == 7)
                if ( j + dayoftheweek -1<= 7)
                {
                    ucdays[j].Location = new Point(5 + ((u - 1) * 55), 10);
                    ucdays[j].days(j  );

                    daycontainer.Controls.Add(ucdays[j]);

                    u++;
                }
                if (j + dayoftheweek - 1 > 7&& j + dayoftheweek - 1 <= 14)
                {
                   
                    if ( k>1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 55);
                        ucdays[j].days(j );

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }
                    
                    if(k==1)
                    {
                         u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 55);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        k++;
                       
                    }
                   
                }

                if (j + dayoftheweek - 1 > 14 && j + dayoftheweek - 1 <= 21)
                {
                    if (h > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 100);
                        ucdays[j].days(j );

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                    }

                    if (h == 1)
                    {
                        u = 1;

                        ucdays[j].Location = new Point(5 + ((u - 1) * 55), 100);
                        ucdays[j].days(j);

                        daycontainer.Controls.Add(ucdays[j]);

                        u++;
                        h++;

                    }

                }
                else if(j + dayoftheweek - 1  > 21 && j + dayoftheweek - 1 <= 28)
                {
                    if (y > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((i - 1) * 55), 145);
                        ucdays[j].days(j );

                        daycontainer.Controls.Add(ucdays[j]);

                        i++;
                    }
                    if (y == 1)
                    {
                        i = 1;

                        ucdays[j].Location = new Point(5 + ((i - 1) * 55), 145);
                        ucdays[j].days(j );

                        daycontainer.Controls.Add(ucdays[j]);

                        i++;
                        y++;

                    }

                }
                if (j + dayoftheweek - 1 > 28 && j + dayoftheweek - 1 <= 35)
                {
                    if (r > 1)
                    {
                        ucdays[j].Location = new Point(5 + ((i - 1) * 55), 190);
                        ucdays[j].days(j );

                        daycontainer.Controls.Add(ucdays[j]);

                        i++;
                    }
                    if (r == 1)
                    {
                        i = 1;

                        ucdays[j].Location = new Point(5 + ((i - 1) * 55), 190);
                        ucdays[j].days(j );

                        daycontainer.Controls.Add(ucdays[j]);

                        i++;
                        r++;

                    }

                }
                // if (j + dayoftheweek == 14)
                //   ucdays[j].Location = new Point(5 + ((i - 1) * 55), 80);



                if (j  == aday && month == now.Month && year == now.Year)
                {
                    ucdays[j].BackColor = Color.DodgerBlue;

                    daycontainer.Controls.Add(ucdays[j]);
                    //daycontainer.BackColor = SystemColors.Control;

                }
           
            }
            
        }


    }
}