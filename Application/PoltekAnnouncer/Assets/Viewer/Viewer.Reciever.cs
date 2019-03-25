using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoltekAnnouncer.Assets
{
    public partial class Viewer : Form
    {
        private Launcher Launcher = new Launcher();
        private Launcher.DataPayload DataPayload = new Launcher.DataPayload();

        public enum TypeDeploy
        {
            Initial, Update
        }
        public void Deploy(TypeDeploy type)
        {

        }
    }
}
