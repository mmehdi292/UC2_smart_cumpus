using Gestion_des_chercheurs.ImplClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_chercheurs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            TcpChannel ch = new TcpChannel(8085);
            ChannelServices.RegisterChannel(ch);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(AuthentificationImpl),"authentification",WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UsersInfoImpl), "userInfo", WellKnownObjectMode.Singleton);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
