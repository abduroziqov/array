namespace fill_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;

            FillArray(ref row, ref col);
            GetNumber(row, col);
        }

        public static void FillArray(ref int row, ref int col)
        {
            Console.Write("Enter row value=> ");
            row = int.Parse(Console.ReadLine());

            Console.Write("Enter column value=> ");
            col = int.Parse(Console.ReadLine());
        }
        public static void GetNumber(int row, int column)
        {
            Random random = new Random();
            int[,] array = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(10, 99);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}