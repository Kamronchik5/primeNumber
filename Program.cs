using System.ComponentModel;

class Method
{

   static void Main(string[] arg)
   {
        Console.WriteLine("This code has two parts : ");
        Console.WriteLine("1-fibonaci number :");
        Console.WriteLine("2- a prime number :");
        Console.WriteLine("Select need your parts please !");
        string input = Console.ReadLine();  

      switch(input)
      {
        case "1" :
        {
            Console.WriteLine("Input the n");
            string numbs = Console.ReadLine();
            int n = Convert.ToInt32(numbs);
            fibonaci(n);
        }
        break;

        case "2" :
        {
            Console.WriteLine("Input the n");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(prime(number));
        }
        break;
      }
   }

   static void fibonaci(int n)
   {
    int [] nums = new int[n];
    nums[0]=0;
    nums[1]=1;
      for(int i=2 ; i<n ; i++)
      {
        nums[i]= nums[i-1] + nums[i-2];
      }
      foreach(int res in nums)
      {
        Console.Write(res + " ");
      }
   }

   static bool prime(int number)
   {
    if(number == 2)
    {
        return true ;
    }
     if(number <= 1)
    {
      return false ;
    }

    for(int i=3 ; i<= Math.Sqrt(number) ; i++)
    {
      if(number % i == 0)
      return false;
    }
    return true ;
   }

}
