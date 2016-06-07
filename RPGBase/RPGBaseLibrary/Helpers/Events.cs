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
            
            string newMsg = String.Format(message + "\n", vars);
            foreach (var i in newMsg)
	        {
                Thread.Sleep(50);
                Console.Write(i);
	        }
        }

        public void StanceChange(BaseCharacter target, StanceEnum stance)
        {
            RenderMessage("{0} changed its stance to {1}", new object[] { target.Name, stance });
            target.Stance = (int)stance;
        }
    }
}
