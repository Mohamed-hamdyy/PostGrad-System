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
    public partial class StudentThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["DBConnect"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = (int)Session["id"];
            SqlCommand viewStudentThesis = new SqlCommand("ViewStudentThesis", conn);
            viewStudentThesis.CommandType = CommandType.StoredProcedure;
            viewStudentThesis.Parameters.Add(new SqlParameter("@id", id));



            TableRow R1 = new TableRow();
            TableCell C1 = new TableCell();
            C1.Text = "Serial Number";
            R1.Controls.Add(C1);

            TableCell C2 = new TableCell();
            C2.Text = "field ";
            R1.Controls.Add(C2);

            TableCell C3 = new TableCell();
            C1.Text = "type ";
            R1.Controls.Add(C3);

            TableCell C4 = new TableCell();
            C2.Text = "title ";
            R1.Controls.Add(C4);

            TableCell C5 = new TableCell();
            C2.Text = "start date";
            R1.Controls.Add(C5);

            TableCell C6 = new TableCell();
            C2.Text = "end date ";
            R1.Controls.Add(C6);

            TableCell C7 = new TableCell();
            C2.Text = "defense date";
            R1.Controls.Add(C7);

            TableCell C8 = new TableCell();
            C2.Text = "years";
            R1.Controls.Add(C8);

            TableCell C9 = new TableCell();
            C2.Text = "grade";
            R1.Controls.Add(C9);

            TableCell C10 = new TableCell();
            C2.Text = "payment ID";
            R1.Controls.Add(C10);

            TableCell C11 = new TableCell();
            C2.Text = "no of ext.";
            R1.Controls.Add(C11);

            Table1.Controls.Add(R1);


            conn.Open();
            
            SqlDataReader rdr = viewStudentThesis.ExecuteReader(CommandBehavior.CloseConnection);
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