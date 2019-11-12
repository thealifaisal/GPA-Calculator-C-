using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form3 : Form
    {
        /// <attributes>
        TextBox[] textBoxes;
        int count=0, c=0, x_axis, y_axis, height, width;
        TextBox result;
        /// </attributes>

        public Form3()
        {
            InitializeComponent();

            textBoxes = new TextBox[10];
            for(int i=0; i<10; i++)
            {
                textBoxes[i] = new TextBox();
            }

            x_axis = 124;
            y_axis = 252;
            height = 28;
            width = 228;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // window heading
            this.Text = "CGPA";

            this.AutoScroll = true;
            // AutoScrollMargin: the gap between the bottom window bar and object on form, the more the merrier
            this.AutoScrollMargin = new Size(25, 25);

            this.Size = new Size(749, 642);
            this.BackgroundImage = Image.FromFile("D:/FAST/Personal Projects/GPA Calculator/GPA_Calculator/GPA_Calculator/bg/008_Rainy_Ashville.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Icon.ExtractAssociatedIcon("D:/FAST/Personal Projects/GPA Calculator/GPA_Calculator/GPA_Calculator/icon/Dtafalonso-Android-Lollipop-Calculator.ico");

            //Label cgpa_label = new Label();
            //cgpa_label.Size = new Size(128, 44);
            //cgpa_label.Location = new Point(189, 70);
            //cgpa_label.Text = "CGPA";
            cgpa_label.BackColor = Color.Transparent;
            cgpa_label.ForeColor = Color.MidnightBlue;
            cgpa_label.Font = new Font("Century", 28, FontStyle.Regular, GraphicsUnit.Point);
            //this.Controls.Add(cgpa_label);

            result = new TextBox();
            result.Location = new Point(321, 70);
            result.Size = new Size(223, 44);
            result.Multiline = true;
            result.ReadOnly = true;
            result.Text = "0.0";
            result.TextAlign = HorizontalAlignment.Right;
            result.Font = new Font("Century", 23, FontStyle.Bold, GraphicsUnit.Point);
            this.Controls.Add(result);

            /// changing the text on the buttons of form3
            addTextBox_btn.Text = "+";
            save_btn.Text = "calculate";

        }

        private void addTextBox_btn_Click(object sender, EventArgs e)
        {
            count++;

            if(count > 10)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show("Number of inputs exceed limit", "Exception", btn, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                this.Refresh();

                Label l = new Label();
                l.Text = "" + count;
                l.Location = new Point(x_axis - 50, y_axis);
                l.Size = new Size(20, 20);
                this.Controls.Add(l);

                textBoxes[c].Text = "sgpa_" + count;
                textBoxes[c].Size = new Size(width, height);
                textBoxes[c].Location = new Point(x_axis, y_axis);
                textBoxes[c].Font = new Font("Century", 11, FontStyle.Regular, GraphicsUnit.Point);
                this.Controls.Add(textBoxes[c]);

                y_axis += 39;
                c++;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            double cgpa = cgpaCal();

            if(cgpa == -1)
            {
                result.Text = "NaN";
            }
            else
            {
                result.Text = "" + cgpa;
            }
        }

        private double cgpaCal()
        {
            double cgpa = 0.0, sgpa = 0.0;

            for (int i = 0; i < c; i++ )
            {
                try
                {
                    sgpa += double.Parse(textBoxes[i].Text);
                }
                catch(Exception e)
                {
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBox.Show(e.Message, "Exception", btn, MessageBoxIcon.Warning);
                    return -1;
                }
            }

            if(c == 0)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBox.Show("Divide By Zero Exception", "Exception", btn, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                return -1;
            }
            else
            {
                cgpa = sgpa / c;
            }

            return cgpa;
        }
    }
}
