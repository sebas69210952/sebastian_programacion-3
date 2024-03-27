using System;
plublic class Numero
{
    static void ejercicio1()
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());
        int mayor = ObtenerMayorDigito(numero);
        Console.WriteLine("El mayor dígito es: " + mayor);
    }

    static void ejercicio2()
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());
        int sumaPares = SumarDigitosPares(numero);
        Console.WriteLine("La suma de los dígitos pares es: " + sumaPares);
    }

    static void ejercicio3()
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());
        int numeroMovido = MoverMayorAlFinal(numero);
        Console.WriteLine("El número con el mayor dígito al final es: " + numeroMovido);
    }

    static void ejercicio4()
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());
        bool ordenado = EstaOrdenado(numero);
        Console.WriteLine("¿El número está ordenado en sus dígitos?: " + ordenado);
    }

    static void ejercicio5()
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());
        int cantidadImparesAntesPar = CantDigParesAntesDePar(numero);
        Console.WriteLine("La cantidad de dígitos impares antes de uno par es: " + cantidadImparesAntesPar);
    }

    static int ObtenerMayorDigito(int numero)
    {
        int mayor = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            mayor = Math.Max(mayor, digito);
            numero /= 10;
        }
        return mayor;
    }

    static int SumarDigitosPares(int numero)
    {
        int suma = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito % 2 == 0)
                suma += digito;
            numero /= 10;
        }
        return suma;
    }

    static int MoverMayorAlFinal(int numero)
    {
        int mayor = 0;
        int resto = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito > mayor)
                mayor = digito;
            else
                resto = resto * 10 + digito;
            numero /= 10;
        }
        return resto * 10 + mayor;
    }

    static bool EstaOrdenado(int numero)
    {
        int anterior = 10;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito > anterior)
                return false;
            anterior = digito;
            numero /= 10;
        }
        return true;
    }

    static int CantDigParesAntesDePar(int numero)
    {
        int impares = 0;
        bool encontradoPar = false;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (!encontradoPar && digito % 2 == 0)
                encontradoPar = true;
            else if (encontradoPar && digito % 2 != 0)
                impares++;
            numero /= 10;
        }
        return impares;
    }

}