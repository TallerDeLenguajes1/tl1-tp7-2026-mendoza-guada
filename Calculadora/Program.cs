using EspacioCalculadora;// See https://aka.ms/new-console-template for more information

Console.WriteLine("========CALCULADORA=========");

int sino=0;
do
{
    Console.WriteLine("¿Qué operación desea realizar?\n1-Suma\n2-Resta\n3-Multiplicación\n4-División");
    int opcion = int.Parse(Console.ReadLine());
    if (opcion<1 || opcion>4)
    {
        Console.WriteLine("Opción incorrecta");
        continue;
    }
    Console.WriteLine("Ingrese el primer número: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    Calculadora calc= new Calculadora();

    calc.dato=num1;
    switch (opcion)
    {
        case 1: 
            calc.Sumar(num2);
            Console.WriteLine("La suma es: "+calc.Resultado());
            break;
        case 2: 
            calc.Restar(num2);
            Console.WriteLine("La resta es: "+calc.Resultado());
            break;
        case 3: 
            calc.Multiplicar(num2);
            Console.WriteLine("La multiplicación es: "+calc.Resultado());
            break;
        case 4:
            calc.Dividir(num2);
            Console.WriteLine("La división es: "+calc.Resultado());
            break; //CORREGIR
    }
    Console.WriteLine("\n¿Desea continuar operando? 1-Sí 0-No");
    sino= int.Parse(Console.ReadLine());
} while (sino!=0);




