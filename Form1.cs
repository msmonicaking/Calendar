using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
   public partial class Form1 : Form
   {
      DateTime date;
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load_1(object sender, EventArgs e)
      {
         // start on todays date
         date = DateTime.Now;

         displayDays();
      }

      private void displayDays()
      {
         String monthName = date.ToString("MMMM");
         String yearName = date.ToString("yyyy");
         LBDATE.Text = monthName + " " + yearName;

         // get the first day of the month
         DateTime startofthemonth = new DateTime(date.Year, date.Month, 1);

         // get the count of the days of the month
         int days = DateTime.DaysInMonth(date.Year, date.Month);

         // convert startofthemonth
         int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

         // create blank usercontrol
         for (int i = 1; i < dayoftheweek; i++)
         {
            UserControlBlank ucblank = new UserControlBlank();
            daycontainer.Controls.Add(ucblank);
         }

         // create usercontrol for days
         for (int i = 1; i <= days; i ++)
         {
            UserControlDays ucDays = new UserControlDays();
            ucDays.days(i);
            daycontainer.Controls.Add(ucDays);
         }
      }

      private void buttonnext_Click(object sender, EventArgs e)
      {
         // clear containers
         daycontainer.Controls.Clear();

         // increment month
         date = date.AddMonths(1);

         displayDays();
      }

      private void buttonprevious_Click(object sender, EventArgs e)
      {
         // clear containers
         daycontainer.Controls.Clear();

         // increment month
         date = date.AddMonths(-1);

         displayDays();
      }
   }
}
