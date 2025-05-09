using UnityEngine;

    public class SumOfEvenNumbersInArray : MonoBehaviour
    {
        public void OnSumEvenNumbersInArray()
        {
            int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
            int want = 214;
            int got = SumEvenNumbersInArray(array);
            string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
            Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
        }
        private int SumEvenNumbersInArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    temp += array[i];
                }

            }
            return temp;
        }
    }

