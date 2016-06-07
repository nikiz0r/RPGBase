using RPGBaseLibrary.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RPGBaseLibrary.Helpers
{
    public class Events
    {
        public string GetInput()
        {
            return Console.ReadLine().ToString().ToUpper();
        }

        public void RenderMessage(string message, Object[] vars, int delayMS = 1000)
        {
            Thread.Sleep(delayMS);
            Console.WriteLine(String.Format(message, vars));
        }

        public void StanceChange(BaseCharacter target, StanceEnum stance)
        {
            RenderMessage("{0} changed its stance to {1}", new object[] { target.Name, stance });
            target.Stance = (int)stance;
        }
    }
}
