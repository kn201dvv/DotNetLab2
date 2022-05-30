using ClassLibraryLab2;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        string example = "This is the check!";
        int result = example.Count('h');
        Console.WriteLine(result);

        string example2 = "ecnetnes esreveR";
        string result2 = example2.Reverse();
        Console.WriteLine(result2);

        int[] example3 = new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 3, 4, 0 };
        int result3 = example3.Count(3);
        Console.WriteLine(result3);
        double[] example3_1 = new double[] { 1f, 2f, 3f, 4f, 5f, 1f, 2f, 3f, 3f, 4f, 0f, 3f };
        double result3_1 = example3_1.Count(3f);
        Console.WriteLine(result3_1);

        int[] example4 = new int[] { 1, 7, 3, 4, 4, 4, 0, 1 };
        var result4 = string.Join(" ", example4.Unique());
        Console.WriteLine(result4);
        char[] example4_1 = new char[] { 'a', 'b', 'c', 'd', 'a', 'b', 'c', 'd' };
        var result4_1 = string.Join(" ", example4_1.Unique());
        Console.WriteLine(result4_1);

        dictionaryEx<int, string, int> Dictionary = new dictionaryEx<int, string, int>();

        Dictionary.Add(1, "Test1", 10);
        Dictionary.Add(2, "Test2", 20);

        Console.WriteLine(Dictionary.isKey(1));
        Console.WriteLine(Dictionary.isKey(10));


        Console.WriteLine(Dictionary.isValueOne("Test1"));
        Console.WriteLine(Dictionary.isValueOne("Test3"));


        Console.WriteLine(Dictionary.isValueTwo(10));
        Console.WriteLine(Dictionary.isValueTwo(30));


        Console.WriteLine(Dictionary.ElementString(Dictionary.getByKey(1)));


        Console.WriteLine(Dictionary.Count());


        Dictionary.Delete(1);


        foreach (var a in Dictionary.useList)
        {
            Console.WriteLine(Dictionary.ElementString(a));
        }
    }
}
