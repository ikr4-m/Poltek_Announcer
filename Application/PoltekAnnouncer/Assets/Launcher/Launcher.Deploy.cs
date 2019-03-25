using System;
using System.Windows.Forms;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher : Form
    {
        private Viewer Viewer = new Viewer();
        
        private void Launch()
        {


            Viewer.Deploy(Viewer.TypeDeploy.Initial);
        }

        private void Updatee()
        {


            Viewer.Deploy(Viewer.TypeDeploy.Update);
        }
    }
}
