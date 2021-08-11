using System;
using System.Collections.Generic;
using System.Text;

namespace RandomList
{
    class RandomList:List<string>
    {
        private Random random;
        public RandomList()
        {
            this.random = new Random();
        }
        public string RandomString()
        {
            return this.random.ToString();
        }
    }
}
