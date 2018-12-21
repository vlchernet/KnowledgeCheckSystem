using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knowledgeCheckDBDataSet.Answer' table. You can move, or remove it, as needed.
            this.answerTableAdapter.Fill(this.knowledgeCheckDBDataSet.Answer);
            // TODO: This line of code loads data into the 'knowledgeCheckDBDataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.knowledgeCheckDBDataSet.Question);
            // TODO: This line of code loads data into the 'knowledgeCheckDBDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.knowledgeCheckDBDataSet.Subject);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string subjectId = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT [Description] FROM [Question] WHERE [Subject] = @Id", connection: questionTableAdapter.Connection);
            command.Parameters.AddWithValue("Id", subjectId);
            sqlReader = command.ExecuteReader();
            listBox1.Items.Clear();
            listBox1.Items.Add("Question");
            listBox1.Items.Add("======================================");
            while (sqlReader.Read())
            {
                listBox1.Items.Add(sqlReader["Description"]);
            }
            sqlReader.Close();*/
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = Convert.ToInt32(comboBox1.SelectedValue) == 1 ? "TRUE" : "FALSE";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
