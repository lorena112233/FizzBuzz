using System.Collections.Generic;

namespace FizzBuzz
{
    public class Generator {
        
        public Generator()
        {

        }
        
        public IList<string> Generate()
        {
            var numbersList = new List<string>();

            for(int i = 0; i< 100; i++){

                if(IsMultipleOf15(i+1)){
                    numbersList.Add("FizzBuzz");
                }
                else if(IsMultipleOf3(i+1)){
                    numbersList.Add("Fizz");
                }
                else if(IsMultipleOf5(i+1)){
                    numbersList.Add("Buzz");
                }
                else{
                    numbersList.Add((i+1).ToString());
                }
            }

            return numbersList;
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