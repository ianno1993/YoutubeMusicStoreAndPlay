﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;

namespace YoutubeMusicStoreAndPlay
{
    public partial class Form1 : Form
    {

        private List<YoutubeVideo> YoutubeVideoList = new List<YoutubeVideo>();

        private ToolTip toolTips = new ToolTip();

        public Form1()
        {
            InitializeComponent();

            LoadVideoItems();

            ReloadListBox();

            LoadToolTips();

        }

        #region ButtonControls

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 31) == "http://www.youtube.com/watch?v=")
            {
                YoutubeVideoList.Add(new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(31, 11))); 
                txtVideoName.Clear();
                txtVideoURL.Clear();
            }
            else if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 32) == "https://www.youtube.com/watch?v=")
            {
                YoutubeVideoList.Add(new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(32, 11)));
                txtVideoName.Clear();
                txtVideoURL.Clear();
            }
            else if (txtImportPath.Text != "" && txtVideoURL.Text.Substring(0,36) == "https://www.youtube.com/watch?list=")
            {

            }
            else if(txtImportPath.Text != "" && txtVideoURL.Text.Substring(0, 35) == "http://www.youtube.com/watch?list=")
            {

            }
            else
                MessageBox.Show("You didn't filled in the name or Youtube url right.");

            SaveVideoItems();

            ReloadListBox();

            DisableAddVideo();

            lbVideoList.SelectedIndex = YoutubeVideoList.Count -1;
        }

        private void btnCopySelectedVideoName_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(YoutubeVideoList[lbVideoList.SelectedIndex].Title);

        }

        private void btnCopySelectedVideoURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("http://www.youtube.com/watch?v=" + YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL);
        }

        private void btnCopyVideoListNames_Click(object sender, EventArgs e)
        {
            string tempString = "";
            foreach (YoutubeVideo item in YoutubeVideoList)
            {
                tempString += string.Format("{0}\r\n", item.Title);
            }

            Clipboard.SetText(tempString);

        }

        private void btnAddNewVideo_Click(object sender, EventArgs e)
        {
            if (btnAddVideo.Visible == false)
            {
                EnableAddVideo();
            }
            else
            {
                DisableAddVideo();
            }
        }

        private void btnUpdateVideoInto_Click(object sender, EventArgs e)
        {
            if (btnAddVideo.Visible == false)
            {
                if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 31) == "http://www.youtube.com/watch?v=")
                {
                    YoutubeVideoList[lbVideoList.SelectedIndex] = new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(31, 11));
                    txtVideoName.Clear();
                    txtVideoURL.Clear();
                }
                else if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 32) == "https://www.youtube.com/watch?v=")
                {
                    YoutubeVideoList[lbVideoList.SelectedIndex] = new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(32, 11));
                    txtVideoName.Clear();
                    txtVideoURL.Clear();
                }
                else
                    MessageBox.Show("You didn't filled in the name or Youtube url right.");

                int temp = lbVideoList.SelectedIndex;

                SaveVideoItems();

                ReloadListBox();

                lbVideoList.SelectedIndex = temp;

            }
            else
            {
                MessageBox.Show("Disable add video mode first! Then you can update the selected video's info.");
            }

        }

        private void btnPlaySelectedVideo_Click(object sender, EventArgs e)
        {
            if (lbVideoList.SelectedIndex != -1)
            {

                string tempURL = YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL;

                axShockwaveFlash1.Movie = "http://youtube.com/v/" + tempURL + "?autoplay=1&showinfo=0&rel=0&showinfo=0";

                if (cbGoToPlayer.Checked)
                {
                    tabControl1.SelectedIndex = 1;
                }

                ChangeFormTitle();

            }
        }

        private void btnPlayRandomVideo_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            int tempInt = random.Next(0, YoutubeVideoList.Count());

            if (tempInt != lbVideoList.SelectedIndex)
            {
                string tempURL = YoutubeVideoList[tempInt].VideoURL;

                axShockwaveFlash1.Movie = "http://youtube.com/v/" + tempURL + "&loop=1&autoplay=1";

                lbVideoList.SelectedIndex = tempInt;

                if (cbGoToPlayer.Checked)
                {
                    tabControl1.SelectedIndex = 1;
                }
            }
            else
                btnPlayAndRemove_Click(sender, e);

            ChangeFormTitle();

        }

        private void btnPlayAndRemove_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to play and remove the video?", "Warning.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string tempURL = YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL;

                axShockwaveFlash1.Movie = "http://youtube.com/v/" + tempURL + "?autoplay=1&showinfo=0&rel=0&showinfo=0";

                if (cbGoToPlayer.Checked)
                {
                    tabControl1.SelectedIndex = 1;
                }

                YoutubeVideoList.RemoveAt(lbVideoList.SelectedIndex);

                SaveVideoItems();

                ReloadListBox();

                ChangeFormTitle();

            }

        }

        private void btnRemoveVideo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the video?", "Warning.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                YoutubeVideoList.RemoveAt(lbVideoList.SelectedIndex);

                SaveVideoItems();

                ReloadListBox();
            }

        }

        private void btnMoveSelectedItemUp_Click(object sender, EventArgs e)
        {

            if (lbVideoList.SelectedIndex != -1 && lbVideoList.SelectedIndex != 0)
            {

                YoutubeVideo tempYoutubeVideo = YoutubeVideoList[lbVideoList.SelectedIndex];

                YoutubeVideoList[lbVideoList.SelectedIndex] = YoutubeVideoList[lbVideoList.SelectedIndex - 1];

                YoutubeVideoList[lbVideoList.SelectedIndex - 1] = tempYoutubeVideo;

                int tempIndex = --lbVideoList.SelectedIndex;

                SaveVideoItems();

                ReloadListBox();

                lbVideoList.SelectedIndex = tempIndex;


            }
        }

        private void btnMoveSelectedItemDown_Click(object sender, EventArgs e)
        {

            if (lbVideoList.SelectedIndex != -1 && lbVideoList.SelectedIndex != YoutubeVideoList.Count - 1)
            {

                YoutubeVideo tempYoutubeVideo = YoutubeVideoList[lbVideoList.SelectedIndex];

                YoutubeVideoList[lbVideoList.SelectedIndex] = YoutubeVideoList[lbVideoList.SelectedIndex + 1];

                YoutubeVideoList[lbVideoList.SelectedIndex + 1] = tempYoutubeVideo;

                int tempIndex = ++lbVideoList.SelectedIndex;

                SaveVideoItems();

                ReloadListBox();

                lbVideoList.SelectedIndex = tempIndex;
            }

        }

        #region Exportfile
        private void btnExport_Click(object sender, EventArgs e)
        {

                FolderBrowserDialog folderDialog = new FolderBrowserDialog();

                if(folderDialog.ShowDialog() == DialogResult.OK)
                {

                    txtExportPath.Text = folderDialog.SelectedPath;
                    
                }

        }

        private void btnGoExport_Click(object sender, EventArgs e)
        {

            if(DirectoryAndFileCheckerBool())
            {
                if (Directory.Exists(txtExportPath.Text) && File.Exists(txtExportPath.Text + "\\YoutubeVideoEXPORT.txt") != true)
                {
                    File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt", txtExportPath.Text + "\\YoutubeVideoEXPORT.txt");

                    MessageBox.Show(string.Format("The file is exported to: {0}.\r\nAnd is named: YoutubeVideoEXPORT.txt.", txtExportPath.Text), "The file is exported.");
                }
                else
                    MessageBox.Show("Your folder path isn't correct.\r\nOr the there already is a file named: YoutubeVideoEXPORT.txt", "Warning.");

            }
            else if(YoutubeVideoList.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("There is no database found,\r\nbut there is some local data.\r\n\r\nDo you wish to export that data?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveVideoItems();

                    btnGoExport_Click(sender, e);
                }

            }
            else
            {
                MessageBox.Show("There is nothing to export!");
            }

        }
        #endregion

        #region Importfile
        private void btnImport_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (YoutubeVideoEXPORT.txt)|YoutubeVideoEXPORT.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("This function isn't build in yet! \r\n But it will be implemented in V2.0.\r\n Stay tuned at my site: profoundsoftware.byethost22.com");

            }

        }

        private void btnGoImport_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This function isn't build in yet! \r\n But it will be implemented in V2.0.\r\n Stay tuned at my site: profoundsoftware.byethost22.com");

        }

        #endregion

        #endregion


        #region OtherControls

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveVideoItems();
        }

        private void txtVideoURL_Enter_1(object sender, EventArgs e)
        {
            if (btnAddVideo.Visible)
                txtVideoURL.Clear();
            else
                txtVideoName.SelectAll();
        }

        private void txtVideoURL_Leave_1(object sender, EventArgs e)
        {
            if (txtVideoURL.Text == "")
                txtVideoURL.Text = "Example: http://www.youtube.com/watch?v=abcdefghijk";
        }

        

        private void lbVideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbVideoList.SelectedIndex != -1)
            {
                
                DisableAddVideo();
            }
            
        }

        #region SearchBarCode
        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == " ")
            {
                txtSearchBar.Text = "";
            }
            else
                lbVideoList.SelectedIndex = lbVideoList.FindString(txtSearchBar.Text.ToLower());

        }

        private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Return)
            {

                btnPlaySelectedVideo_Click(sender, e);

            }

        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {

            if (txtSearchBar.Text != "")
            {
                txtSearchBar.Text = "";
            }

        }
        #endregion

        private void txtExportPath_TextChanged(object sender, EventArgs e)
        {

            if (txtExportPath.Text != "")
                btnGoExport.Visible = true;
            else
                btnGoExport.Visible = false;

        }

        #endregion


        #region Methodes

        private void LoadToolTips()
        {
                toolTips.ShowAlways = true;
                toolTips.SetToolTip(cbGoToPlayer, "If this is checked, You will be send to the video then you press play.");

        }

        private void DirectoryAndFileChecker()
        {
            #region CheckDirectory
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\"))
            {

            }
            else
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\");
            }
            #endregion

            #region CheckStoringFile
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt"))
            {

            }
            else
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt");
            }
            #endregion

        }

        private bool DirectoryAndFileCheckerBool()
        {
            bool EndBool = false;

            #region CheckDirectory
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\"))
            {
                EndBool = true;
            }
            else
            {
                EndBool = false;
            }
            #endregion

            #region CheckStoringFile
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt"))
            {
                EndBool = true;
            }
            else
            {
                EndBool = false;
            }
            #endregion

            return EndBool;
        }

        private void SaveVideoItems()
        {
            List<string> tempStringList = new List<string>();

            foreach (YoutubeVideo item in YoutubeVideoList)
            {
                tempStringList.Add(item.PrintVideoStorage);
            }
            
            DirectoryAndFileChecker();

            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt", tempStringList.ToArray());

        }

        private void LoadVideoItems()
        {

            string[] tempStringArray;

            DirectoryAndFileChecker();

            tempStringArray = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt");

            foreach (string item in tempStringArray)
            {

                YoutubeVideoList.Add(new YoutubeVideo(item.Substring(11), item.Substring(0, 11)));

            }
            

        }

        private void ReloadListBox()
        {

            lbVideoList.DataSource = null;

            List<string> tempTitleList = new List<string>();

            foreach (YoutubeVideo item in YoutubeVideoList)
            {
                tempTitleList.Add(item.Title);
            }

            lbVideoList.DataSource = tempTitleList;

        }

        private void EnableAddVideo()
        {

            txtVideoName.Text = "";
            txtVideoURL.Text = "Example: http://www.youtube.com/watch?v=abcdefghijk";
            btnAddVideo.Visible = true;
            btnAddNewVideo.Text = "Dis. add video";

        }

        private void DisableAddVideo()
        {

            txtVideoName.Text = YoutubeVideoList[lbVideoList.SelectedIndex].Title;
            txtVideoURL.Text = "http://www.youtube.com/watch?v=" + YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL;
            btnAddVideo.Visible = false;
            btnAddNewVideo.Text = "Ena. add video";

        }

        private void ChangeFormTitle()
        {

            this.Text = string.Format("{0} - YTVSaP", YoutubeVideoList[lbVideoList.SelectedIndex].Title);

        }

        //custom search methode [wip]
        private int CompairString(string stringToCompair)
        {

            int counter = 0;

            char[] stringCharArray = stringToCompair.ToCharArray();

            foreach (YoutubeVideo item in YoutubeVideoList)
            {

                string tempString = item.Title;

                char[] tempCharArray = tempString.ToCharArray();



                for (int i = 0; i < stringToCompair.Count(); i++)
                {
                    
                    

                }

                counter++;

            }

            return 1;

        }

        #endregion

        private void lbVideoList_DoubleClick(object sender, EventArgs e)
        {

            btnPlaySelectedVideo_Click(sender, e);

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            

        }

        private void cbShowToolTips_CheckedChanged(object sender, EventArgs e)
        {
                LoadToolTips();
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            string name = GetTitle(url);

public string GetTitle(string url)
{
    string id = GetArgs(url, "v", '?');
    WebClient client = new WebClient();
    return GetArgs(client.DownloadString("http://youtube.com/get_video_info?video_id=" + id), "title", '&');
}

private string GetArgs(string args, string key, char query)
{
    int iqs = args.IndexOf(query);
    string querystring = null;

    if (iqs != -1)
    {
        querystring = (iqs < args.Length - 1) ? args.Substring(iqs + 1) : String.Empty;
        NameValueCollection nvcArgs = HttpUtility.ParseQueryString(querystring);
        return nvcArgs[key];
    }
    return String.Empty; // or throw an error
}
        }


        


        #region URLControlMethodes

        #endregion

    }
}
