using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher : Form
    {
        private void TambahBtn_Click(object sender, EventArgs e)
        {
            string res = Interaction.InputBox("Tambahkan teks berjalan.", "Tambah Item");
            if (res != "")
                ListBoxMarquee.Items.Add(res);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ListBoxMarquee.SelectedItem == null)
                MessageBox.Show("Anda tidak memilih item apapun.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int index = ListBoxMarquee.SelectedIndex;
                string res = Interaction.InputBox("Edit teks berjalan.", "Tambah Item", ListBoxMarquee.SelectedItem.ToString());
                if (res != "")
                {
                    ListBoxMarquee.Items.RemoveAt(index);
                    ListBoxMarquee.Items.Insert(index, res);
                    ListBoxMarquee.Refresh();
                }
            }
        }

        private void HapusBtn_Click(object sender, EventArgs e)
        {
            if (ListBoxMarquee.SelectedItem == null)
                MessageBox.Show("Anda tidak memilih item apapun.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult res = MessageBox.Show("Apakah anda yakin ingin menghapus item tersebut?",
                    "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ListBoxMarquee.Items.RemoveAt(ListBoxMarquee.SelectedIndex);
                    MessageBox.Show("Telah berhasil menghapus teks!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
