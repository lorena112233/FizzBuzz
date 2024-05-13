using System.Collections.Generic;

namespace FizzBuzz
{
    public class Generator {
        
        public Generator()
        {

        }
        
        public IList<int> Generate()
        {
            var numbersList = new List<int>();

            for(int i = 0; i< 100; i++){
                numbersList.Add(i+1);
            }

            return numbersList;
        }
    }
}