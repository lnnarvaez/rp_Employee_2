using Employee_2.userclass;

namespace Employee_2
{
    public partial class EmployeeForm : Form
    {
        //Definir variable para instanciar la clase Employee
        private Employee? employee;

        public EmployeeForm()
        {
            InitializeComponent();
            //Crear una instancia de la clase Employee
            employee = new Employee();
            comboSex.SelectedIndex = 0; // Seleccionar el primer elemento del ComboBox
            dateBirthDate.ValueChanged += dateBirthDate_ValueChanged; // Actualiza la edad al confirmar o cambiar la fecha de nacimiento.
            dateHiredate.ValueChanged += dateHiredate_ValueChanged; // Actualiza la antigüedad al confirmar o cambiar la fecha de ingreso.
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Asignar los valores de los TextBox a las propiedades del objeto Employee
            employee.IdentityCard = maskIdentitycard.Text;
            employee.Name = textName.Text;
            employee.LastName = textSurname.Text;
            employee.Phone = maskPhone.Text;
            employee.Email = textEmail.Text;
            employee.Sex = comboSex.SelectedItem?.ToString() ?? string.Empty;
            employee.BirthDate = DateOnly.Parse(dateBirthDate.Text);
            employee.DateEntry = DateOnly.Parse(dateHiredate.Text);
            employee.Salary = double.Parse(textSalary.Text);
            employee.Bonus = double.Parse(textBenefits.Text);

            try
            {
                employee.EmployeeAdd();
                MessageBox.Show("Empleado guardado correctamente");
            }
            catch
            {
                MessageBox.Show("Error al guardar el empleado"); return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Recuperar el empleado por número de cédula
            Employee? repository = employee.EmployeeSearch(maskIdentitycard.Text);

            if (repository is null)
            {
                MessageBox.Show("No existe empleado con el número de cédula especificado.");
                return;
            }
            else
            {

                this.maskIdentitycard.Text = repository.IdentityCard;
                this.textName.Text = repository.Name;
                this.textSurname.Text = repository.LastName;
                this.maskPhone.Text = repository.Phone;
                this.textEmail.Text = repository.Email;
                this.comboSex.SelectedItem = repository.Sex;
                this.dateBirthDate.Text = repository.BirthDate.ToString();
                this.dateHiredate.Value = repository.DateEntry.ToDateTime(TimeOnly.MinValue);
                this.textSalary.Text = repository.Salary.ToString();
                this.textBenefits.Text = repository.Bonus.ToString();
            }
        }

        // Actualiza la edad al confirmar o cambiar la fecha de nacimiento.
        private void dateBirthDate_ValueChanged(object? sender, EventArgs e)
        {
            employee.BirthDate = DateOnly.FromDateTime(dateBirthDate.Value);
            txtAge.Text = employee.AgeCalculate().ToString();
        }

        // Calcula la antigüedad cuando se confirma la fecha de ingreso.
        private void dateHiredate_ValueChanged(object? sender, EventArgs e)
        {
            employee.DateEntry = DateOnly.FromDateTime(dateHiredate.Value);
            txtAntique.Text = employee.CalculateAntique().ToString();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList employeeListForm = new EmployeeList();
            employeeListForm.Show();
        }
    }// end class
}//end namespace
