using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public static class MessageBox
{
    public static void Show(this Page Page, String Message)
    {
        Page.ClientScript.RegisterStartupScript(
           Page.GetType(),
           "MessageBox",
           "<script language='javascript'>alert('" + Message + "');</script>"
        );
    }
}

public partial class Student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string inputEmail = TextBox1.Text;
        string inputPass = TextBox2.Text;

        string query1 = "select s.fName from UserAccounts u, Student s where u.accountId = s.accountId AND u.email ='" + inputEmail +"' AND u.pass = '" + inputPass +"'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader = cm.ExecuteReader();
        if (reader.HasRows)
        {
            MessageBox.Show(Page, "Successfully Logged in");
            Response.Redirect("studentview.aspx");
        }
        else
        {
            MessageBox.Show(Page, "Login details wrong, enter again");
            Response.Redirect("Student.aspx");
        }
        reader.Close();

        cm.Dispose();
        conn.Close();

    }
}