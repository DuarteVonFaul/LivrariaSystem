using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.utils
{
    public static class PasswordGenerator
    {
        public static int Generator()
        {
            Random randNum = new Random(2012);

            return randNum.Next();
        }
    }
}
