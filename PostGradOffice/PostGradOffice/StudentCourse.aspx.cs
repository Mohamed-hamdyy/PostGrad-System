using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradOffice
{
    public partial class StudentCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["DBConnect"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = (int)Session["id"];
            SqlCommand viewStudentCourse = new SqlCommand("ViewStudentCourse", conn);
            viewStudentCourse.CommandType = CommandType.StoredProcedure;
            viewStudentCourse.Parameters.Add(new SqlParameter("@id", id));


            TableRow R1 = new TableRow();
            TableCell C1 = new TableCell();
            C1.Text = "Course name ";
            R1.Controls.Add(C1);
            TableCell C2 = new TableCell();
            C2.Text = "Course grade ";
            R1.Controls.Add(C2);
            Table1.Controls.Add(R1);

            conn.Open();
            
            SqlDataReader rdr = viewStudentCourse.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int m = rdr.FieldCount;
                TableRow R = new TableRow();
                for (int i = 0; i < m; i++)
                {

                    string data = (rdr.GetValue(i)).ToString();
                    TableCell C = new TableCell();
                    if (data != null)
                        C.Text = data;
                    else
                        C.Text = "no value yet";
                    R.Controls.Add(C);
                }
                Table1.Controls.Add(R);
            } 
        }
    }
}