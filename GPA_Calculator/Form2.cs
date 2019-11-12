using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GPA_Calculator
{
    public partial class Form2 : Form
    {
        /// <attributes>
        private int count, x, y;
        private Font txtBoxFont;
        private Form1 addr;
        private TBoxes[] objofTBoxes;
        private int c = 0;
        private TextBox result;
        /// </attributes>

        public Form2(Form1 addr)
        {
            InitializeComponent();
            count = 0;
            txtBoxFont = new Font("Century", 11, FontStyle.Regular, GraphicsUnit.Point);
            x = 124;
            y = 252;
            this.addr = addr;

            objofTBoxes = new TBoxes[8];

            for (int i = 0; i < 8; i++)
            {
                objofTBoxes[i] = new TBoxes();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // window heading
            this.Text = "SGPA";

            this.AutoScroll = true;
            // AutoScrollMargin: the gap between the bottom window bar and object on form, the more the merrier
            this.AutoScrollMargin = new Size(25, 25);

            /// creating a textbox at load_time of form2 to display the result ( sgpa )
            result = new TextBox();

            result.Font = new Font("Century", 23, FontStyle.Bold, GraphicsUnit.Point);
            result.Location = new Point(321, 70);
            result.Multiline = true;
            result.Size = new Size(223, 44);
            result.ReadOnly = true;
            result.TextAlign = HorizontalAlignment.Right;
            result.Text = "0.0";

            this.Controls.Add(result);

            /// changing the text on the buttons of form2
            save_btn.Text = "calculate";
            addTextBox_btn.Text = "+";

            
        }

        private void addTextBox_btn_Click(object sender, EventArgs e)
        {
            count++;
            
            if(count > 8)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show("Number of courses exceed the limit.", "Exception", btn, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                this.Refresh();

                Label l = new Label();
                l.Size = new Size(20, 20);
                l.Location = new Point(x - 50, y);
                l.Text = "" + count;
                this.Controls.Add(l);

                int check = objofTBoxes[c].tb_init(count, x, y, 228, 28, txtBoxFont, this);

                if (check == 0)
                {
                    addr.Close();
                }

                /// <summary>
                /// [0] = course_name, [1] = gpa, [2] = credit_hour
                /// </summary>

                this.Controls.Add(objofTBoxes[c].tb[0]);
                this.Controls.Add(objofTBoxes[c].tb[1]);
                this.Controls.Add(objofTBoxes[c].tb[2]);

                x = 124;
                y += 100;
                c++;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            double sgpa = sgpaCal();
            
            if(sgpa == -1)
            {
                //this.Close();
                result.Text = "NaN";
            }
            else
            {
                //MessageBox.Show("" + sgpa);
                result.Text = "" + sgpa;
            }
        }

        public double sgpaCal()
        {
            double sgpa = 0, gpa=1, crd_hr=1, sum_gpacrd=0, sum_crdhr=0;

            for (int i = 0; i < c; i++ )
            {
                ///gpa = Convert.ToDouble(objofTBoxes[c].tb[1].Text);
                ///crd_hr = Convert.ToDouble(objofTBoxes[c].tb[2].Text);

                try
                {
                    /// [0] = course_name, [1] = gpa, [2] = credit_hour

                    gpa = Double.Parse(objofTBoxes[i].tb[1].Text);
                    crd_hr = Double.Parse(objofTBoxes[i].tb[2].Text);
                }
                catch(Exception e)
                {
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBox.Show(e.Message, "Exception", btn,MessageBoxIcon.Warning);
                    return -1;
                }

                sum_gpacrd += (gpa * crd_hr);
                sum_crdhr += crd_hr;
            }

            if(sum_crdhr == 0)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show("Divide By Zero Exception", "Exception", btn, MessageBoxIcon.Warning);

                return -1;
            }
            else
            {
                sgpa = sum_gpacrd / sum_crdhr;
            }

            return sgpa;
        }
    }
}
