using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class committee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox15_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox11_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox12_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox13_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox14_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox16_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ButtonUser(object sender, EventArgs e) //dont mess with it
    {

    }


    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Button3_Click1(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        //User Account
        string accId = TextBox1.Text;
        string userName = TextBox2.Text;
        string email = TextBox3.Text;
        string pass = TextBox4.Text;
        string role = TextBox9.Text;

        //Student details
        string stdId = TextBox5.Text;
        string fName = TextBox6.Text;
        string lName = TextBox7.Text;
        string groupId = TextBox8.Text;

        string query1 = "Insert Into UserAccounts(accountId, email, pass, userName, userRole) values ('" + accId + "', '" + email + "', '" + pass + "', '" + userName + "','" + role + "')";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        string query2 = "Insert Into Student(StdId, fName, lName, groupId, accountId) values ('" + stdId + "', '" + fName + "', '" + lName + "', '" + groupId + "','" + accId + "')";
        cm = new SqlCommand(query2, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        conn.Close();


    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        //User Account
        string accId = TextBox1.Text;
        string userName = TextBox2.Text;
        string email = TextBox3.Text;
        string pass = TextBox4.Text;
        string role = TextBox9.Text;

        //Faculty details
        string facId = TextBox15.Text;
        string fName = TextBox10.Text;
        string lName = TextBox11.Text;
        string hDate = TextBox12.Text;
        string sal = TextBox13.Text;
        string commId = string.IsNullOrEmpty(TextBox14.Text) ? string.Empty : TextBox14.Text; ;
        string panelId = string.IsNullOrEmpty(TextBox16.Text) ? string.Empty : TextBox16.Text; ;
        string supId = string.IsNullOrEmpty(TextBox26.Text) ? string.Empty : TextBox26.Text; ;

        string currCommIdForSup = "1";

        string query1 = "Insert Into UserAccounts(accountId, email, pass, userName, userRole) values ('" + accId + "', '" + email + "', '" + pass + "', '" + userName + "','" + role + "')";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();


        string query2;
        bool supervisorCheck = false;
        if (commId != "") //Committee member
        {
            query2 = "Insert Into Faculty(facId, fName, lName, hireDate, salary, committeeId, accountId) values ('" + facId + "', '" + fName + "', '" + lName + "', '" + hDate + "','" + sal + "','" + commId + "','" + accId + "')";
        }
        else if (panelId != "") //Panel member
        {
            query2 = "Insert Into Faculty(facId, fName, lName, hireDate, salary, panelId, accountId) values ('" + facId + "', '" + fName + "', '" + lName + "', '" + hDate + "','" + sal + "','" + panelId + "','" + accId + "')";
        }
        else //supervisor
        {
            supervisorCheck = true;
            query2 = "Insert Into Faculty(facId, fName, lName, hireDate, salary, accountId) values ('" + facId + "', '" + fName + "', '" + lName + "', '" + hDate + "','" + sal + "','" + accId + "')";
        }
            
        cm = new SqlCommand(query2, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();


        if (supervisorCheck == true)
        {
            string query3 = "Insert Into Supervisor(supervisorId, committeeId, facId) values ('" + supId + "', '" + currCommIdForSup + "', '" + facId + "')";
            cm = new SqlCommand(query3, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        conn.Close();

    }

    protected void TextBox17_TextChanged(object sender, EventArgs e)   // date textbox
    {

    }

    protected void Button1_Click(object sender, EventArgs e)      // log out button
    {
        Response.Redirect("Project_DB.aspx");
    }

    protected void TextBox18_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string supId = TextBox18.Text;

        string query1 = "select p.groupId, p.groupName from Supervisor s, ProjGroup p where s.supervisorId = p.supervisorId AND s.supervisorId = '" + supId + "';";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView1.DataSource = reader1;
        GridView1.DataBind();

        reader1.Close();

        string query2 = "select count(*) 'Number of groups assigned' from Supervisor s, ProjGroup p where s.supervisorId = p.supervisorId AND s.supervisorId = '" + supId + "';";
        cm = new SqlCommand(query2, conn);

        SqlDataReader reader2 = cm.ExecuteReader();

        GridView2.DataSource = reader2;
        GridView2.DataBind();

        conn.Close();

    }

    protected void TextBox19_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox20_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string groupId = TextBox19.Text;
        string newSup = TextBox20.Text;

        string query1 = "update ProjGroup set supervisorId = '" + newSup + "' where groupId = '" + groupId + "'";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        conn.Close();
    }

    protected void TextBox21_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string stdId = TextBox21.Text;

        string query1 = "select st.stdId 'Student group Ids', st.fName 'Student group members first name', st.lName 'Student group members last name' from Student s, Student st where s.StdId = '" + stdId + "' AND s.groupId = st.groupId";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView3.DataSource = reader1;
        GridView3.DataBind();

        reader1.Close();

        string query2 = "select sr.supervisorId, f.fName from Student s, ProjGroup p, Supervisor sr, Faculty f where s.groupId = p.groupId AND p.supervisorId = sr.supervisorId AND f.facId = sr.facId AND s.StdId = '" + stdId + "'";
        cm = new SqlCommand(query2, conn);

        SqlDataReader reader2 = cm.ExecuteReader();

        GridView4.DataSource = reader2;
        GridView4.DataBind();

        reader2.Close();




        conn.Close();
    }

    protected void TextBox22_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox23_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string panelId = TextBox22.Text;
        string panelName = TextBox23.Text;
        string groupId = TextBox27.Text;
        string committee = "1";

        string query1 = "Insert Into Panel(panelId, panelName, committeeId) values ('" + panelId + "', '" + panelName + "', '" + committee + "')";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        string query2 = "update ProjGroup set panelId = '" + panelId + "' where groupId = '" + groupId + "'";
        cm = new SqlCommand(query2, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        conn.Close();

    }

    protected void TextBox24_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox25_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string facId = TextBox24.Text;
        string panelId = TextBox25.Text;

        string query1 = "update UserAccounts set userRole = 'panel' WHERE accountId = (select accountId from Faculty where facId = '" + facId + "')";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        string query2 = "update Faculty set panelId = '" + panelId + "' where facId = '" + facId + "'";
        cm = new SqlCommand(query2, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();


        conn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string newDate = TextBox17.Text;


        string query1 = "Update FYP set deadline = '" + newDate + "';";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        conn.Close();
    }
}