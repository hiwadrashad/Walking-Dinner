using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;

namespace Walking_Dinner
{
    
    public partial class About : Page
    {
    

            bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (IsValidEmail(TextBox7.Text) == true)
            {


                if (_Default.currentparallelornot == false)
                {

                    var groupnumber = _Default.groepenaanwezigepersonen.Count;
                    List<string> liststorage = _Default.groepenaanwezigepersonen[groupnumber];
                    List<string> alteredstoragelist = new List<string>();
                    List<string> clonedlist = new List<string>();
                    List<int> groupsinwhichduoattends = new List<int>();

                    _Default.list1.Add((new List<string>() { TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text }) );
                    if (_Default.groepenaanwezigepersonen.Count == 1 && _Default.limitbereikt == false)
                    {
                        List<string> currentpersons = _Default.groepenaanwezigepersonen[0];
                        currentpersons.Add( TextBox7.Text);
                        currentpersons.Add(TextBox15.Text);
                        _Default.groepenaanwezigepersonen[0] = currentpersons;
                    }
                    else
                    {
                        

                        if (_Default.limitbereikt == false)
                        {
                           
                            for (int index = 0; index < liststorage.Count; index++)
                            {
                                clonedlist.Add((liststorage[index].Clone()).ToString());
                                alteredstoragelist.Add((liststorage[index].Clone()).ToString());
                            }


                            alteredstoragelist.Remove(TextBox7.Text);
                            alteredstoragelist.Remove(TextBox15.Text);

                            int i = 0;
                            foreach (var item in _Default.groepenaanwezigepersonen)
                            {
                                
                                if (item.Contains(TextBox7.Text))
                                { groupsinwhichduoattends.Add(i); }
                                i++;
                                    
                            }

                            for (int index = 0; index < _Default.groepenaanwezigepersonen.Count; index++)
                            {
                                if (_Default.groepenaanwezigepersonen[groupsinwhichduoattends[index]].Any(x => alteredstoragelist.Any(y => y == x)))
                                {
                                    _Default.groepenaanwezigepersonen.Add(new List<string> { TextBox7.Text, TextBox15.Text });
                                }
                                else
                                {  
                                    clonedlist.Add(TextBox7.Text);
                                    clonedlist.Add(TextBox15.Text);
                                    _Default.groepenaanwezigepersonen[groupnumber] = clonedlist;
                                }
                            }
                            groupsinwhichduoattends.Clear();
                        }
                        else
                        {
                            _Default.groepenaanwezigepersonen.Add(new List<string> { TextBox7.Text, TextBox15.Text });
                        }
                        List<string> liststorageupdated = _Default.groepenaanwezigepersonen[groupnumber];
                        List<string> listpeoplewhichareeligable = new List<string>();

                        for (int index = 0; index < liststorageupdated.Count; index++)
                        {
                 
                        }


                    }
                }
                else
                {

                    _Default.parallellist1.Add( (new List<string>() { TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text }) );

                }
                TextBox4.Text = _Default.list1[_Default.test][0];
                _Default.limitbereikt = false;
                _Default.limitbereiktparallel = false;
                _Default.test++;
                
                //Response.Redirect("begin.aspx", false);
            }
            else
            {
                Response.Write("<script>alert('Vul een geldige e-mailadress in.')</script>");
            }
        }
    }
}