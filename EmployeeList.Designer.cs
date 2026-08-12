namespace Employee_2
{
    partial class EmployeeList
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
            label1 = new Label();
            dGrid_ListEmployee = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dGrid_ListEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // dGrid_ListEmployee
            // 
            dGrid_ListEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGrid_ListEmployee.Location = new Point(41, 124);
            dGrid_ListEmployee.Name = "dGrid_ListEmployee";
            dGrid_ListEmployee.Size = new Size(889, 341);
            dGrid_ListEmployee.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(799, 43);
            button1.Name = "button1";
            button1.Size = new Size(80, 32);
            button1.TabIndex = 2;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 512);
            Controls.Add(button1);
            Controls.Add(dGrid_ListEmployee);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeeList";
            Text = "Empleados Resgistrados";
            ((System.ComponentModel.ISupportInitialize)dGrid_ListEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dGrid_ListEmployee;
        private Button button1;
    }
}