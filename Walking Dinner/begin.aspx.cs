using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Walking_Dinner
{

    public  partial class _Default : Page
    {
        
        static bool checkparallel = false;
        static SortedDictionary<int, string> parallelgroepen = new SortedDictionary<int, string>();
        static SortedDictionary<int, string> groepen = new SortedDictionary<int, string>();
        static int parallelgroepnummer = 0;
        static int groepnummer = 0;
        static Random rnd = new Random();
        int randomnumber = rnd.Next(2, 5);
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBox1.Checked = false;
            checkparallel = false;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (checkparallel == true)
            {
                
                {
                    parallelgroepen.Add(parallelgroepnummer, "test");
                    parallelgroepnummer = parallelgroepnummer + 1;
                    ListBox1.Items.Add("parallele groep " + parallelgroepnummer);
                }
                
            }
            else
            {
                groepen.Add(groepnummer, "test");
                groepnummer = groepnummer + 1;
                ListBox1.Items.Add("groep " + groepnummer);
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkparallel == false)
            {
                checkparallel = true;
            }
            else
            {
                checkparallel = false;
            }
        }
    }
}