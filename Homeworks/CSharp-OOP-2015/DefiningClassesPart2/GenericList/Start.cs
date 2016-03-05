namespace GenericList
{
    using System.Collections.Generic;
    using System.Linq;

    public class Start
    {
        public static void Main()
        {
            var cSharpGenericList = new List<int>();
            var myGenericList = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                cSharpGenericList.Add(i + 1);
                myGenericList.Add(i + 1);
            }

            myGenericList.RemoveAt(6);
            cSharpGenericList.RemoveAt(6);
            myGenericList.Insert(6, 7);
            cSharpGenericList.Insert(6, 7);
            myGenericList.RemoveAt(5);
            cSharpGenericList.RemoveAt(5);
            myGenericList.Insert(5, 6);
            cSharpGenericList.Insert(5, 6);
            cSharpGenericList.Min();
            myGenericList.Min();
            cSharpGenericList.Max();
            myGenericList.Max();
        }
    }
}