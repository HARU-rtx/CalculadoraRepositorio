namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string operador 
            
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Solicita o operador
            

            
            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine();


            switch (operador)
            {

                //adição



                //subtração




                case "*":
                    Console.WriteLine("O resultado da divisão é: " + (num1 * num2));
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero");
                    }
                    else
                    {
                        Console.WriteLine("O resultado da divisão é: " + (num1 / num2));
                    }



            }
            


        }
    }
}
