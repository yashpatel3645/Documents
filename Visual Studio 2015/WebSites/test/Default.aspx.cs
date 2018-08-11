using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void btnsub_Click(object sender, EventArgs e)

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\WebSites\test\App_Data\Database.mdf;Integrated Security=True");
        con.Open();
        SqlCommand sc = new SqlCommand("insert into registraion(name,birthdate,enrollment,email,field,semester,address,contect,password,repassword)values('" + txtname.Text + "','" + birth.Text + "','" + enroll.Text + "','" + email.Text + "','" + field.Text + "','" + sem.Text + "','" + add.Text + "','" + contect.Text + "','" + pass.Text + "','" + pass2.Text + "')", con);
        sc.ExecuteNonQuery();
        
        Page.ClientScript.RegisterStartupScript(Page.GetType(),"MeassageBox","<script language=javascript>alert('Registraion Succesfully.');</script>" );
        
        Response.Redirect("Login.aspx");
        
    }
}