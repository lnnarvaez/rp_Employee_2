using System.Text.Json;

namespace Employee_2.userclass
{
    internal class Employee
    {
        #region Attributes   
        // -- ----------------------------------------------------------------
        //       Campos / Atributos            
        // -- ----------------------------------------------------------------
        private string? identityCard;
        private string? name;
        private string? lastName;
        private string? phone;
        private string? email;
        private string? sex;
        private DateOnly birthDate;
        private DateOnly dateEntry;
        private double salary;
        private double bonus;

        #endregion

        #region Constants

        private const string FolderName = "datafolder";
        private const string FileName = "employees.json";

        #endregion

        #region Properties  
        // -- ---------------------------------------------------------------------
        //      Propiedades / Getters y Setters Encapasula propiedades del objeto         
        // -- ---------------------------------------------------------------------
        public string IdentityCard { get => identityCard; set => identityCard = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateOnly BirthDate 
        { 
            get => birthDate;

            set
            {
                //Establecer la fecha limite
                DateOnly minDateOnly = DateOnly.FromDateTime(DateTime.Today.AddYears(-19));

                //DateTime minDate = DateTime.Today.AddYears(-19);
                if (value > minDateOnly)
                {
                    throw new ArgumentException("La fecha de nacimiento debe ser al menos 18 años antes de la fecha actual.");
                }//End if 
                birthDate = value;
            }            
        }
        public DateOnly DateEntry { get => dateEntry; set => dateEntry = value; }
        public double Salary { get => salary; set => salary = value; }
        public double Bonus { get => bonus; set => bonus = value; }

        #endregion

        #region Methods
        // -- ----------------------------------------------------------------
        //      Métodos / Funciones / Comportamientos          
        // -- ----------------------------------------------------------------

        /// <summary>
        /// serializador de objetos a JSON con formato indentado
        /// </summary>
        private readonly JsonSerializerOptions jsonOptions = new()
        {
            WriteIndented = true
        };

        /// <summary>
        /// Agrega un nuevo empleado al archivo JSON
        /// </summary>
        /// <returns>1 si se agrega correctamente, 0 en caso contrario</returns>
        public int EmployeeAdd()
        {

            string projectRoot = GetProjectRoot();

            string folderPath = Path.Combine(projectRoot, FolderName);

            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, FileName);

            List<Employee> employees = new();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    employees = JsonSerializer.Deserialize<List<Employee>>(json)
                                ?? new List<Employee>();
                }
            }

            employees.Add(this);

            string newJson = JsonSerializer.Serialize(employees, jsonOptions);

            File.WriteAllText(filePath, newJson);

            return 1; //Temporal
        }

        private static string GetProjectRoot()
        {
            DirectoryInfo? directory = new(AppContext.BaseDirectory);

            while (directory is not null &&
                   !File.Exists(Path.Combine(directory.FullName, $"{directory.Name}.csproj")))
            {
                directory = directory.Parent;
            }

            return directory?.FullName
                   ?? throw new DirectoryNotFoundException(
                        "No fue posible localizar la raíz del proyecto.");
        }

        /// <summary>
        /// Lista todos los empleados del archivo JSON
        /// </summary>
        /// <returns>Lista de empleados</returns>
        public List<Employee> EmployeeList()
        {
            //Leer el archivo JSON y devolver la lista de empleados almacenada.
            string projectRoot = GetProjectRoot();
            string filePath = Path.Combine(projectRoot, FolderName, FileName);

            if (!File.Exists(filePath))
                return new List<Employee>();

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Employee>();

            return JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
        }

        /// <summary>
        /// Busca un empleado por cédula en el archivo JSON
        /// </summary>
        /// <param name="identityCard">Número de identificación</param>
        /// <returns>Empleado encontrado</returns>
        public Employee? EmployeeSearch (string identityCard)
        {
            if (string.IsNullOrWhiteSpace(identityCard))
                throw new ArgumentException("La cédula es obligatoria.", nameof(identityCard));

            string projectRoot = GetProjectRoot();

            string filePath = Path.Combine(projectRoot, FolderName, FileName);

            if (!File.Exists(filePath))
                return null;

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
                return null;

            List<Employee>? employees =
                JsonSerializer.Deserialize<List<Employee>>(json);

            if (employees is null)
                return null;

            return employees.FirstOrDefault(employee =>
                employee.IdentityCard.Equals(identityCard,
                    StringComparison.OrdinalIgnoreCase));
        }

        public int AgeCalculate()
        {
            //Calcular la edad a partir de la fecha de nacimiento.
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }

        public int CalculateAntique() 
        {
            //Calcular la antigüedad a partir de la fecha de ingreso.
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            int antique = today.Year - dateEntry.Year;

            if (today < dateEntry.AddYears(antique))
            {
                antique--;
            }

            return antique;
        }

        public double CalculateBenefice() 
        { 
            //Definir lógica para el calculo de las prestaciones
            return 0;
        }

        #endregion
    }//end class
}//end namespace
