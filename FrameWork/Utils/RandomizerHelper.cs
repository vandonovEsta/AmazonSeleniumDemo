using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonDemo.Utils
{
    public sealed class RandomizerHelper
    {
        private static Random random;
        private static RandomizerHelper instance;
        private RandomizerHelper() {
            random= new Random();
        }

        public static RandomizerHelper Instance
        {
            get 
            { 
                if(instance == null) 
                { 
                    instance = new RandomizerHelper();
                }
                return instance; 
            }

        }

        public  int getRandom(int cieling)
        {
            
            return random.Next(cieling);
        }

        public  T getRandomElementFromList<T>(List<T> input)
        {
            
            int listMember = random.Next(input.Count);
            return input[listMember];

        }

        public  int getRandomIndexFromList<T>(List<T> input)
        {
            return random.Next(input.Count);
        }
    }
}
