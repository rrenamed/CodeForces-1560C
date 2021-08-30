/*
* Created by rrenamed
* Feel free to contribute explanations
* https://codeforces.com/problemset/submission/1560/127459661
*/

class Program
{
    static void Main()
    {
        int test_cases = Convert.ToInt32(Console.ReadLine());
        while (test_cases-- != 0)
        {
            int _case = Convert.ToInt32(Console.ReadLine());
            int sqrtL = (int)Math.Floor(Math.Sqrt(_case));
            int sqrtB = (int)Math.Ceiling(Math.Sqrt(_case));
            if (sqrtB * sqrtB - _case > _case - sqrtL * sqrtL)
                Console.WriteLine("{0} {1}", _case - sqrtL * sqrtL, sqrtB);
            else
                Console.WriteLine("{0} {1}", sqrtB, sqrtB * sqrtB - _case + 1);
        }
        //Console.ReadKey();
    }
}
