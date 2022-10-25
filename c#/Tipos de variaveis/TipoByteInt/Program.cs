
byte v1 = 10;


Console.WriteLine("");
Console.WriteLine("O valor de V1 é: {0}",v1);

Console.WriteLine("O tipo é: {0}", v1.GetType());

Console.WriteLine("Digite um valor na faixa de 0 a 255");








//var Vdigitado = Console.ReadLine();

try
{

    byte vdigitado = Convert.ToByte(Console.ReadLine());
     Console.WriteLine("O valor digitado é byte");

}
catch (OverflowException)
{
    Console.WriteLine("O valor digitado não é byte");

}










//if (Vdigitado <= 255) 
//{
  //  Console.WriteLine("O valor digitado é byte");
//}
//else
//{
 //   Console.WriteLine("O valor digitado não é byte");
//}


Console.WriteLine("O valor digitado é: {0}");
Console.ReadKey();


