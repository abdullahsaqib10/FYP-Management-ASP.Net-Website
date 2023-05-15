using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class panelform : System.Web.UI.Page
{
    int marks = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton18_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton12_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void Button2_Click(object sender, EventArgs e) //Log out
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

        string panId = TextBox1.Text;

        string query1 = "select p.groupId, p.groupName, f.FYPId, f.title, f.projDesc from FYP f, ProjGroup p where f.groupId = p.groupId AND p.panelId = '" + panId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView1.DataSource = reader1;
        GridView1.DataBind();

        reader1.Close();
        conn.Close();
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        //string panId = TextBox1.Text;
        string groupId = TextBox2.Text;

        string grade;

        int percentage = ((marks * 100) / 150);


        if (percentage >= 90)
            grade = "A+";
        else if (percentage >= 86 && percentage <= 89)
            grade = "A";
        else if (percentage >= 82 && percentage <= 85)
            grade = "A-";
        else if (percentage >= 78 && percentage <= 81)
            grade = "B+";
        else if (percentage >= 74 && percentage <= 77)
            grade = "B";
        else if (percentage >= 70 && percentage <= 73)
            grade = "B-";
        else if (percentage >= 66 && percentage <= 69)
            grade = "C+";
        else if (percentage >= 62 && percentage <= 65)
            grade = "C";
        else if (percentage >= 58 && percentage <= 61)
            grade = "C-";
        else if (percentage >= 54 && percentage <= 57)
            grade = "D+";
        else if (percentage >= 50 && percentage <= 53)
            grade = "D";
        else
            grade = "F";

        string query1 = "update Evaluation set marks = '" + marks + "', grade = '" + grade + "' where groupId = '" + groupId + "'";
        cm = new SqlCommand(query1, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();

        conn.Close();

    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton8_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton11_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton13_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton14_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton15_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton16_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton17_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton19_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton20_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton21_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton22_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton23_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton24_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton25_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton26_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton27_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton28_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton29_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton30_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton31_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton32_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton33_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton34_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton35_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton36_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton37_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton38_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton39_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton40_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton41_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton42_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton43_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton44_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton45_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton46_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton47_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton48_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton49_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton50_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton51_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton52_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton53_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton54_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton55_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton56_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton57_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton58_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton59_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton60_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton61_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton62_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton63_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton64_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton65_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton66_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton67_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton68_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton69_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton70_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton71_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton72_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton73_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton74_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton75_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton76_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton77_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton78_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton79_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton80_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton81_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton82_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton83_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton84_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton85_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton86_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton87_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton88_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton89_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton90_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton91_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton92_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton93_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton94_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton95_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton96_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton97_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton98_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton99_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton100_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton101_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton102_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton103_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton104_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton105_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton106_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton107_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton108_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton109_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton110_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton111_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton112_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton113_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton114_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton115_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton116_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton117_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton118_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton119_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton120_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton121_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton122_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton123_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton124_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton125_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton126_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton127_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton128_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton129_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton130_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton131_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton132_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton133_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton134_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton135_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton136_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton137_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton138_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton139_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton140_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton141_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton142_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton143_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton144_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton145_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton146_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton147_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton148_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton149_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton150_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton151_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton152_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton153_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton154_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void RadioButton155_CheckedChanged(object sender, EventArgs e)
    {
        marks += 0;
    }

    protected void RadioButton156_CheckedChanged(object sender, EventArgs e)
    {
        marks += 1;
    }

    protected void RadioButton157_CheckedChanged(object sender, EventArgs e)
    {
        marks += 2;
    }

    protected void RadioButton158_CheckedChanged(object sender, EventArgs e)
    {
        marks += 3;
    }

    protected void RadioButton159_CheckedChanged(object sender, EventArgs e)
    {
        marks += 4;
    }

    protected void RadioButton160_CheckedChanged(object sender, EventArgs e)
    {
        marks += 5;
    }

    protected void RadioButton161_CheckedChanged(object sender, EventArgs e)
    {
        marks += 6;
    }

    protected void RadioButton162_CheckedChanged(object sender, EventArgs e)
    {
        marks += 7;
    }

    protected void RadioButton163_CheckedChanged(object sender, EventArgs e)
    {
        marks += 8;
    }

    protected void RadioButton164_CheckedChanged(object sender, EventArgs e)
    {
        marks += 9;
    }

    protected void RadioButton165_CheckedChanged(object sender, EventArgs e)
    {
        marks += 10;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JFS6RBR\\SQLEXPRESS;Initial Catalog=project4;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string groupId = TextBox2.Text;
        

        string query1 = "select e.groupId, p.groupName, f.title, marks, grade from Evaluation e, ProjGroup p, FYP f where p.groupId = e.groupId AND e.groupId = f.groupId AND e.groupId = '" + groupId + "'";
        cm = new SqlCommand(query1, conn);

        SqlDataReader reader1 = cm.ExecuteReader();

        GridView2.DataSource = reader1;
        GridView2.DataBind();

        reader1.Close();
        conn.Close();
    }
}