using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3b___Basic_Input
{
    public partial class BasicInput : Form
    {
        string name;
        int age;
        double height;


        public BasicInput()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                name = txtName.Text;

                age = Convert.ToInt32(nudAge.Value);
                age = 82 - age;

                height = Convert.ToDouble(txtHeight.Text);
                height = 2.72 - height;
                height = Math.Round(height, 2);

                lblOutput.Text = $"Hello {name}! You are {age} years below life expectancy in Canada and are {height}m shorter than the tallest person on earth. ";

            }
        }
    }
}
