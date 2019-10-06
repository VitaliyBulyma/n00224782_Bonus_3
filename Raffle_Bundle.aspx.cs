using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raffle_Bundle
{
    public partial class Raffle_Bundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    int User_Input = Convert.ToInt32(user_input.Text);
                    bundles_summary.InnerHtml = "";
                    if (User_Input < 51) //0-50 Tickets, bundled Individually
                    {
                        double Total_cost = ((User_Input) * (0.25));
                            bundles_summary.InnerHtml += "Number of ticket(s) ordered: " + User_Input + "<br>";
                        for (int i=1; i < 51; i++)
                        {
                            bundles_summary.InnerHtml += "You received a bundle of 1! That's "+i+" tickets"+"<br>";
                        }
                            bundles_summary.InnerHtml += "Your total ticket(s) is " + User_Input + " and your cost is $ "+Total_cost+"cad"+"<br>";
                    }//end of 0-50
                    
                    
                    if (User_Input >50&&User_Input<151)//51 to 150 tickets, bundled in sets of 2
                    {
                        double Total_cost = ((User_Input) * (0.25));
                            bundles_summary.InnerHtml += "Number of ticket(s) ordered: " + User_Input + "<br>";
                        //checking if the are any "leftovers" using modulus
                        if (User_Input % 2 == 0) 
                        { 
                        for (int count = 2; count < User_Input+2; count=count+2)
                        {
                            bundles_summary.InnerHtml += "You received a bundle of 2! That's " + count + " tickets!" + "<br>";
                        }
                        }
                        else //if there are "leftovers" (User_Input % 2 != 0), running regular count, printing the remainder
                        {
                            for (int count = 2; count < User_Input; count = count + 2)
                            {
                                bundles_summary.InnerHtml += "You received a bundle of 2! That's " + count + " tickets!" + "<br>";
                            }
                            int Remainder_mod2 = User_Input % 2;
                            bundles_summary.InnerHtml += "Your leftover is " + Remainder_mod2 + " ticket(s). Thats " + User_Input+" ticket(s)!"+"<br>";
                        }
                        bundles_summary.InnerHtml += "Your total ticket(s) is " + User_Input + " and your cost is $ " + Total_cost + "cad!" + "<br>";
                    }//end of 50-150
                    
                    
                    if (User_Input > 150 && User_Input < 301)//150 to 300 tickets, bundled in sets of 3
                    {
                        double Total_cost = ((User_Input) * (0.25));
                            bundles_summary.InnerHtml += "Number of ticket(s) ordered: " + User_Input + "<br>";
                        if (User_Input % 3 == 0)
                            for (int count = 3; count < User_Input+3; count = count + 3)
                        {
                            bundles_summary.InnerHtml += "You received a bundle of 3! That's " + count + " ticket(s)!" + "<br>";
                        }
                        else 
                        {
                            for (int count = 3; count < User_Input; count = count + 3)
                            {
                                bundles_summary.InnerHtml += "You received a bundle of 3! That's " + count + " ticket(s)!" + "<br>";
                            }
                            int Remainder_mod3 = User_Input % 3;//checking if the are any "leftovers" using modulus
                            bundles_summary.InnerHtml += "Your leftover is " + Remainder_mod3 + " ticket(s). Thats " + User_Input + " ticket(s)!" + "<br>";
                        }
                        bundles_summary.InnerHtml += "Your total ticket(s) is " + User_Input + " and your cost is $ " + Total_cost + "cad!" + "<br>";
                    }//end of 150 - 300
                    
                    
                    if (User_Input > 300)//more then 300 tickets, bundled by 5
                    {
                        double Total_cost = ((User_Input) * (0.25));
                            bundles_summary.InnerHtml += "Number of ticket(s) ordered: " + User_Input + "<br>";
                        if (User_Input % 5 == 0)
                            for (int count = 5; count < User_Input+5; count = count + 5)
                        {
                            bundles_summary.InnerHtml += "You received a bundle of 5! That's " + count + " tickets" + "<br>";
                        }
                        else 
                        {
                            for (int count = 5; count < User_Input; count = count + 5)
                            {
                                bundles_summary.InnerHtml += "You received a bundle of 5! That's " + count + " tickets" + "<br>";
                            }
                            int Remainder_mod5 = User_Input % 5;//checking if the are any "leftovers" using modulus
                            bundles_summary.InnerHtml += "Your leftover is " + Remainder_mod5 + " ticket(s). Thats " + User_Input + " ticket(s)!" + "<br>";
                        }
                        bundles_summary.InnerHtml += "Your total ticket(s) is " + User_Input + " and your cost is $ " + Total_cost + "cad!" + "<br>";
                    }//end off 300+



                }
            }
        }
    }
}