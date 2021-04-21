using Gestion_des_laboratoires_de_recherche.classesImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_laboratoires_de_recherche
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TcpChannel ch = new TcpChannel(8086);
            ChannelServices.RegisterChannel(ch);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(GetEquipesImpl), "getEquipes", WellKnownObjectMode.Singleton);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
        }
    }
}
