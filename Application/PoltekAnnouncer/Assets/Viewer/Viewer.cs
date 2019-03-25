using System;
using System.Windows.Forms;
using PoltekAnnouncer.Plugin;
using PoltekAnnouncer.Constant;

namespace PoltekAnnouncer.Assets
{
    public partial class Viewer : Form
    {
        private MonthConverter DateModifier = new MonthConverter();

        clsResize _form_resize;

        public Viewer()
        {
            InitializeComponent();

            _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();

            WindowState = FormWindowState.Maximized;
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void LiveClock_Tick(object sender, EventArgs e)
        {
            string Day = PadStart.Pad(DateTime.Now.Day);
            string Hour = PadStart.Pad(DateTime.Now.Hour);
            string Minute = PadStart.Pad(DateTime.Now.Minute);
            string Second = PadStart.Pad(DateTime.Now.Second);

            TimeSetting.Text = string.Format("{0} {1} {2}\n{3}:{4}:{5}", 
                Day, DateModifier.FetchMonth(), DateTime.Now.Year,
                Hour, Minute, Second);
        }

        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            MarqueeText.Left = MarqueeText.Left - 1;
            if (MarqueeText.Left < 0 - MarqueeText.Width)
                MarqueeText.Left = this.Width;
        }
    }
}
