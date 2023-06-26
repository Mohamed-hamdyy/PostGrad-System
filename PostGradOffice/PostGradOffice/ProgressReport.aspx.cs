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
    public partial class ProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            TextBox3.Visible = true;


            string connStr = WebConfigurationManager.ConnectionStrings["DBConnect"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            int id = (int)Session["id"];
            int reportNo = Int16.Parse(TextBox3.Text);
            DateTime repdate = Current_TimeStamp();
            int serialInt;

            SqlCommand getserial = new SqlCommand("getSerial", conn);
            getserial.CommandType = CommandType.StoredProcedure;
            getserial.Parameters.Add(new SqlParameter("@id", id));
            SqlParameter c = getserial.Parameters.Add(new SqlParameter("@serial", SqlDbType.Int));
            c.Direction = ParameterDirection.Output;

            conn.Open();
            getserial.ExecuteNonQuery();
            conn.Close();



            if (c.Value.ToString() == null)
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage",
                       "alert('you are currently not registered on a thesis')", true);
            else
            {

                serialInt = Int16.Parse(c.Value.ToString());

                SqlCommand addprog = new SqlCommand("AddProgressReport", conn);
                addprog.CommandType = CommandType.StoredProcedure;
                addprog.Parameters.Add(new SqlParameter("@thesisSerialNo", serialInt));
                addprog.Parameters.Add(new SqlParameter("@progressReportDate", repdate));
                addprog.Parameters.Add(new SqlParameter("@studentID", id));
                addprog.Parameters.Add(new SqlParameter("@progressReportNo", reportNo));

                conn.Open();
                addprog.ExecuteNonQuery();
                conn.Close();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage",
                   "alert( 'Successfully added a report')", true);


                           




            }

        }

        private DateTime Current_TimeStamp()
        {
            throw new NotImplementedException();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            TextBox3.Visible = true;


            string connStr = WebConfigurationManager.ConnectionStrings["DBConnect"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            int id = (int)Session["id"];
            int reportNo = Int16.Parse(TextBox3.Text);
            int state = Int16.Parse(TextBox1.Text);
            string description = TextBox2.Text;
            int serialInt;

            SqlCommand getserial = new SqlCommand("getSerial", conn);
            getserial.CommandType = CommandType.StoredProcedure;
            getserial.Parameters.Add(new SqlParameter("@id", id));
            SqlParameter c = getserial.Parameters.Add(new SqlParameter("@serial", SqlDbType.Int));
            c.Direction = ParameterDirection.Output;

            conn.Open();
            getserial.ExecuteNonQuery();
            conn.Close();





            if (c.Value.ToString() == null)
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage",
                       "alert('you are currently not registered on a thesis')", true);
            else
            {




                serialInt = Int16.Parse(c.Value.ToString());


                SqlCommand addprog = new SqlCommand("FillProgressReport", conn);
                addprog.CommandType = CommandType.StoredProcedure;
                addprog.Parameters.Add(new SqlParameter("@thesisSerialNo", serialInt));
                addprog.Parameters.Add(new SqlParameter("@state", state));
                addprog.Parameters.Add(new SqlParameter("@studentID", id));
                addprog.Parameters.Add(new SqlParameter("@progressReportNo", reportNo));
                addprog.Parameters.Add(new SqlParameter("@description", description));

                conn.Open();
                addprog.ExecuteNonQuery();
                conn.Close();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage",
                   "alert( 'Successfully filled a report')", true);


            }
        }
    }
}