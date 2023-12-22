internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите число от 0 до 30: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int[] intsArray = new int[50];

            if (choice > 30 || choice < 0)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            for (int i = 0; i < intsArray.Length; i++)
            {
                intsArray[i] = new Random().Next(0, 31);
            }

            for (int i = 0; i < intsArray.Length; i++)
            {
                if (choice == intsArray[i])
                {
                    Console.WriteLine("Да, это число есть в массиве");
                    return;
                }
            }
            Console.WriteLine("Нет, этого числа нет в массиве");
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка");
            return;
        }
    }
}