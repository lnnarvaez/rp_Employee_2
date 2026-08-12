using Employee_2.userclass;
using System;
using System.Windows.Forms;

namespace Employee_2
{
    public partial class EmployeeList : Form
    {
        private readonly Employee employeeRepository;

        public EmployeeList()
        {
            InitializeComponent();
            employeeRepository = new Employee();
            Load += EmployeeList_Load; // Carga los datos del archivo al abrir el formulario.
        }

        private void EmployeeList_Load(object? sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            //Preparar el grid con nombres en español y columnas calculadas.
            dGrid_ListEmployee.Columns.Clear();
            dGrid_ListEmployee.Rows.Clear();
            dGrid_ListEmployee.AutoGenerateColumns = false;
            dGrid_ListEmployee.AllowUserToAddRows = false;
            dGrid_ListEmployee.ReadOnly = true;

            dGrid_ListEmployee.Columns.Add("IdentityCard", "Cédula");
            dGrid_ListEmployee.Columns.Add("Name", "Nombres");
            dGrid_ListEmployee.Columns.Add("LastName", "Apellidos");
            dGrid_ListEmployee.Columns.Add("Phone", "Teléfono");
            dGrid_ListEmployee.Columns.Add("Email", "Correo");
            dGrid_ListEmployee.Columns.Add("Sex", "Sexo");
            dGrid_ListEmployee.Columns.Add("BirthDate", "Fecha Nacimiento");
            dGrid_ListEmployee.Columns.Add("Age", "Edad");
            dGrid_ListEmployee.Columns.Add("DateEntry", "Fecha Ingreso");
            dGrid_ListEmployee.Columns.Add("Antique", "Antiguedad");
            dGrid_ListEmployee.Columns.Add("Salary", "Salario");
            dGrid_ListEmployee.Columns.Add("Bonus", "Bonificación");

            foreach (Employee item in employeeRepository.EmployeeList())
            {
                //Calcular los campos derivados antes de insertar la fila en el grid.
                dGrid_ListEmployee.Rows.Add(
                    item.IdentityCard,
                    item.Name,
                    item.LastName,
                    item.Phone,
                    item.Email,
                    item.Sex,
                    item.BirthDate.ToString("dd/MM/yyyy"),
                    item.AgeCalculate(),
                    item.DateEntry.ToString("dd/MM/yyyy"),
                    item.CalculateAntique(),
                    item.Salary,
                    item.Bonus);
            }
        }
    }
}
