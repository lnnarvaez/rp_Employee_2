namespace Employee_2
{
    partial class EmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtAge = new TextBox();
            label13 = new Label();
            dateBirthDate = new DateTimePicker();
            label7 = new Label();
            comboSex = new ComboBox();
            label6 = new Label();
            textEmail = new TextBox();
            label5 = new Label();
            maskPhone = new MaskedTextBox();
            label4 = new Label();
            textSurname = new TextBox();
            label3 = new Label();
            textName = new TextBox();
            label2 = new Label();
            maskIdentitycard = new MaskedTextBox();
            label1 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            txtAntique = new TextBox();
            label12 = new Label();
            textBenefits = new TextBox();
            label11 = new Label();
            textSalary = new MaskedTextBox();
            label10 = new Label();
            dateHiredate = new DateTimePicker();
            label9 = new Label();
            btnGuardar = new Button();
            btnSearch = new Button();
            btnList = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(dateBirthDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboSex);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(maskPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textSurname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskIdentitycard);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 353);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(436, 162);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(224, 25);
            txtAge.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(374, 172);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 14;
            label13.Text = "Edad";
            // 
            // dateBirthDate
            // 
            dateBirthDate.Cursor = Cursors.Hand;
            dateBirthDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBirthDate.Format = DateTimePickerFormat.Short;
            dateBirthDate.Location = new Point(103, 162);
            dateBirthDate.MaxDate = new DateTime(2026, 8, 25, 23, 59, 59, 0);
            dateBirthDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateBirthDate.Name = "dateBirthDate";
            dateBirthDate.Size = new Size(224, 25);
            dateBirthDate.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 172);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 12;
            label7.Text = "Nacimiento";
            // 
            // comboSex
            // 
            comboSex.Cursor = Cursors.Hand;
            comboSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSex.Font = new Font("Segoe UI", 9.75F);
            comboSex.FormattingEnabled = true;
            comboSex.Items.AddRange(new object[] { "Seleccionar", "Femenino", "Masculino" });
            comboSex.Location = new Point(103, 220);
            comboSex.Name = "comboSex";
            comboSex.Size = new Size(224, 25);
            comboSex.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 230);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 10;
            label6.Text = "Sexo";
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 9.75F);
            textEmail.Location = new Point(436, 282);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(224, 25);
            textEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 292);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "Correo";
            // 
            // maskPhone
            // 
            maskPhone.Font = new Font("Segoe UI", 9.75F);
            maskPhone.Location = new Point(103, 282);
            maskPhone.Mask = "####-####";
            maskPhone.Name = "maskPhone";
            maskPhone.Size = new Size(224, 25);
            maskPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 292);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Teléfono";
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 9.75F);
            textSurname.Location = new Point(436, 104);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(224, 25);
            textSurname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 114);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellidos";
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 9.75F);
            textName.Location = new Point(103, 104);
            textName.Name = "textName";
            textName.Size = new Size(224, 25);
            textName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 114);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // maskIdentitycard
            // 
            maskIdentitycard.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskIdentitycard.Location = new Point(103, 46);
            maskIdentitycard.Mask = "###-######-####L";
            maskIdentitycard.Name = "maskIdentitycard";
            maskIdentitycard.Size = new Size(224, 25);
            maskIdentitycard.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 51);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(337, 27);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 1;
            label8.Text = "Empleado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAntique);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBenefits);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textSalary);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dateHiredate);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(44, 461);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(698, 140);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos laborales";
            // 
            // txtAntique
            // 
            txtAntique.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAntique.Location = new Point(462, 36);
            txtAntique.Name = "txtAntique";
            txtAntique.Size = new Size(213, 25);
            txtAntique.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(374, 44);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 6;
            label12.Text = "Antigüedad";
            // 
            // textBenefits
            // 
            textBenefits.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBenefits.Location = new Point(462, 80);
            textBenefits.Name = "textBenefits";
            textBenefits.Size = new Size(213, 25);
            textBenefits.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(374, 90);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 4;
            label11.Text = "Prestaciones";
            // 
            // textSalary
            // 
            textSalary.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSalary.Location = new Point(114, 80);
            textSalary.Name = "textSalary";
            textSalary.Size = new Size(213, 25);
            textSalary.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 90);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 2;
            label10.Text = "Salario";
            // 
            // dateHiredate
            // 
            dateHiredate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateHiredate.Format = DateTimePickerFormat.Short;
            dateHiredate.Location = new Point(114, 34);
            dateHiredate.MaxDate = new DateTime(2026, 8, 6, 0, 0, 0, 0);
            dateHiredate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateHiredate.Name = "dateHiredate";
            dateHiredate.Size = new Size(213, 25);
            dateHiredate.TabIndex = 1;
            dateHiredate.Value = new DateTime(2026, 8, 6, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 44);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 0;
            label9.Text = "Fecha Ingreso";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(41, 635);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 36);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(222, 635);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 36);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnList.Location = new Point(405, 635);
            btnList.Name = "btnList";
            btnList.Size = new Size(160, 36);
            btnList.TabIndex = 5;
            btnList.Text = "Listar";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 711);
            Controls.Add(btnList);
            Controls.Add(btnSearch);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Empleados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox maskIdentitycard;
        private Label label1;
        private TextBox textSurname;
        private Label label3;
        private TextBox textName;
        private Label label2;
        private MaskedTextBox maskPhone;
        private Label label4;
        private TextBox textEmail;
        private Label label5;
        private ComboBox comboSex;
        private Label label6;
        private DateTimePicker dateBirthDate;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private Label label11;
        private MaskedTextBox textSalary;
        private Label label10;
        private DateTimePicker dateHiredate;
        private Label label9;
        private Button btnGuardar;
        private TextBox textBenefits;
        private Button btnSearch;
        private TextBox txtAntique;
        private Label label12;
        private TextBox txtAge;
        private Label label13;
        private Button btnList;
    }
}
