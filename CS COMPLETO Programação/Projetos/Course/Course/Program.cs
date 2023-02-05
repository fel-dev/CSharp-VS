using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Mostrando o que acontece quando flopa a memória");

            SByte x = 100;
            Console.WriteLine("Valor de SByte x = " + x);
            x = 127;
            Console.WriteLine("Valor máximo de SByte x = " + x);
            x++;
            Console.WriteLine("Quando o valor de SByte x = x++. Ao invez de dar erro, ele volta prp máximo oposto que é: " + x);

            byte n1 = 255;
            Console.WriteLine("Valor de byte n1 = " + n1);
            n1++;
            Console.WriteLine("Quando estrapola (n1++) a quantidade (256/255 bytes) byte n1 = " + n1);

            int n2 = 1000;
            Console.WriteLine("int n2 = " + n2);

            int n3 = 2147483647;
            Console.WriteLine("int n3 = " + n3);
            n3++;
            Console.WriteLine("int n3++ = " + n3);

            long n4 = 2147483648L;
            Console.WriteLine("long n4 = " + n4);
            n4++;
            Console.WriteLine("long n4++ = " + n4);

            Console.WriteLine("para testar alguma coisa no programa usar o bool");
            bool completo = false;
            Console.WriteLine(completo);

            Console.WriteLine("pode colocar o 'F' ou o unicode '0041'");
            char sexo = 'F';
            Console.WriteLine("char sexo = " + sexo);
            char letra = '\u0041';
            Console.WriteLine("char letra = \\u0041. Aparecerá letra = " + letra);

            float n5 = 4.5f;
            Console.WriteLine("float n5 = 4.5f, aparece " + n5);
            double n6 = 4.5;
            Console.WriteLine("double n6 = 4.5, aparece " + n6);

            string nome = "Maria Green";
            Console.WriteLine("string nome = \"maria Green\", aparece" + nome);

            Console.WriteLine("\"object\" aceita qualquer coisa\nPor exemplo, object ob1 = \"Alex Brown\"\n\nExemplo 2, object obj2 = \"4.6f\"\n\n");
            object obj1 = "Alex Brown";
            Console.WriteLine("obj1 " + obj1);
            object obj2 = 4.5f;
            Console.WriteLine("obj2 " + obj2);

            string linha = "---------------------------------------------------";
            Console.WriteLine("\n" + linha);
            Console.WriteLine("\nDa pra armazenar o mínimo e o máximo valor com por exemplo\n\n");
            int n7 = int.MinValue;
            Console.WriteLine("int n7 = int.MinValue;\nn7 = " + n7);
            int n8 = int.MaxValue;
            Console.WriteLine("\nint n8 = int.MaxValue;\nn8 = " + n8);
            sbyte n9 = sbyte.MinValue;
            sbyte n10 = sbyte.MaxValue;
            Console.WriteLine("\nsbyte n9 = sbyte.MinValue;\nn9 = " + n9);
            Console.WriteLine("\nsbyte n10 = sbyte.MaxValue;\nn10 = " + n10 );

            decimal n11 = decimal.MaxValue;
            Console.WriteLine("\ndecimal n11 = decimal.MaxValue;\nn11 = "+ n11);

            Console.WriteLine(linha);
            double saldo = 10.35764;
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // Preicisa adicionar using System.Globalization;


            Console.WriteLine(linha);
            Console.WriteLine("Placaholders, concateneção e interpolação");
            int idade = 32;
            double saldo2 = 10.35784;
            string nome2 = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade, saldo2);
            Console.WriteLine($"{nome2} tem {idade} anos e tem saldo igual a {saldo2:F2} reais");
            Console.WriteLine(nome2 + " tem " + idade + " anos e tem saldo igual a " + saldo2.ToString("F2", CultureInfo.InvariantCulture) + " reais");


            Console.WriteLine(linha);
            Console.WriteLine("Operadores aritméticos");
        }

    }
}