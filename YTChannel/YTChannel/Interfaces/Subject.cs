using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTChannel.Interfaces
{
    interface Subject
    {
        void register(Observer o);
        void unregister(Observer o);
        void notifyObservator();
    }
}
