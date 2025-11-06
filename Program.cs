internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        /*
        int[] mangnguyen = new int[20];
        for (int i = 0; i < mangnguyen.Length; i++)
            mangnguyen[i] = i * 10;
        foreach (int value in mangnguyen)
            Console.Write($"{value} ");
        */

        /*int[] ar = new int[20];
        for (int i = 0; i < ar.Length; i++)
            ar[i] = r.Next(1, 99);
        foreach (int value in ar)
            Console.Write(value + ", ");*/
        //Tìm min, max của mảng
        /*int min = ar[0], max = ar[0];
        for(int i=1; i<ar.Length; i++)
        {
            if (max < ar[i]) max = ar[i];
            if (min > ar[i]) min = ar[i];
        }
        Console.WriteLine($"Min={min}, Max={max}");*/

        //Tính tổng mảng
        /*int Tong = 0;
        for (int i = 0; i < ar.Length; i++)
            Tong = Tong + ar[i];
        Console.WriteLine($"Tong={Tong}");*/

        //Sao chép mảng
        /*int[] b = new int[ar.Length];
        for (int i = 0; i < b.Length; i++)
            b[i] = ar[i];*/
        //--> Không được gán trực tiếp 2 mảng: b = a; !!!!!

        //Kiểm tra phần tử lặp
        /*int[] input = { 7, 6, 3, 6, 7, 2, 2, 9, 6, 5, 5 };
        
        string result = " ";
        for (int i = 0; i < input.Length - 1; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    bool flag = false;
                    for (int k = 0; k < result.Length; k++)
                    {
                        if (input[i].ToString()[0] == result[k])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if(!flag)
                        result = result + input[i];
                }
            }
        }
        Console.WriteLine("Result: "+result);
        */
        /*
        int[] b = new int[input.Length];
        //Sao chép mảng input sang mảng b
        for (int i = 0; i < b.Length; i++)
            b[i] = input[i];
        //Sắp xếp mảng b
        for (int i = 0; i < b.Length - 1; i++)
            for (int j = i + 1; j < b.Length; j++)
                if (b[i] > b[j]){
                    int temp = b[i];
                    b[i] = b[j];
                    b[j] = temp;
                }
        string result2 = "";
        for (int i = 1; i < b.Length - 1; i++)
            if (b[i] != b[i + 1] && b[i - 1] == b[i]){
                result2 = result2 + b[i];
            }
        if (b[b.Length - 2] == b[b.Length - 1])
            result2 = result2 + b[b.Length - 2];
        Console.WriteLine("Result 2: "+result2);
        */

        //==========Mảng nhiều chiều==========
        int[,] matrix = new int[4, 4];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = r.Next(1, 99);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write("{0, 3}", matrix[i, j]);
            Console.WriteLine();
        }
        int Tong2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (i == j)
                    Tong2 = Tong2 + matrix[i, j];
        Console.WriteLine($"Tong cac phan tu tren duong cheo chinh: {Tong2}");
        
    }
}