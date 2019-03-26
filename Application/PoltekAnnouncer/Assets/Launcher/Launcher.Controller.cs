using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher : Form
    {
        // In TabControl controller
        private void AddText_Click(object sender, EventArgs e)
        {
            int page = int.Parse(PageJustice.Text) + 1;
            AddPages(page, AddPagesEnum.Text);
        }

        private void AddPicture_Click(object sender, EventArgs e)
        {
            int page = int.Parse(PageJustice.Text) + 1;
            string filePath = string.Empty;
            _OpenDialog.Open("File foto yang umum (*.png, *.jpg)|*.PNG;*.JPG");
            AddPages(page, AddPagesEnum.Image, _OpenDialog.PathFile);
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            int realLimit = CountLimit - 1;
            int limit = CountLimit - 1;

            if (realLimit == 0)
            {
                MessageBox.Show("Sayangnya anda tidak mempunyai halaman yang dapat untuk dihapus.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show(string.Format("Apakah anda yakin menghapus {0} halaman?", realLimit),
                    "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    for (int i = limit; i > 0; i--) TabControl.TabPages.RemoveAt(i);
                    PageJustice.Text = "0";

                    MessageBox.Show(string.Format("Menghapus {0} halaman!", realLimit), "Pemberitahuan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExecutionButton_Click(object sender, EventArgs e)
        {       
            int limit = CountLimit;
            var ret = new List<DataPayload>();
            //MessageBox.Show(limit.ToString());

            if (limit == 1)
            {
                MessageBox.Show("Njir kosong");
            }
            else
            {
                for (int i = 1; i < limit; i++)
                {
                    TabControl.SelectTab(i);
                    TabPage selected = TabControl.SelectedTab;

                    string keyText = CName.keyText + i.ToString();
                    string keyImg = CName.keyImg + i.ToString();
                    string keyLoadImg = CName.keyLoadImg + i.ToString();

                    if (selected.Controls.ContainsKey(keyText))
                    {
                        TextBox text = (TextBox)selected.Controls[keyText];
                        ret.Add(new DataPayload()
                        {
                            Type = AddPagesEnum.Text,
                            Value = text.Text,
                            FontSize = FontSize.Value,
                            TextDuration = TextDuration.Value
                        });
                    }
                    else if (selected.Controls.ContainsKey(keyImg))
                    {
                        PictureBox pict = (PictureBox)selected.Controls[keyImg];
                        ret.Add(new DataPayload()
                        {
                            Type = AddPagesEnum.Image,
                            Value = pict.ImageLocation,
                            PictDuration = PictureDuration.Value
                        });
                    }

                    _DataPayload.Output = ret;
                }
                TabControl.SelectTab(0);
                UpdateJustice();                
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            viewer.Hide();

            ExecutionButton.Text = CName.BeforeRunningButton;
            StopButton.Visible = false;
            BackColor = SystemColors.Control;
        }
    }
}
