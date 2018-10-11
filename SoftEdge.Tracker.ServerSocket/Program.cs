using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SoftEdge.Tracker.ServerSocket
{
    static class Program
    {
        static void Main()
        {
            #if DEBUG

            ServerSocker service = new ServerSocker();
            service.OnDebug();

            #else

            #endif
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServerSocker()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
