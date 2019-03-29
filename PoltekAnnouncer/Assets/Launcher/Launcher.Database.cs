using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using IniParser;
using IniParser.Model;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher
    {
        private FileIniDataParser parser = new FileIniDataParser();
        private IniData data;

        // Load the database
        private void DatabaseLoad(object sender, EventArgs e)
        {                     
            if (File.Exists("db.ini"))
            {
                data = parser.ReadFile("db.ini");
                SectionDataCollection section = data.Sections;

                KeyDataCollection GlobalSetting = section["Global"];
                KeyDataCollection DataPages = section["Data"];
                KeyDataCollection MarqueeText = section["Marquee"];

                GetDataPages(DataPages);
                GetGlobalSettings(GlobalSetting);
                GetMarqueeText(MarqueeText);
                TabControl.SelectTab(0);

                //MessageBox.Show(section["Data"]["Value1"]);
            }
            else
            {
                MessageBox.Show("File db.ini hilang! Segera install ulang aplikasi ini!.", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0x00000000);
            }
        }

        // Redirect add to pages
        private void GetDataPages(KeyDataCollection keys)
        {
            int page = int.Parse(PageJustice.Text);
            var realPageCount = keys.Count / 2;
            for (int i = 1; i <= realPageCount; i++)
            {
                page++;
                string keyType = "Type" + page;
                string keyValue = "Value" + page;
                switch (keys[keyType])
                {
                    case "Text":
                        AddPages(page, AddPagesEnum.Text, value: keys[keyValue]);
                        break;
                    case "Image":
                        AddPages(page, AddPagesEnum.Image, path: keys[keyValue]);
                        break;
                }
            }
            PageJustice.Text = page.ToString();
        }

        private void GetGlobalSettings(KeyDataCollection keys)
        {
            FontSize.Value = int.Parse(keys["FontSize"]);
            PictureDuration.Value = int.Parse(keys["PictDuration"]);
            TextDuration.Value = int.Parse(keys["TextDuration"]);
            if (keys["MinimizeWhenLaunch"] == "0") MinimizeValidation.Checked = false;
            else MinimizeValidation.Checked = true;
        }

        private void GetMarqueeText(KeyDataCollection keys)
        {
            int length = keys.Count;
            for (var i = 0; i < length; i++)
            {
                ListboxItems.Add(keys[i.ToString()]);
                ListBoxMarquee.DataSource = null;
                ListBoxMarquee.DataSource = ListboxItems;
            }
        }

        private void SavingDatabase(object sender, FormClosingEventArgs e)
        {
            // read the pages
            data.Sections.RemoveSection("Data");
            int limit = CountLimit;
            for (int i = 1; i < limit; i++)
            {
                TabControl.SelectTab(i);
                TabPage selected = TabControl.SelectedTab;

                string keyText = CName.keyText + i.ToString();
                string keyImg = CName.keyImg + i.ToString();
                string keyType = "Type" + i;
                string keyVal = "Value" + i;

                if (selected.Controls.ContainsKey(keyText))
                {
                    TextBox text = (TextBox)selected.Controls[keyText];
                    data["Data"].AddKey(keyType, "Text");
                    data["Data"].AddKey(keyVal, text.Text);
                }
                else if (selected.Controls.ContainsKey(keyImg))
                {
                    PictureBox pict = (PictureBox)selected.Controls[keyImg];
                    data["Data"].AddKey(keyType, "Image");
                    data["Data"].AddKey(keyVal, pict.ImageLocation);
                }
            }

            // read the marquee
            data.Sections.RemoveSection("Marquee");
            int sizeMarquee = ListBoxMarquee.Items.Count;
            string[] res = new string[sizeMarquee];
            ListboxItems.CopyTo(res);
            for (var i = 0; i < sizeMarquee; i++)
            {
                data["Marquee"].AddKey(i.ToString(), res[i]);
            }

            parser.WriteFile("db.ini", data);
        }
    }
}
