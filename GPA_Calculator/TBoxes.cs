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
    class TBoxes
    {
        /// <index _map>
        /// [0] = course_name, [1] = gpa, [2] = credit_hour
        /// </index _map>

        public TextBox[] tb;

        public TBoxes()
        {
            tb = new TextBox[3];

            //tb[0] = new TextBox();
            //tb[1] = new TextBox();
            //tb[2] = new TextBox();

            for(int i=0; i<3; i++)
            {
                tb[i] = new TextBox(); // solution for below occuring "NULL_EXCEPTION" problem

                /// <designing>

                tb[i].BorderStyle = BorderStyle.Fixed3D;
                tb[i].BackColor = Color.White;
                tb[i].ForeColor = Color.Black;

                /// </designing>
            }
        }

        public int tb_init(int no, int x_axis, int y_axis, int size_x, int size_y, Font tbFont, Form2 addr)
        {
            if(tb[0] == null)
            {
                /// memory is assigned to the tb pointer in the constructor TBoxes()
                /// but still the pointer is null and 0 returned from this condition
                /// why?
                /// ANSWER: After creating the array of textboxes, every index must be initialized
                /// like: textbox[i] = new TextBox();
                
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Textbox pointer is null.\nIt can cause nullPointerException.", "Null_Pointer_Exception", button, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                
                if(result == DialogResult.OK)
                {
                    addr.Close();
                }
                
                return 0;
            }

            tb[0].Name = "course_name" + no;
            tb[0].Text = "course_name" + no;
            tb[0].Location = new Point(x_axis, y_axis);
            tb[0].Size = new Size(size_x, size_y);
            tb[0].Font = tbFont;

            y_axis += 39;

            tb[1].Name = "gpa" + no;
            tb[1].Text = "gpa" + no;
            tb[1].Location = new Point(x_axis, y_axis);
            tb[1].Size = new Size(size_x, size_y);
            tb[1].Font = tbFont;

            tb[2].Name = "credit_hour" + no;
            tb[2].Text = "credit_hour" + no;
            tb[2].Location = new Point(x_axis + 260 , y_axis);
            tb[2].Size = new Size(size_x, size_y);
            tb[2].Font = tbFont;

            return 1;
        }
    }
}
