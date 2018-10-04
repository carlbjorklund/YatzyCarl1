using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzyCarl.Models
{
    class DicePanel
    {
        Random randomNumber;
        public DicePanel()
        {
            randomNumber = new Random();
        }
        public int FirstRoll()
        {
            return randomNumber.Next(1, 7);
        }
    }
}
