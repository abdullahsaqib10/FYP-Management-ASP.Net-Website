using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class studentview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Project_DB.aspx");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string stdId = TextBox1.Text;

        string query1 = "select P.groupId,P.groupName from ProjGroup P,Student S where S.groupId=P.groupId and s.StdId = '" + stdId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView1.DataSource = reader1;
        GridView1.DataBind();

        reader1.Close();

        string query2 = "select st.stdId 'Student group Ids', st.fName 'Student group members first name', st.lName 'Student group members last name' from Student s, Student st where s.StdId = '" + stdId + "' AND s.groupId = st.groupId";
        cm = new SqlCommand(query2, conn);

        SqlDataReader reader2 = cm.ExecuteReader();

        GridView2.DataSource = reader2;
        GridView2.DataBind();

        conn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string stdId = TextBox1.Text;

        string query1 = "select sr.supervisorId, f.fName from Student s, ProjGroup p, Supervisor sr, Faculty f where s.groupId = p.groupId AND p.supervisorId = sr.supervisorId AND f.facId = sr.facId AND s.StdId = '" + stdId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView3.DataSource = reader1;
        GridView3.DataBind();

        reader1.Close();

        conn.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string stdId = TextBox1.Text;

        string query1 = "select P.panelId,P.panelName from Panel P, Student S,ProjGroup G where P.panelId=G.panelId and G.groupId=S.groupId and s.StdId = '" + stdId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView4.DataSource = reader1;
        GridView4.DataBind();

        reader1.Close();

        conn.Close();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string stdId = TextBox1.Text;

        string query1 = "select F.FYPId,F.title,F.presentationDate,F.projDesc,F.deadline,E.grade,E.marks from FYP F,ProjGroup G,Student S,Evaluation E where F.groupId=G.groupId and G.groupId=S.groupId and E.groupId=G.groupId and S.StdId = '" + stdId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView5.DataSource = reader1;
        GridView5.DataBind();

        reader1.Close();

        conn.Close();
    }
}