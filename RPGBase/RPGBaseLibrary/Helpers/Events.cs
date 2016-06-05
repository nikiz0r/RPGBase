using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGBaseLibrary.Helpers
{
    public class Events
    {
        public string getInput()
        {
            return Console.ReadLine().ToString().ToUpper();
        }
    }
}
