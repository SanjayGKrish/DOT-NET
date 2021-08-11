using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVeryFirstApp
{
    class GotoDemo
    {
        int age = 17;

            if(age > 18)
            {
                goto BLOCK1
    }
            else
            {
                goto EXIT1
}

label BLOCK1;
Console.WriteLine("hi aliens");
label EXIT1;
Console.WriteLine("Get out of my teritory");
    }
}
