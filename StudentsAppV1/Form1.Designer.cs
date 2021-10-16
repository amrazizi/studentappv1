
namespace StudentsAppV1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.pnlEyeColor = new System.Windows.Forms.Panel();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.colStudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarried = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEyeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblErrorNO = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorMobile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(14, 28);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(104, 20);
            this.txtNo.TabIndex = 0;
            this.txtNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNo_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(11, 12);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(24, 13);
            this.lblNo.TabIndex = 2;
            this.lblNo.Text = "No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(121, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "f1",
            "f2",
            "f3"});
            this.cmbFaculty.Location = new System.Drawing.Point(301, 27);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(121, 21);
            this.cmbFaculty.TabIndex = 4;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.CmbFaculty_SelectedIndexChanged_1);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(301, 12);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(44, 13);
            this.lblFaculty.TabIndex = 5;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(428, 12);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(33, 13);
            this.lblDept.TabIndex = 7;
            this.lblDept.Text = "Dept:";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(428, 27);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 21);
            this.cmbDept.TabIndex = 6;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(563, 9);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(100, 100);
            this.picImage.TabIndex = 8;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.PicImage_Click);
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(124, 79);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(205, 20);
            this.dtDOB.TabIndex = 9;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(121, 63);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(33, 13);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "DOB:";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(11, 15);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 11;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(63, 15);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 12;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdMale);
            this.grpGender.Controls.Add(this.rdFemale);
            this.grpGender.Location = new System.Drawing.Point(335, 62);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(133, 38);
            this.grpGender.TabIndex = 13;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Location = new System.Drawing.Point(476, 77);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(61, 17);
            this.chkMarried.TabIndex = 14;
            this.chkMarried.Text = "Married";
            this.chkMarried.UseVisualStyleBackColor = true;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(11, 61);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 16;
            this.lblMobile.Text = "Mobile:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(14, 77);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(104, 20);
            this.txtMobile.TabIndex = 15;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobile_KeyPress);
            // 
            // pnlEyeColor
            // 
            this.pnlEyeColor.BackColor = System.Drawing.Color.Black;
            this.pnlEyeColor.Location = new System.Drawing.Point(563, 135);
            this.pnlEyeColor.Name = "pnlEyeColor";
            this.pnlEyeColor.Size = new System.Drawing.Size(100, 23);
            this.pnlEyeColor.TabIndex = 17;
            this.pnlEyeColor.Click += new System.EventHandler(this.PnlEyeColor_Click);
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(560, 119);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(54, 13);
            this.lblEyeColor.TabIndex = 18;
            this.lblEyeColor.Text = "Eye color:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(11, 110);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(48, 13);
            this.lblAdress.TabIndex = 20;
            this.lblAdress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(14, 126);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(315, 71);
            this.txtAddress.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(588, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(507, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(426, 174);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // dgStudents
            // 
            this.dgStudents.AllowUserToAddRows = false;
            this.dgStudents.AllowUserToDeleteRows = false;
            this.dgStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentNumber,
            this.colName,
            this.colFaculty,
            this.colDept,
            this.colMobile,
            this.colDOB,
            this.colGender,
            this.colMarried,
            this.colAddress,
            this.colEyeColor,
            this.colImage});
            this.dgStudents.Location = new System.Drawing.Point(14, 212);
            this.dgStudents.Name = "dgStudents";
            this.dgStudents.ReadOnly = true;
            this.dgStudents.RowHeadersVisible = false;
            this.dgStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudents.Size = new System.Drawing.Size(649, 277);
            this.dgStudents.TabIndex = 24;
            // 
            // colStudentNumber
            // 
            this.colStudentNumber.HeaderText = "NO";
            this.colStudentNumber.Name = "colStudentNumber";
            this.colStudentNumber.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colDept
            // 
            this.colDept.HeaderText = "Dept";
            this.colDept.Name = "colDept";
            this.colDept.ReadOnly = true;
            // 
            // colMobile
            // 
            this.colMobile.HeaderText = "mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            // 
            // colDOB
            // 
            this.colDOB.HeaderText = "DOB";
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colMarried
            // 
            this.colMarried.HeaderText = "married";
            this.colMarried.Name = "colMarried";
            this.colMarried.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colEyeColor
            // 
            this.colEyeColor.HeaderText = "eye color";
            this.colEyeColor.Name = "colEyeColor";
            this.colEyeColor.ReadOnly = true;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "image";
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Visible = false;
            // 
            // lblErrorNO
            // 
            this.lblErrorNO.AutoSize = true;
            this.lblErrorNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblErrorNO.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorNO.Location = new System.Drawing.Point(11, 48);
            this.lblErrorNO.Name = "lblErrorNO";
            this.lblErrorNO.Size = new System.Drawing.Size(55, 13);
            this.lblErrorNO.TabIndex = 25;
            this.lblErrorNO.Text = "Only digits";
            this.lblErrorNO.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorName.Location = new System.Drawing.Point(124, 47);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(57, 13);
            this.lblErrorName.TabIndex = 26;
            this.lblErrorName.Text = "only letters";
            this.lblErrorName.Visible = false;
            // 
            // lblErrorMobile
            // 
            this.lblErrorMobile.AutoSize = true;
            this.lblErrorMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMobile.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorMobile.Location = new System.Drawing.Point(14, 97);
            this.lblErrorMobile.Name = "lblErrorMobile";
            this.lblErrorMobile.Size = new System.Drawing.Size(53, 13);
            this.lblErrorMobile.TabIndex = 27;
            this.lblErrorMobile.Text = "only digits";
            this.lblErrorMobile.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 498);
            this.Controls.Add(this.lblErrorMobile);
            this.Controls.Add(this.dgStudents);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.pnlEyeColor);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.chkMarried);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblErrorNO);
            this.Controls.Add(this.lblErrorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Panel pnlEyeColor;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMarried;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEyeColor;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.Label lblErrorNO;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorMobile;
    }
}

