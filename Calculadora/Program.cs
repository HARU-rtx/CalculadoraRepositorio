namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o operador: ");
            char operador = Convert.ToChar(Console.ReadLine());
            switch (operador)
            {
                case '+':
                    Console.WriteLine("O resultado da conta é: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("O resultado da conta é: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("O resultado da conta é: " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("O resultado da conta é: " + (num1 / num2));
                    break;
            

            }
    }
}
