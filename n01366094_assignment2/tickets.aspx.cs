using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01366094_assignment2
{
    public partial class tickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    int TicketNum = Convert.ToInt32(ticketNum.Text);
                    int i;
                    int remainder;
                    int quotient;
                    double totalCost = TicketNum * 0.25;
                    if (TicketNum <= 50)
                    {
                        for (i = 1; i <= TicketNum; i++)
                        {

                            displayResult.InnerHtml += "You received a bundle of 1! That is " + i + " ticket(s)<br>";
                        }
                    }

                    else if (TicketNum >= 51 && TicketNum <= 150)
                    {
                        quotient = TicketNum / 2;
                        remainder = TicketNum % 2;
                        if (remainder > 0)
                        {

                            for (i = 1; i <= quotient; i++)
                            {
                                displayResult.InnerHtml += "You received a bundle of 2! That’s " + 2 * i + "ticket(s)!<br>";

                            }
                            displayResult.InnerHtml += "Your leftover is " + remainder + "ticket(s).That’s " + TicketNum + "ticket(s)!<br>";

                        }
                        else
                        {
                            for (i = 1; i <= quotient; i++)
                            {

                                displayResult.InnerHtml += "You received a bundle of 2! That is " + 2 * i + " ticket(s)<br>";
                            }
                        }
                    }

                    //------------------------

                    else if (TicketNum >= 151 && TicketNum <= 300)
                    {
                        quotient = TicketNum / 3;
                        remainder = TicketNum % 3;
                        if (remainder > 0)
                        {

                            for (i = 1; i <= quotient; i++)
                            {
                                displayResult.InnerHtml += "You received a bundle of 3! That’s " + 3 * i + "ticket(s)!<br>";

                            }
                            displayResult.InnerHtml += "Your leftover is " + remainder + "ticket(s).That’s " + TicketNum + "ticket(s)!<br>";

                        }
                        else
                        {
                            for (i = 1; i <= quotient; i++)
                            {

                                displayResult.InnerHtml += "You received a bundle of 3! That is " + 3 * i + " ticket(s)<br>";
                            }
                        }
                    }

                    //-------------------------
                    else if (TicketNum >= 301)
                    {
                        quotient = TicketNum / 5;
                        remainder = TicketNum % 5;
                        if (remainder > 0)
                        {

                            for (i = 1; i <= quotient; i++)
                            {
                                displayResult.InnerHtml += "You received a bundle of 5! That’s " + 5 * i + "ticket(s)!<br>";

                            }
                            displayResult.InnerHtml += "Your leftover is " + remainder + "ticket(s).That’s " + TicketNum + "ticket(s)!<br>";

                        }
                        else
                        {
                            for (i = 1; i <= quotient; i++)
                            {

                                displayResult.InnerHtml += "You received a bundle of 5! That is " + 5 * i + " ticket(s)<br>";
                            }
                        }
                    }

                    displayResult.InnerHtml += "Your total ticket(s) is " + TicketNum + "and your cost is $" + totalCost + "cad.";




                }
            }
        }
    }
}