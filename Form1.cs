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
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load_1(object sender, EventArgs e)
      {
         displayDays();
      }

      private void displayDays()
      {
         DateTime now = DateTime.Now;

         // get the first day of the month
         DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);

         // get the count of the days of the month
         int days = DateTime.DaysInMonth(now.Year, now.Month);

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
   }
}
