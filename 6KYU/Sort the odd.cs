// https://www.codewars.com/kata/578aa45ee9fd15ff4600090d

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] % 2 != 0 && array[i] > array[j])
                    {
                        array[i] = array[i] + array[j];
                        array[j] = array[j] - array[i];
                        array[j] = -array[j];
                        array[i] = array[i] - array[j];
                    }
                }
            }
        }
        return array;
    }
}