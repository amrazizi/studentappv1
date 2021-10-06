using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsAppV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmbFaculty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbDept.Items.Clear();
            if (cmbFaculty.SelectedIndex == 0)
            {
                cmbDept.Items.Add("f1 options");
                cmbDept.Items.Add("f1 options");
                cmbDept.Items.Add("f1 options");
            }
            else if (cmbFaculty.SelectedIndex == 1)
            {
                cmbDept.Items.Add("f2 options");
                cmbDept.Items.Add("f2 options");
                cmbDept.Items.Add("f2 options");
            }
            else if (cmbFaculty.SelectedIndex == 2)
            {
                cmbDept.Items.Add("f3 options");
                cmbDept.Items.Add("f3 options");
                cmbDept.Items.Add("f3 options");

            }
        }

        private void PicImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose student image";
            ofd.Filter = "Images|*.jpg;*.tiff;*.png;*.bmp;";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(ofd.FileName);
            }

        }



        private void PnlEyeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult res = cd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pnlEyeColor.BackColor = cd.Color;
            }
        }
    }
}
