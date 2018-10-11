using LahoreSocketAsync;
using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace SoftEdge.Tracker.ServerSocket
{
    public partial class ServerSocker : ServiceBase
    {
        SocketAsyn mServer;
        public ServerSocker()
        {
            InitializeComponent();
            mServer = new SocketAsyn();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("SoftEdge Tracker ServerSocket is starting.",  EventLogEntryType.Information);
            mServer.StartListeningForIncomingConnection();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStop()
        {
            mServer.StopServer();
        }
    }
}
