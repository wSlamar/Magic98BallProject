using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void insertText_TextChanged(object sender, EventArgs e)
        {
            insertText.MaxLength = 250;
        }
        private void GetAnswer()
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLExpress; Database=Magic8Ball; Trusted_Connection=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select top 1 * from Questions order by newid()", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                outputText.Text = Convert.ToString(da["Question"]);
            }
            con.Close();
        }
        private void submitter(object sender, EventArgs e)
        {
            if (insertText.Text == "")
            {
                MessageBox.Show("You must ask a question first!", "Submit Question");
                goto SkipToEnd;
            }
            if (insertText.Text.Contains("?") == false)
            {
                MessageBox.Show("Your entry must be in the form of a question!", "Submit Question");
            }
            else
            {
                submitButton.Enabled = false;
                insertText.ReadOnly = true;
                GetAnswer();
            }
            if (outputText.Text.Contains("again") == true)
            {
                submitButton.Enabled = true;
            }
            SkipToEnd: { }
        }
        private void another(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
            insertText.ReadOnly = false;
            insertText.Text = "";
            outputText.Text = "";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by William.", "Magic 98 Ball v2.0");
        }
        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string picture = @"C:\Users\Student\Desktop\ProjectsNew\williamsprojectsredo\Magic8Ball2.0\Magic8Ball2.0\img\guide.png";

            Process.Start(picture);
        }
        private void outputText_TextChanged(object sender, EventArgs e) { }
    }
}
