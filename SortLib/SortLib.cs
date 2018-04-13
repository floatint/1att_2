using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortLib
{

    public class MergeSort
    {


        public struct DeviceData
        {
            public int x;
            public double y;
        }


        //Слияние подмассивов
        private static DeviceData[] Merge(DeviceData[] leftArr, DeviceData[] rightArr)
        {
            int a = 0, b = 0;
            DeviceData[] merged = new DeviceData[leftArr.Length + rightArr.Length];
            int i = 0; //index in merged
            while ((a < leftArr.Length) && (b < rightArr.Length))
            {
                if (leftArr[a].y < rightArr[b].y)
                    merged[i++] = rightArr[b++];
                else
                    merged[i++] = leftArr[a++];
            }
            while (b < rightArr.Length)
            {
                merged[i++] = rightArr[b++];
            }
            while (a < leftArr.Length)
            {
                merged[i++] = leftArr[a++];
            }
            return merged;
        }

        public static DeviceData[] Sort(DeviceData[] arr)
        {
            //sort
            if (arr.Length == 1)
                return arr;
            int middle = arr.Length / 2; //разбиение массива на 2 части. Средняя точка.
            return Merge(Sort(arr.Take(middle).ToArray()), Sort(arr.Skip(middle).ToArray()));
        }

    }

    public class QuickSort
    {

        public static Bitmap DrawState(ref int[] arr, int i, int j, bool story)
        {
            int ElementWidth = 30; // ширина одного элемента
            int ElementHeight = 30; //высота одного элемента
            int NumberX = 5; //оффсет начала циферки в квадрате
            int NumberY = 3;
            int SpaceBetweenElem = 5; //расстояние между квадратами
            int CurrentXPos = 0; //начинаем с нуля
            SolidBrush redGradient = new SolidBrush(Color.Red); //для элементов, которые меняются
            SolidBrush greyGradient = new SolidBrush(Color.FromArgb(100, 0, 0, 0)); //для истории
            SolidBrush textBrush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 3); //рамка квадрата
            Font font = new Font("Arial", 16); //для цифр
            Bitmap map = new Bitmap((ElementWidth * arr.Length) + (SpaceBetweenElem * arr.Length - 1), 30);
            Graphics mapGraphics = Graphics.FromImage(map);
            //рисуем
            for (int c = 0; c < arr.Length; c++)
            {
                mapGraphics.DrawRectangle(pen, CurrentXPos, 0, ElementWidth, ElementHeight);
                if ((c == i) || (c == j))
                {
                    mapGraphics.FillRectangle(redGradient, CurrentXPos, 0, ElementWidth, ElementHeight);
                }
                mapGraphics.DrawString(arr[c].ToString(), font, textBrush, CurrentXPos + NumberX, NumberY);

                if (story)
                {
                    mapGraphics.FillRectangle(greyGradient, CurrentXPos, 0, ElementWidth, ElementHeight);
                }
                CurrentXPos += ElementWidth + SpaceBetweenElem;
            }

            return map;
        }

        public static void Visual(int[] a, int l, int r, ref Bitmap[] current, ref Bitmap[] story)
        {
            Random rnd = new Random();
            int arrSize = 11;
            int[] arr = null;
            int left = 0 ,right = 0;
            if (a == null)
            {
                arr = new int[arrSize];
                for (int k = 0; k < arr.Length; k++)
                {
                    arr[k] = rnd.Next(10);
                }
                left = 0;
                right = arr.Length - 1;
            }
            else
            {
                arr = a;
                left = l;
                right = r;
            }
            int i = left, j = right;
            int kernel = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < kernel)
                {
                    i++;
                }
                while (arr[j] > kernel)
                {
                    j--;
                }
                if (i <= j)
                {
                    Array.Resize<Bitmap>(ref current, current.Length + 1);
                    current[current.Length - 1] = DrawState(ref arr, i, j, false);
                    Array.Resize<Bitmap>(ref story, story.Length + 1);
                    story[story.Length - 1] = DrawState(ref arr, i, j, true);
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Visual(arr, left, j, ref current, ref story);
            }

            if (i < right)
            {
                Visual(arr, i, right, ref current, ref story);
            }

        }


        //returns the number of exchanges
        public static int Sort(int[] arr, int left, int right)
        {
            int count = 0;
            int i = left, j = right;
            int kernel = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < kernel)
                {
                    i++;
                }
                while (arr[j] > kernel)
                {
                    j--;
                }
                if (i <= j)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                    count++;
                }
            }
            if (left < j)
            {
                count += Sort(arr, left, j);
            }

            if (i < right)
            {
                count += Sort(arr, i, right);
            }
            return count;
        }


        public static DataPoint[] SortSeries()
        {
            Random rnd = new Random();
            const int chartItemCnt = 4; //10 замеров
            DataPoint[] result = new DataPoint[chartItemCnt];
            int baseElemCnt = 100; //начинаем со ста, увеличивая до
            int curElemCnt = baseElemCnt; //кол-во элементов для след. замера
            for (int i = 0; i < chartItemCnt; i++)
            {
                int[] arr = new int[curElemCnt];
                for (int j = 0; j < curElemCnt; j++)
                {
                    arr[j] = rnd.Next(10000);
                }
                result[i] = new DataPoint(curElemCnt, QuickSort.Sort(arr, 0, arr.Length - 1));
                curElemCnt += curElemCnt;
            }
            return result;
        }
    }

    public class BubbleSort
    {
        public static int Sort(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                        count++;
                    }
                }
            }
            return count;
        }

        public static DataPoint[] SortSeries()
        {
            Random rnd = new Random();
            const int chartItemCnt = 4; //10 замеров
            DataPoint[] result = new DataPoint[chartItemCnt];
            int baseElemCnt = 100; //начинаем со ста, увеличивая до
            int curElemCnt = baseElemCnt; //кол-во элементов для след. замера
            for (int i = 0; i < chartItemCnt; i++)
            {
                int[] arr = new int[curElemCnt];
                for (int j = 0; j < curElemCnt; j++)
                {
                    arr[j] = rnd.Next(10000);
                }
                result[i] = new DataPoint(curElemCnt, BubbleSort.Sort(arr));
                curElemCnt += curElemCnt;
            }
            return result;
        }
    }
}
