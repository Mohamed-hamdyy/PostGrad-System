using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradOffice
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  if ((bool)Session["gucian"] == true)
            {
                Button3.Visible = false;
                Label3.Visible = false;

            }
         */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentThesis.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentCourse.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProgressReport.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Publication.aspx");
        }
    }
}