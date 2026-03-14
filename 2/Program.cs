int opcion = 0;
double totalVendido = 0;
int cantidadVentas = 0;
double ventaMayor = 0;
do
{
    Console.WriteLine("\n1. Registrar venta");
    Console.WriteLine("2. Mostrar total vendido");
    Console.WriteLine("3. Mostrar promedio de ventas");
    Console.WriteLine("4. Mostrar venta mayor registrada");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Ingrese la opcion a realizar: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                Console.Write("Nombre del producto: ");
                string producto = Console.ReadLine();
                Console.Write("Cantidad vendida: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Precio por unidad: ");
                double precio = double.Parse(Console.ReadLine());
                double registrar(int cantidad, double precio)
                {
                    return cantidad * precio;
                }
                double resultado = registrar(cantidad, precio);
                void mostrar()
                {
                    Console.WriteLine("\nRESULTADOS");
                    Console.WriteLine($"Producto: {producto}");
                    Console.WriteLine($"Cantidad: {cantidad}");
                    Console.WriteLine($"Precio por unidad: Q{precio}");
                    Console.WriteLine($"Total de venta: Q{resultado}");
                }
                mostrar();

                totalVendido += resultado;
                cantidadVentas++;
                if (resultado > ventaMayor)
                {
                    ventaMayor = resultado;
                }
                break;
            }
        case 2:
            {
                Console.WriteLine($"Total vendido: Q{totalVendido}");
                break;
            }
        case 3:
            {
                if (cantidadVentas > 0)
                {
                    double promedio = totalVendido / cantidadVentas;
                    Console.WriteLine($"Promedio de ventas: Q{promedio}");
                }
                else
                {
                    Console.WriteLine("No hay ventas registradas.");
                }
                break;
            }
        case 4:
            {
                Console.WriteLine($"Venta mayor registrada: Q{ventaMayor}");
                break;
            }
        case 5:
            {
                Console.WriteLine("Salida");
                break;
            }
        default:
            {
                Console.WriteLine("Opcion Invalida");
                break;
            }
    }
} while (opcion != 5);