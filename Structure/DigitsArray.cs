namespace CSharpAlgorithms.Structure
{
    public class DigitsArray
    {
        private readonly int[] digits;
        private int count;

        public DigitsArray(int max)
        {
            digits = new int[max];
            count = 0;
        }
        //---------------------------вставка числа в конец массива---------------------------------
        public void Insert(int number)
        {
            digits[count++] = number;
        }
        //------------------------------лицейный поиск числа---------------------------------------
        public bool Find(int searchNumber)
        {
            int i;
            for (i = 0; i < count; i++)
            {
                if (digits[i] == searchNumber) break;
            }
            return (i == count) ? false : true;
        }
        //-----------------------удаление числа из массива с линейным поиском----------------------
        public bool Delete(int searchNumber)
        {
            int i;
            for(i = 0; i < count; i++)
            {
                if (digits[i] == searchNumber) break;
            }
            if(i == count)
            {
                return false;
            }
            else
            {
                for(int j = i; j < count - 1; j++)
                {
                    digits[j] = digits[j + 1];
                }
                count--;
                return true;
            }
        }
        //---------------------------вывод на экран содержимого------------------------------------
        public void Show()
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write($@"{digits[i]} ");
            }
            Console.WriteLine();
        }
    }
}
