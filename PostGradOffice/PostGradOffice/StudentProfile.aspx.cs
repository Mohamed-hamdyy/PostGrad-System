using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PostGradOffice
{
    public partial class StudentProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["DBConnect"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = (int)Session["id"];

            SqlCommand viewprofile = new SqlCommand("viewMyProfile", conn);
            viewprofile.CommandType = CommandType.StoredProcedure;
            viewprofile.Parameters.Add(new SqlParameter("@studentId", id));

            conn.Open();

     
            SqlDataReader rdr = viewprofile.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int m = rdr.FieldCount;
                for (int i = 0; i < m; i++)
                {

                    string data =(rdr.GetValue(i)).ToString();
                    Label name = new Label();
                    name.Text = data + "<br>";
                    form1.Controls.Add(name);
                }
            }












        }
    }
}