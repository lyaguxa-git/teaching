    using UnityEngine;
using UnityEngine.UIElements;

public class SumOfEvenNumbersInRange : MonoBehaviour
    {
        public void OnSumEvenNumbersInRange()
        {
            int min = 7;
            int max = 21;
            var want = 98;
            int got = SumEvenNumbersInRange(min, max);
            string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
            Debug.Log($"Сумма четных чисел в диапазоне от {min} до {max} включительно: {got} - {message}");
        }
        private int SumEvenNumbersInRange(int min, int max)
        {
            int temp = 0;
            for (;min <= max; min++)
            {
                if(min % 2 == 0)
                {
                    temp += min;
                }

            }
            return temp;
        }
    }
