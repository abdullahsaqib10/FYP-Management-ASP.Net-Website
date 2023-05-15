using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class supervisorint : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string supId = TextBox1.Text;

        string query1 = "select f.FYPId, f.title, f.projDesc from FYP f, ProjGroup p where f.groupId = p.groupId AND p.supervisorId = '" + supId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView1.DataSource = reader1;
        GridView1.DataBind();

        reader1.Close();
        conn.Close();

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string supId = TextBox1.Text;

        string query1 = "select groupId, groupName from ProjGroup where ProjGroup.supervisorId = '" + supId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView2.DataSource = reader1;
        GridView2.DataBind();

        reader1.Close();
        conn.Close();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string supId = TextBox1.Text;

        string query1 = "select p.panelId, (select pn.panelName from Panel pn where pn.panelId = p.panelId) as 'panel Name' from FYP f, ProjGroup p where f.groupId = p.groupId AND p.supervisorId = '" + supId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView3.DataSource = reader1;
        GridView3.DataBind();

        reader1.Close();
        conn.Close();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string groupId = TextBox2.Text;

        string query1 = "select e.grade from Evaluation e where e.groupId = '" + groupId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView4.DataSource = reader1;
        GridView4.DataBind();

        reader1.Close();
        conn.Close();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string supId = TextBox1.Text;
        string groupId = TextBox5.Text;

        string query1 = "select reviewOfProj from Review where groupId = '" + groupId + "' AND supervisorId = '" + supId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView5.DataSource = reader1;
        GridView5.DataBind();

        reader1.Close();
        conn.Close();
    }

    protected void Button10_Click(object sender, EventArgs e)     // log out
    {
        Response.Redirect("Project_DB.aspx");
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string supId = TextBox1.Text;
        string groupId = TextBox3.Text;
        string review = TextBox6.Text;

        string query1 = "SELECT COUNT(*) FROM Review";
        int rowsAmount;
        using (var cmd = new SqlCommand(query1, conn))
        {
            rowsAmount = (int)cmd.ExecuteScalar(); // get the value of the count
        }
        rowsAmount = rowsAmount + 1;
        string query2 = "Insert Into Review(reviewId, reviewOfProj, groupId, supervisorId) values ('" + rowsAmount + "', '" + review + "', '" + groupId + "', '" + supId + "')";
        cm = new SqlCommand(query2, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        conn.Close();
    }

    protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string newRev = TextBox7.Text;
        string groupId = TextBox5.Text;

        string query1 = "update Review set reviewOfProj = '" + newRev + "' Where groupId = '" + groupId + "'";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        conn.Close();
    }
}