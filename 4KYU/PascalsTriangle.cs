using System.Collections.Generic;

namespace Clock_Kata
{
    public static class PascalsTriangleClass
    {
        public static List<int> PascalsTriangle(int n)
        {
            List<int> listTriangle = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int currentItem = 1;
                for (int j = 0; j <= i; j++)
                {
                    listTriangle.Add(currentItem);
                    currentItem = currentItem * (i - j) / (j + 1);
                }
            }
            return listTriangle;
        }
    }


}
        