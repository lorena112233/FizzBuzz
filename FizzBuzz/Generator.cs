using System.Collections.Generic;

namespace FizzBuzz
{
    public class Generator {
        
        public Generator()
        {

        }
        
        /* 
        Loop to assign values from 1-100
        Returns the list of strings with values to display.
        */
        public IList<string> Generate()
        {
            var numbersList = new List<string>();

            for(int i = 0; i < 100; i++){

                numbersList.Add(TextToDisplay(i+1));

            }

            return numbersList;
        }

        /*
        Returns the string value that should be displayed.
        */
        public string TextToDisplay(int numb)
        {
            if(IsMultipleOf15(numb))
            {
                return("FizzBuzz");
            }
            else if(IsMultipleOf3(numb))
            {
                return("Fizz");
            }
            else if(IsMultipleOf5(numb))
            {
                return("Buzz");
            }
            
            return((numb).ToString());
        }

        private static bool IsMultipleOf3(int numb){
            return numb % 3 == 0;
        }

        private static bool IsMultipleOf5(int numb){
            return numb % 5 == 0;
        }

        /*
        Multiple of 15 means that is multiple of 3 AND multiple of 5
        */
        private static bool IsMultipleOf15(int numb){
            return numb % 15 == 0;
        }

    }
}