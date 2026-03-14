int opcion = 0;
double sumaPromedios = 0;
int totalEstudiantes = 0;
int aprobados = 0;
int reprobados = 0;
do
{
    Console.WriteLine("MENU");
    Console.WriteLine("1. Registrar estudiante");
    Console.WriteLine("2. Mostrar promedio general");
    Console.WriteLine("3. Mostrar cantidad de aprobados y reprobados");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Ingrese la opcion a realizar: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();
                double sumaNotas = 0;
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Ingrese la nota {i}: ");
                    double nota = double.Parse(Console.ReadLine());
                    sumaNotas += nota;
                }
                double calcularPromedio(double suma)
                {
                    return suma / 3;
                }
                double promedio = calcularPromedio(sumaNotas);
                string estado;
                if (promedio >= 61)
                {
                    estado = "Aprobado";
                }
                else
                {
                    estado = "Reprobado";
                }
                void resultado()
                {
                    Console.WriteLine("RESULTADO DEL ESTUDIANTE");
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Promedio: {promedio}");
                    Console.WriteLine($"Estado: {estado}");
                }
                resultado();
                sumaPromedios += promedio;
                totalEstudiantes++;
                if (estado == "Aprobado")
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
                break;
            }
        case 2:
            {
                if (totalEstudiantes > 0)
                {
                    double promedioGeneral = sumaPromedios / totalEstudiantes;
                    Console.WriteLine($"Promedio general: {promedioGeneral}");
                }
                else
                {
                    Console.WriteLine("No hay estudiantes registrados.");
                }
                break;
            }
        case 3:
            {
                Console.WriteLine($"Cantidad de aprobados: {aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {reprobados}");
                break;
            }
        case 4:
            {
                Console.WriteLine("Salida del sistema");
                break;
            }
        default:
            {
                Console.WriteLine("Opcion Invalida");
                break;
            }
    }
} while (opcion != 4);