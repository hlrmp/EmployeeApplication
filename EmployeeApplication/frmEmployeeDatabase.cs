

using System;
using System.Windows.Forms;
using EmployeeNamespace;
namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }
        Employee em = new Employee();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int txt1 = Convert.ToInt32(textBox1.Text);
                string txt2 = textBox2.Text;
                string txt3 = textBox3.Text;
                string txt4 = textBox4.Text;

                em.emid = txt1;
                em.empfname = txt2;
                em.emplname = txt3;
                em.emppos = txt4;


             


                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)
                && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
                {


                    dataGridView1.Rows.Add(em.emid, em.empfname, em.emplname, em.emppos);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                }

          
                else
                {
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        MessageBox.Show(" Please Enter Employee Id ", "error", MessageBoxButtons.OK);

                    }
                    else if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show(" Please Enter Employee first name ", "error", MessageBoxButtons.OK);
                    }
                    else if (string.IsNullOrEmpty(textBox3.Text))
                    {
                        MessageBox.Show(" Please Enter Employee last name ", "error", MessageBoxButtons.OK);
                    }
                    else if (string.IsNullOrEmpty(textBox4.Text))
                    {
                        MessageBox.Show(" Please Enter Employee position ", "error", MessageBoxButtons.OK);
                    }

                }
            } // try
            catch (Exception)

            {
                if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text)
                              && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show(" please fill up the ff.");
                }
                else if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show(" Please Enter Employee Id ", "error", MessageBoxButtons.OK);

                }
                else if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show(" Please Enter Employee first name ", "error", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show(" Please Enter Employee last name ", "error", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show(" Please Enter Employee position ", "error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(" invalid input !!! check the information");
                }

            }// catch
        }
    }
}