



using Tipos_de_variaveis;



int num1 = 5;
    int num2 = num1;
    int resultado = num1 + num2;
    num1 = 6;

 Console.WriteLine("valor do num 1 é: {0} e está na stack", num1.ToString());
 Console.WriteLine("valor do num 2 é: {0} e está na stack", num2.ToString());
 Console.ReadKey();

 Console.WriteLine("Calculadora");
 Calculadora minhaCalculadora = new Calculadora();
 minhaCalculadora.somar();

 Console.ReadKey();

 Console.WriteLine("Variaveis nulla");
int? altura = null;

if (altura.HasValue)
{


    Console.WriteLine("O valor é: {0}: ", altura);


}
else
{


    Console.WriteLine("Altura está nullo");


}
Console.ReadKey();

