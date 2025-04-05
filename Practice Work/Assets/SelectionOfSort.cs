
    using System.Linq;
    using UnityEngine;
using UnityEngine.UIElements;

public class SelectionOfSort : MonoBehaviour
    {

        public void OnSelectionSort()
        {
            int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
            Debug.LogFormat("Исходный массив {0}", "[" + string.Join(",", originalArray) + "]");

            int[] sortedArray = SelectionSort((int[])originalArray.Clone());
            Debug.LogFormat("Результат сортировки {0}", "[" + string.Join(",", sortedArray) + "]");

            int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
            Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "Результат верный" : "Результат не верный");
        }
        private int[] SelectionSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j]>array[j + 1])
                    {
                        temp = array[j];
                        array[j]=array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
