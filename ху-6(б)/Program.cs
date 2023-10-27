// See https://aka.ms/new-console-template for more information
//Console.WriteLine("test_text");
//int[,] n= new int[12,12];
//for (int i = 0; i < m.Length; i++)
//{
//    Console.WriteLine(m[i]);
//}
//int[] m = new int[12];
//int m1 =int.Parse(Console.ReadLine());
//m = new int[m1];
//Console.WriteLine("Строки:");
//int m1=int.Parse(Console.ReadLine());
//int[] m=new int[m1];
//Console.WriteLine("Столбцы:");
//int n1=int.Parse(Console.ReadLine());

//int[] n=new int[n1];

//Console.WriteLine("среднее геометрическое:" + Math.Sqrt(n1*m1));


//void meth()
//{
//    int[,] g = new int[4, 8];
//    Random random = new Random();
//    for (int x = 0; x < g.GetLength(0); x++)
//    {
//        for (int y = 0; y < g.GetLength(1); y++)
//        {
//            g[x, y] = random.Next(1, 10);

//        }
//    }

//    for (int i = 0; i < g.GetLength(0); i++)
//    {
//        for (int c = 0; c < g.GetLength(1); c++)
//        {
//            Console.Write(g[i, c] + "\t");
//        }
//    }

//}
//meth();
class Program
{
    static double CalculateAverageGeometric(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int count = 0;
        double product = 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    count++;
                    product *= matrix[i, j];
                }
            }
        }

        if (count == 0)
        {
            return 0;
        }

        return Math.Pow(product, 1.0 / count);
    }

    static void Main(string[] args)
    {        
        int rows = 4;
  
        int cols = 8;

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введите элементы матрицы:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Элемент [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        double averageGeometric = CalculateAverageGeometric(matrix);
        Console.WriteLine($"Среднее геометрическое положительных элементов матрицы: {averageGeometric}");

        Console.ReadLine();
    }
}