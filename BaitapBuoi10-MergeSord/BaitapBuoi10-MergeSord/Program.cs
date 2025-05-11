using System.Diagnostics;

namespace BaitapBuoi10_MergeSord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch dem = new Stopwatch();
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mang ban dau:");
            DuyetMang(arr);
            dem.Start();
            MergeSort(arr, 0, arr.Length - 1);
            dem.Stop();

            Console.WriteLine("Thoi gian thuc thi: " + dem.ElapsedMilliseconds + " ms");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mang sau khi sap xep:");
            DuyetMang(arr);
        }

        static void MergeSort(int[] arr, int trai, int phai)
        {
            if (trai >= phai) return; 
            int giua = (trai + phai) / 2;
            MergeSort(arr, trai, giua);
            MergeSort(arr, giua + 1, phai);
            Merge(arr, trai, giua, phai);
        }

        static void Merge(int[] arr, int trai, int giua, int phai)
        {
            int[] temp = new int[phai - trai + 1];
            int i = trai, j = giua + 1, k = 0;
            while (i <= giua && j <= phai) temp[k++] = (arr[i] <= arr[j]) ? arr[i++] : arr[j++];
            while (i <= giua) temp[k++] = arr[i++];
            while (j <= phai) temp[k++] = arr[j++];
            Array.Copy(temp, 0, arr, trai, temp.Length);
        }

        static void DuyetMang(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
