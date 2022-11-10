using Ejercicio_Facultad.Dominio.Entidades;
using System;

namespace Ejercicio_Facultad.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Facultad facultadUBA = new Facultad("FCE", 10);

                Alumno a = new Alumno(896856, "Alexis", "Aguirre", DateTime.Parse("05/05/2000"));
                Alumno a1 = new Alumno(520360, "Julian", "Perez", DateTime.Parse("05/05/2000"));
                facultadUBA.AgregarAlumno(a);
                facultadUBA.AgregarAlumno(a1);

                Empleado e = new Empleado(DateTime.Parse("05/05/2020"), 1, "Jose", "Pepe", DateTime.Parse("05/05/2000"));
                facultadUBA.AgregarEmpleado(e);


                bool consolaActiva = true;

                while (consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionMenu = Console.ReadLine();

                    switch (opcionMenu)
                    {
                        case "1":
                            AgregarAlumnos(facultadUBA);
                            break;

                        case "2":
                            AgregarEmpleados(facultadUBA);
                            break;

                        case "3":
                            EliminarA(facultadUBA);
                            break;

                        case "4":
                            EliminarE(facultadUBA);
                            break;

                        case "5":
                            modificarEmpleado(facultadUBA);
                            break;

                        case "6":
                            TraerListaAlumnos(facultadUBA);
                            break;

                        case "7":
                            TraerListaEmpleados(facultadUBA);
                            break;

                        case "x":
                            consolaActiva = false;
                            break;

                        default:
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general");
            }

        }
        public static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Seleccione la opcion deseada: " + "\n" + "1 - Agregar alumno. " + "\n" + "2 - Agregar empleado. "
                + "\n" + "3 - Eliminar alumno. " + "\n" + "4 - Eliminar empleado. " + "\n" + "5 - Modificar empleado. " + "\n" + "6 - Traer alumnos. " +"\n" + "7 - Traer empleados. ");
        }

        public static void AgregarAlumnos(Facultad facultadUBA)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese un apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            DateTime fechanacimiemnto = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el codigo del alumno: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Alumno a = new Alumno(codigo, apellido, nombre, fechanacimiemnto);
            facultadUBA.AgregarAlumno(a);
        }

        public static void AgregarEmpleados(Facultad facultadUBA)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese un apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            DateTime fechanacimiemnto = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de ingreso: ");
            DateTime fechaingreso = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el legajo: ");
            int legajo = Convert.ToInt32(Console.ReadLine());

            Empleado e = new Empleado (fechaingreso, legajo, nombre, apellido, fechanacimiemnto);
            facultadUBA.AgregarEmpleado(e);
        }

        public static void EliminarA(Facultad facultadUBA)
        {
            Console.WriteLine("Ingrese el codigo del alumno que desea eliminar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            facultadUBA.EliminarAlumno(codigo);
        }

        public static void EliminarE(Facultad facultadUBA)
        {
            Console.WriteLine("Ingrese el legajo del empleado que desea eliminar: ");
            int legajo = Convert.ToInt32(Console.ReadLine());

            facultadUBA.EliminarEmpleado(legajo);
        }

        public static void modificarEmpleado(Facultad facultadUBA)
        {

        }

        public static void TraerListaAlumnos(Facultad facultadUBA)
        {
            facultadUBA.TraerAlumnos();
        }

        public static void TraerListaEmpleados(Facultad facultadUBA)
        {
            facultadUBA.TraerEmpleados();
        }


    }

}
