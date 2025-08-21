namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem : Convert a decimal number to binary using a stack.
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            Stack<int> binaryStack = new Stack<int>();
            while (decimalNumber > 0)
            {
                binaryStack.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }
            Console.Write("Binary representation: ");
            while (binaryStack.Count > 0)
            {
                Console.Write(binaryStack.Pop());
            }
            

        }
    }
}
