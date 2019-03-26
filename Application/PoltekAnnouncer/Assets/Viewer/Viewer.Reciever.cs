using System;
using System.Drawing;
using System.Windows.Forms;
using PoltekAnnouncer.Constant;
using System.Collections.Generic;
using static PoltekAnnouncer.Assets.Launcher;

namespace PoltekAnnouncer.Assets
{
    public partial class Viewer : Form
    {
        private ControllerName CName = new ControllerName();
        private List<DataPayload> DATA;

        /// <summary>Shorthand for adding pages in this project</summary>
        public void AddPage(int pagination, AddPagesEnum choose, string value, decimal size = 0, 
            int SizeX = 300, int SizeY = 162, int LocationX = 6, int LocationY = 4)
        {
            TabPage tabpage = new TabPage
            {
                Name = "page" + pagination,
                Text = pagination.ToString()
            };

            Console.WriteLine();

            string nameTxt = CName.keyText + pagination;
            string nameImg = CName.keyImg + pagination;
            string nameLoadImg = CName.keyLoadImg + pagination;

            switch (choose)
            {
                case AddPagesEnum.Text:
                    Label textbox = new Label
                    {
                        Name = nameTxt,
                        Text = value,
                        TextAlign = ContentAlignment.MiddleCenter,

                        Size = new Size(SizeX, SizeY),
                        Location = new Point(LocationX, LocationY),

                        // untuk kasih penuh tu layar biar ga lari kemana-mana
                        Dock = DockStyle.Fill
                    };
                    textbox.Font = new Font(textbox.Font.SystemFontName, int.Parse(size.ToString()), FontStyle.Bold);
                    tabpage.Controls.Add(textbox);
                    break;

                case AddPagesEnum.Image:
                    PictureBox picture = new PictureBox
                    {
                        Name = nameImg,
                        ImageLocation = value,
                        SizeMode = PictureBoxSizeMode.Zoom,

                        Location = new Point(LocationX, LocationY),
                        Size = new Size(SizeX, SizeY),

                        // untuk kasih penuh tu layar
                        Dock = DockStyle.Fill
                    };
                    tabpage.Controls.Add(picture);
                    break;
            }
            TabControls.TabPages.Add(tabpage);
        }

        public enum TypeDeploy
        {
            Initial, Update
        }

        public void Deploy(List<DataPayload> datas)
        {
            TabControls.TabPages.Clear();
            DataPayload.BypassData Data = new DataPayload.BypassData(datas);
            var data = Data.Data;
            int page = 0;

            for (var i = 0; i < data.Count; i++)
            {
                switch (data[i].Type)
                {
                    case AddPagesEnum.Text:
                        AddPage(page, AddPagesEnum.Text, data[i].Value, size: data[i].FontSize);
                        break;
                    case AddPagesEnum.Image:
                        AddPage(page, AddPagesEnum.Image, data[i].Value);
                        break;
                }
                page++;
            }
            page = 0;

            TabControls.SelectTab(0);
            DATA = datas;
            //Slideshow.Enabled = true;

            TabPage selected = TabControls.SelectedTab;
            int index = TabControls.SelectedIndex;
            string label = CName.keyText + index;
            string image = CName.keyImg + index;

            if (selected.Controls.ContainsKey(label))
                Slideshow.Interval = int.Parse(DATA[index].TextDuration.ToString()) * 10000;
            else if (selected.Controls.ContainsKey(image))
                Slideshow.Interval = int.Parse(DATA[index].PictDuration.ToString()) * 10000;

            this.Show();
        }
    }
}
