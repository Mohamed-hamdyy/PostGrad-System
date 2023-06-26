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
    public partial class Publication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void Button1_Click(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["DBConnect"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int serialInt;
            int Pubid;
            int c=0;
            int id = (int)Session["id"];
            string title = TextBox1.Text;
            DateTime date = Convert.ToDateTime(TextBox2.Text);
            string host = TextBox3.Text;
            string place = TextBox4.Text;
            string acc =  TextBox5.Text;

            SqlCommand getid = new SqlCommand("select @count=Count(*)  from Publication", conn);
            getid.Parameters.Add(new SqlParameter("@count", c));

            conn.Open();
            getid.ExecuteNonQuery();
            conn.Close();

            Pubid=c+1;

            SqlCommand addpub = new SqlCommand("addPublication", conn);
            addpub.CommandType = CommandType.StoredProcedure;
            addpub.Parameters.Add(new SqlParameter("@title", title));
            addpub.Parameters.Add(new SqlParameter(" @pubDate", date));
            addpub.Parameters.Add(new SqlParameter("@host", host));
            addpub.Parameters.Add(new SqlParameter("@place", place));
            addpub.Parameters.Add(new SqlParameter("@accepted ", acc));

            conn.Open();
            addpub.ExecuteNonQuery();
            conn.Close();

           ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage","alert('publication added')", true);


            SqlCommand getserial = new SqlCommand("getSerial", conn);
            getserial.CommandType = CommandType.StoredProcedure;
            getserial.Parameters.Add(new SqlParameter("@id", id));
            SqlParameter d = getserial.Parameters.Add(new SqlParameter("@serial", SqlDbType.Int));
            d.Direction = ParameterDirection.Output;

            conn.Open();
            getserial.ExecuteNonQuery();
            conn.Close();



            serialInt = Int16.Parse(d.Value.ToString());

            SqlCommand linkpub = new SqlCommand("linkPubThesis", conn);
             linkpub.CommandType = CommandType.StoredProcedure;
             linkpub.Parameters.Add(new SqlParameter("@PubID",Pubid));
             linkpub.Parameters.Add(new SqlParameter("@ThesisSerialNo",serialInt));

             conn.Open();
             linkpub.ExecuteNonQuery();
             conn.Close();

             



        }
    }
}