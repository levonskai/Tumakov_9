namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (count <= 0 || width <= 0 || length <= 0)
            {
                return -1;
            }

            float area = width * length;
            double total = 0;

            if (productType == 1)
            {
                total = area * count * 1.1;
            }
            else if (productType == 2)
            {
                total = area * count * 2.5;
            }
            else if (productType == 3)
            {
                total = area * count * 8.43;
            }
            else
            {
                return -1;
            }


            if (materialType == 1)
            {
                total = total * 0.003 + total;
            }
            else if (materialType == 2)
            {
                total = total * 0.0012 + total;
            }
            else
            {
                return -1;
            }

            return (int)total;
        }
    }
}
