using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher
    {
        private List<string> ListboxItems = new List<string>();

        private void CopyListBox(ListBox.ObjectCollection resources, object[] destination)
        {
            throw new NotImplementedException();
        }

        private void TambahBtn_Click(object sender, EventArgs e)
        {
            string res = Interaction.InputBox("Tambahkan teks berjalan.", "Tambah Item");
            if (res != "") ListboxItems.Add(res);
            ListBoxMarquee.DataSource = null;
            ListBoxMarquee.DataSource = ListboxItems;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ListBoxMarquee.SelectedItem == null)
                MessageBox.Show("Anda tidak memilih item apapun.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int index = ListBoxMarquee.SelectedIndex;
                string res = Interaction.InputBox("Edit teks berjalan.", "Tambah Item", ListboxItems[index]);
                if (res != "")
                {
                    ListboxItems.RemoveAt(index);
                    ListboxItems.Insert(index, res);
                    ListBoxMarquee.DataSource = null;
                    ListBoxMarquee.DataSource = ListboxItems;
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
                    ListboxItems.RemoveAt(ListBoxMarquee.SelectedIndex);
                    ListBoxMarquee.DataSource = null;
                    ListBoxMarquee.DataSource = ListboxItems;
                }
            }
        }
    }
}
