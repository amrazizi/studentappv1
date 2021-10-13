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

        private void TxtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                lblErrorNO.Visible = true;
                 
            }
            else
            {
                lblErrorNO.Visible = false;
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
                lblErrorName.Visible = true;
            }
            else
            {
                lblErrorName.Visible = false;
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                lblErrorMobile.Visible = true;

            }
            else
            {
                lblErrorMobile.Visible = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dgStudents.Rows.Add();

            int lastIndex = dgStudents.Rows.Count - 1;

            dgStudents.Rows[lastIndex].Cells[0].Value = txtNo.Text;
            dgStudents.Rows[lastIndex].Cells[1].Value = txtName.Text;
            dgStudents.Rows[lastIndex].Cells[2].Value = cmbFaculty.Text;
            dgStudents.Rows[lastIndex].Cells[3].Value = cmbDept.Text;
            dgStudents.Rows[lastIndex].Cells[4].Value = txtMobile.Text;
            dgStudents.Rows[lastIndex].Cells[5].Value = dtDOB.Text;



            if (rdMale.Checked)
            {
                dgStudents.Rows[lastIndex].Cells[6].Value = "male";
            }
            else if (rdFemale.Checked)
            {
                dgStudents.Rows[lastIndex].Cells[6].Value = "female";
            }
         
            dgStudents.Rows[lastIndex].Cells[7].Value = chkMarried.Checked;
            dgStudents.Rows[lastIndex].Cells[8].Value = txtAddress.Text;
            dgStudents.Rows[lastIndex].Cells[9].Style.BackColor = pnlEyeColor.BackColor;
            dgStudents.Rows[lastIndex].Cells[10].Value = picImage.Image;

        }
    }
}
