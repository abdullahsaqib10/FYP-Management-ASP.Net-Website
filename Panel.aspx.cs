using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public static class MessageBoxPanel
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



public partial class Panel : System.Web.UI.Page
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

        string query1 = "select userRole from UserAccounts where email ='" + inputEmail + "' AND pass = '" + inputPass + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader = cm.ExecuteReader();

        if (reader.HasRows)
        {
            string retRole = "";
            while (reader.Read())
            {
                retRole = reader.GetString(0);
            }

            if (retRole == "panel")
            {
                MessageBoxPanel.Show(Page, "Successfully Logged in");
                Response.Redirect("panelform.aspx");
            }
            else
            {
                MessageBoxPanel.Show(Page, "Login details wrong, enter again");
                Response.Redirect("Panel.aspx");
            }
        }
        else
        {
            MessageBoxPanel.Show(Page, "Login details wrong, enter again");
            Response.Redirect("Panel.aspx");
        }

        
        reader.Close();

        cm.Dispose();
        conn.Close();
    }
}