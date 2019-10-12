using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01366094_assignment2
{
    public partial class coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    decimal xValue = Convert.ToDecimal(xInput.Text);
                    decimal yValue = Convert.ToDecimal(yInput.Text);

                    if (xValue > 0 && yValue > 0)
                    {
                        displayResult.InnerHtml = "Coordinate is in 1st quadrant <br>";
                    }
                    else if (xValue < 0 && yValue > 0)
                    {
                        displayResult.InnerHtml = "Coordinate is in 2nd quadrant <br>";
                    }
                    else if (xValue < 0 && yValue < 0)
                    {
                        displayResult.InnerHtml = "Coordinate is in 3rd quadrant <br>";
                    }
                    else if (xValue > 0 && yValue < 0)
                    {
                        displayResult.InnerHtml = "Coordinate is in 4th quadrant <br>";
                    }
                }
            }
        }
    }
}