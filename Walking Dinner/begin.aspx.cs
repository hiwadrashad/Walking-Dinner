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
        public static int test = 0;
        public static List<List<string>> parallellist1 = new List<List<string>>();
        public static List<List<string>> list1 = new List<List<string>>();
        static public bool checkparallel = false;
        static public int parallelgroepnummer = 1;
        static public int groepnummer = 1;
        static public Random rnd = new Random();
        static public int randomnumber = rnd.Next(2, 5);
        static public int randomparallelnumber = rnd.Next(4, 9);
        static public int currentnumber = 0;
        static public int currentparallelnumber = 0;
        static public SortedDictionary<int, string> showlist = new SortedDictionary<int, string>();
        static public bool currentparallelornot = false;

        static public string currentgastheer;
        static public string currentparallelgastheer;
        static public List<List<string>> groepenaanwezigepersonen = new List<List<string>>();
        static public List<List<string>> groepenaanwezigepersonenparallel = new List<List<string>>();
        static public List<string> gastheergroepgeweest = new List<string>();
        static public List<string> gastheerparallelgroepgweest = new List<string>();
        public static bool limitbereikt = false;
        public static bool limitbereiktparallel = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            CheckBox1.Checked = false;
            checkparallel = false;
            ListBox1.Items.Clear();
            for (int index = 0; index < showlist.Count; index++)
            {
                ListBox1.Items.Add(showlist[index]);
            }

            
        } 


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (checkparallel == true)
            {
                currentparallelornot = true;

                if (!(currentparallelnumber > randomparallelnumber))
                {
                    currentparallelnumber = currentparallelnumber + 1;
                    ListItem itemparallel = ListBox1.Items.FindByValue("parallele groep " + parallelgroepnummer);
                    if ((itemparallel == null))
                    {

                        //parallelgroepen.Add(parallelgroepnummer, "test");
                        ListBox1.Items.Add("parallele groep " + parallelgroepnummer);
                    }
                    else
                    { 
                    }
                }
                else
                {
                    //sizegroupparallel.Add();
                    limitbereiktparallel = true;
                    currentparallelnumber = 0;
                    parallelgroepnummer = parallelgroepnummer + 1;
                    randomparallelnumber = rnd.Next(4, 9);
                    ListBox1.Items.Add("parallele groep " + parallelgroepnummer);
                }
                
            }
            else
            {
                currentparallelornot = false;
                if (!(currentnumber > randomnumber))
                {
                    currentnumber = currentnumber + 1;
                    ListItem item = ListBox1.Items.FindByValue("groep " + groepnummer);
                    if ((item == null))
                    {
                        ListBox1.Items.Add("groep " + groepnummer);
                    }
                    else
                    {
                    }
                }
                else
                {
                    limitbereikt = true;
                    currentnumber = 0;
                    groepnummer = groepnummer + 1;
                    randomnumber = rnd.Next(2, 5);
                    ListBox1.Items.Add("groep " + groepnummer);
                }
            }
            showlist.Clear();
            for (int index = 0; index < ListBox1.Items.Count; index++)
            {
                showlist.Add(index, ListBox1.Items[index].ToString());
            }
            Response.Redirect("toevoegen.aspx", false);
            

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