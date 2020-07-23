using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTChannel.Interfaces;

namespace YTChannel
{
    class Channel : Subject
    {
        ArrayList observerList = new ArrayList();


        public Channel()
        {
            observerList = new ArrayList();
        }

        public void publishNewVideo()
        {
            Console.WriteLine("----NEW VIDEO ON THE CHANNEL----");          
            notifyObservator();         
            Console.WriteLine("");
        }

        public void notifyObservator()
        {
            foreach (Observer o in observerList)
            {
                o.update();
            }
        }

        public void register(Observer o)
        {
            observerList.Add(o);
        }

        public void unregister(Observer o)
        {
            observerList.Remove(o);
        }
    }

}
