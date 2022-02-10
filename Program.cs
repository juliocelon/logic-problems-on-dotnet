using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        TwoSum();
    }

//  This challenge consists on find all the pairs of two integers in an unsorted array that sum up to a given S. 
    static void TwoSum()
    {
        int[] numbers = new int[]{3,2,6,3,8,4};
        int goal = 10;

        Hashtable ht = new Hashtable();

        for(int i=0; i<numbers.Length;i++)
        {
            int difference = goal - numbers[i];

            if(ht.ContainsValue(difference))
                System.Console.WriteLine("The numbers are: [{0},{1}]", difference, numbers[i]);
            
            ht.Add(i, numbers[i]);
        }
    }
}

