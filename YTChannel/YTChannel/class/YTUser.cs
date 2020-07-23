using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTChannel.Interfaces;

namespace YTChannel
{
    class YTUser : Observer
    {
        private string name;
        private int videotoWatch;


        public YTUser(String name)
        {
            this.name = name;
            videotoWatch = 0;
        }

        public void update()
        {
            videotoWatch++;
            Console.WriteLine("{0} have {1} videos to watch", name, videotoWatch);
        }
    }

}
