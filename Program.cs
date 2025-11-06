internal class Program
{
    private static void Main(string[] args)
    {
        /*
        int[] mangnguyen = new int[20];
        for (int i = 0; i < mangnguyen.Length; i++)
            mangnguyen[i] = i * 10;
        foreach (int value in mangnguyen)
            Console.Write($"{value} ");
        */

        /*int[] ar = new int[20];
        Random r = new Random();
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
        int[] input = { 7, 3, 7, 2, 2, 9, 6 };
        string result = " ";
        for (int i = 0; i < input.Length - 1; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    for (int k = 0; k < result.Length; k++)
                    {
                        if (input[i] == result[k])
                            break;
                        result = result + input[i];
                        break;
                    }
                }
            }
        }
        Console.WriteLine("Result: "+result);
    }
}