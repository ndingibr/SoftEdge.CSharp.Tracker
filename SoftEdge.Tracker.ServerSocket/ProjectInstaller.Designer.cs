namespace SoftEdge.Tracker.ServerSocket
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serversocketProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.serverSockerInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // serversocketProcessInstaller
            // 
            this.serversocketProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serversocketProcessInstaller.Password = null;
            this.serversocketProcessInstaller.Username = null;
            // 
            // serverSockerInstaller
            // 
            this.serverSockerInstaller.Description = "Socket Server for SoftEdge UPT Calls";
            this.serverSockerInstaller.ServiceName = "SoftEdge Server Socket";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serversocketProcessInstaller,
            this.serverSockerInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serversocketProcessInstaller;
        private System.ServiceProcess.ServiceInstaller serverSockerInstaller;
    }
}