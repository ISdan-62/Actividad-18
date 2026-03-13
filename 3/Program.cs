int opcion = 0;
do
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Calcular el área de un círculo");
    Console.WriteLine("2. Calcular el área de un triángulo");
    Console.WriteLine("3. Calcular el factorial de un número");
    Console.WriteLine("4. Determinar si un número es par o impar");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elegir la opcion a realizar: ");
    opcion=int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                int radio = 0;
                Console.WriteLine("Ingrese el radio del circulo: ");
                radio=int.Parse(Console.ReadLine());
                double area(int radio)
                {
                    return Math.PI * (radio * radio);
                }
                double resultado=area(radio);
                void mostrar()
                {
                    Console.WriteLine($"El area del circulo es de: {resultado}");
                }
                mostrar();
                break;
            }
        case 2:
            {
                Console.WriteLine("Ingrese la base del triangulo: ");
                double vase = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo: ");
                double altura = int.Parse(Console.ReadLine());
                double area(double vase, double altura)
                {
                    return (vase*altura)/2;
                }
                double resultado = area(vase, altura);
                void mostrar()
                {
                    Console.WriteLine($"El area del triangulo es de: {resultado}");
                }
                mostrar();
                break;
            }
        case 3:
            {
                Console.WriteLine("Ingrese el numero: ");
                int numero = int.Parse(Console.ReadLine());
                double factorial(int numero)
                {
                    int acumular = 1;
                    for (int repetir = 1; repetir <= numero; repetir++)
                    {
                        acumular *= repetir;
                    }
                    return acumular;
                }
                double resultado = factorial(numero);
                void mostrar()
                {
                    Console.WriteLine($"El factorial del numero es: {resultado}");
                }
                mostrar();
                break;
            }
        case 4:
            {
                Console.WriteLine("Ingrese el numero: ");
                int numero = int.Parse(Console.ReadLine());
                double determinar(int numero)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("numero par");
                    }
                    else
                    {
                        Console.WriteLine("Numero impar");
                    }
                    return numero;
                }
                double resultado = determinar(numero);
                void mostrar()
                {
                    Console.WriteLine($"El factorial del numero es de: {resultado}");
                }
                mostrar();
                break;
            }
        case 5:
            {
                Console.WriteLine("Salida");
                break;
            }
            default:
            {
                Console.WriteLine("Opcion invcalida");
                break;
            }
    }
} while (opcion != 5);