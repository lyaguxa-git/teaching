using UnityEngine;

    public class FirstOfOccurrence: MonoBehaviour
    {
        public void OnFirstOccurrence()
        {
            int[] array = { 81, 22, 13, 55, 10, 34, 15, 26, 71, 68 };
            int value = 34;
            int want = 5;
            int got = FirstOccurrence(array, value);
            string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
            Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
        }

        private int FirstOccurrence(int[] array, int value)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == value)
                {
                    return i;
                }
            }
            
            return -1;
        }
    }
