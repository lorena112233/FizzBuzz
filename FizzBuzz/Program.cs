using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();
            var resultList = generator.Generate();

            for(int i = 0; i < resultList.Count; i++){
                Console.WriteLine(resultList[i]);
            }
        }
    }
}
