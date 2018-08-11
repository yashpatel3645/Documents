using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void btnopen_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\WebSites\test\App_Data\Database.mdf;Integrated Security=True");
        con.Open();
        SqlCommand sc = new SqlCommand("select enrollment,password from registraion where password='"+pass.Text+"'",con);
       // sc.ExecuteNonQuery();
        SqlDataReader dr = sc.ExecuteReader();
        while(dr.Read())
        {
            if(dr["password"].ToString()==pass.Text)
            {
                Response.Redirect("Front.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message", "<script language=javascript>alert('Enrollment or Password is not match.');</script>");
            }
        }
    }
}