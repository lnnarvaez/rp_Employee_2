# rp_Employee_2
# Sistema de Gestión de Empleados mediante Archivos CSV
## 📖 Descripción
Esta es una aplicación de escritorio desarrollada para el departamento de Recursos Humanos de la empresa TechSolutions S.A.[cite: 1]. Su objetivo principal es facilitar la consulta y actualización de la información de los empleados sin tener que modificar manualmente los registros. Originalmente, la empresa administraba esta información utilizando un archivo de texto en formato CSV.

El sistema automatiza tareas que antes eran lentas y manuales, reduciendo el riesgo de errores al modificar directamente los archivos.

## 🚀 Características Principales

* **Lectura de Archivos CSV**: El sistema verifica que el archivo exista, lee todos los registros y convierte cada línea en un objeto para trabajar en memoria.
* **Búsqueda de Empleados**: Permite buscar la información de un empleado ingresando su número de cédula.
* **Cálculos Automáticos**:
  * **Edad**: Se calcula de forma automática utilizando la fecha de nacimiento y la fecha actual del sistema.
  * **Antigüedad Laboral**: Se obtiene utilizando la fecha de ingreso y la fecha actual.
  * **Prestaciones**: Calcula un incentivo por antigüedad aplicando la regla de negocio de 1% por cada año trabajado, con un límite máximo del 8%].
* **Modificación de Salario**: Permite registrar aumentos salariales, validando que el nuevo salario sea mayor al actual, que no sea negativo, y actualiza automáticamente el archivo CSV.
* **Registro de Empleados**: Permite ingresar nuevos trabajadores validando que la cédula sea única, los campos sean obligatorios, las fechas sean válidas y el sexo corresponda a "MASCULINO" o "FEMENINO".

## 🛠 Tecnologías Utilizadas

* **Lenguaje de Programación**: C#.
* **Framework**: .NET 8.
* **Tipo de Proyecto**: Aplicación de Escritorio.

## 📂 Estructura del Archivo de Datos

La aplicación utiliza un archivo de texto con extensión CSV que emplea el carácter `;` como delimitador. La estructura obligatoria de las columnas es la siguiente:

`CEDULA; NOMBRE; APELLIDOS; TELEFONO; CORREO; SEXO; FECHA_NACIMIENTO; FECHA_INGRESO; SALARIO_ACTUAL; DEDUCCIONES`.

## 🏗️ Estructura del Proyecto (Diseño Orientado a Objetos)

El proyecto está diseñado bajo el paradigma de Programación Orientada a Objetos y se organiza en las siguientes clases sugeridas:

* **Clase `FormPrincipal`**: Se encarga de gestionar la interacción entre el usuario y las demás clases del sistema.
* **Entidades (Ej. Empleado)**: Clases para almacenar la información en memoria y contener métodos de lógica de negocio como `CalcularEdad()`, `CalcularAntiguedad()` y `CalcularPrestacion()`.
* **Clase `GestionarArchivoEmpleado`**: Responsable de la persistencia de datos con métodos como `LeerArchivo()`, `GuardarArchivo()`, `AgregarEmpleado()` y `BuscarEmpleado()`.
* **Clase Validadora**: Implementa métodos de validación de datos ingresados como `ValidarCedula()`, `ValidarCorreo()` y `ValidarSalario()`.

## ⚙️ Requisitos Previos

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado en el equipo.
* Visual Studio 2022 o IDE compatible con C# y .NET 8.

## 🛡️ Manejo de Errores

El sistema implementa el uso de bloques `try-catch` para capturar excepciones de lectura/escritura de archivos (como `FileNotFoundException` o `IOException`), así como errores de validación y formato (`FormatException`) garantizando la estabilidad de la aplicación.
