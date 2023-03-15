namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            int GetNegativNumber = 0;
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(@"C:\laba\.txt")) // это класс который позволяет вписывать символы
                for (int i = 0; i < mass.Length; i++)
                    sw.WriteLine(random.Next(-10, 10));
            using (StreamReader sr = new StreamReader(@"C:\laba\.txt")) // это класс который позволяет считывать символы
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = int.Parse(sr.ReadLine()); 
                }
            }
            int max = mass.Max();
            int min = mass.Min();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= 0) 
                {
                    GetNegativNumber++;
                }
            }
            Console.WriteLine("Максимум:{0}\nМинимум:{1}\nКоличество отрицательных цифр:{2}", max, min, GetNegativNumber);

        }
    }
}