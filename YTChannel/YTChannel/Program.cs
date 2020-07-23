using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel Rock = new Channel();
            YTUser one = new YTUser("Kamil");

            Rock.register(one);

            Rock.publishNewVideo();
            Rock.publishNewVideo();


            YTUser two = new YTUser("Mateusz");

            Rock.register(two);

            Rock.publishNewVideo();


        }
    }
}
