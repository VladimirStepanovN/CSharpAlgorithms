using CSharpAlgorithms.Structure;

namespace CSharpAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------структура массив чисел-----------------------------------
            DigitsArray da = new DigitsArray(5);
            da.Insert(1);
            da.Insert(2);
            da.Show();
            da.Delete(1);
            da.Show();
            da.Insert(3);
            da.Insert(4);
            da.Show();
            //-------------------------------------------------------------------------------------
        }
    }
}