using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace As1
{
    public class Position
    {
        int x {get; set;}
        int y {get;set;}


        public Position(int x, int y)
        {
            if(x < 0)
            {
                x = 0;
            }
            if(y < 0)
            {
                y = 0;
            }
        }

        public Position()
        {
            x = 0;
            y = 0;
        }
    }
}