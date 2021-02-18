using System;
using System.Windows.Forms;
using Ionic.Zip;
using IWshRuntimeLibrary;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace OsuBackup
{
    public partial class Main : Form
    {
        private string dataLocation = "";
        private string datalocationLabel = "Select osu! data path:";
        private int filesExtracted;
        private string gameLocation = "";
        private string gamelocationLabel = "Select osu! game path:";
        private int totalFiles;

        public Main()
        {
            InitializeComponent();
            label1.Text = gamelocationLabel;
            label2.Text = datalocationLabel;
            backupGame_btn.Enabled = false;
            backupData_btn.Enabled = false;
            toolTip1.SetToolTip(autoBackup_btn, "Try to use the default location from osu");
            //Validating Restore buttons
            //Game
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuGameBackup.zip"))
            {
                restoreGame_btn.Enabled = true;
            }
            else
            {
                restoreGame_btn.Enabled = false;
            }
            //Data
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuDataBackup.zip"))
            {
                restoreData_btn.Enabled = true;
            }
            else
            {
                restoreData_btn.Enabled = false;
            }
            ///////////////////////////////
        }

        public void SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_Started)
            {
            }
            else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar1.Maximum = e.EntriesTotal;
                progressBar1.Value = e.EntriesSaved + 1;
            }
            else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
            {
            }
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {
                backupGame_btn.Enabled = true;
                backupData_btn.Enabled = true;
            }
        }

        public void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Extracting_BeforeExtractEntry)
            {
                filesExtracted++;
                progressBar1.Value = 100 * filesExtracted / totalFiles;
            }
        }

        private void autoBackup_btn_Click(object sender, EventArgs e)
        {
            //Use the defaut osu location
            string osuGame = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\osulazer";
            string osuData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\osu";
            autoBackup_btn.Enabled = false;
            backupData_btn.Enabled = false;
            backupGame_btn.Enabled = false;
            gameLocation_txbx.Text = osuGame;
            dataLocation_txbx.Text = osuData;
            string osuValG = osuGame + @"\osu!.exe";
            string osuValD = osuData + @"\client.db";
            if (System.IO.File.Exists(osuValG))
            {
                //Compress osu Game
                using (var zip = new ZipFile())
                {
                    zip.SaveProgress += SaveProgress;
                    zip.StatusMessageTextWriter = System.Console.Out;
                    zip.AddDirectory(osuGame, "osulazer");
                    zip.Save("OsuGameBackup.zip");
                }
            }
            else
            {
                MessageBox.Show("Not osu detected in the selected folder");
                gameLocation = "";
            }
            if (System.IO.File.Exists(osuValD))
            {
                //Compress osu data
                using (var zip = new ZipFile())
                {
                    zip.SaveProgress += SaveProgress;
                    zip.StatusMessageTextWriter = System.Console.Out;
                    zip.AddDirectory(osuData, "osu");
                    zip.Save("OsuDataBackup.zip");
                }
            }
            else
            {
                MessageBox.Show("Not osu detected in the selected folder");
                gameLocation = "";
            }
            //Validating Restore buttons
            //Game
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuGameBackup.zip"))
            {
                restoreGame_btn.Enabled = true;
            }
            else
            {
                restoreGame_btn.Enabled = false;
            }
            //Data
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuDataBackup.zip"))
            {
                restoreData_btn.Enabled = true;
            }
            else
            {
                restoreData_btn.Enabled = false;
            }
            ///////////////////////////////
        }

        private void backupData_btn_Click(object sender, EventArgs e)
        {
            backupData_btn.Enabled = false;
            backupGame_btn.Enabled = false;
            string osuVal = dataLocation + @"\client.db";
            if (System.IO.File.Exists(osuVal))
            {
                using (var zip = new ZipFile())
                {
                    zip.SaveProgress += SaveProgress;
                    zip.StatusMessageTextWriter = System.Console.Out;
                    zip.AddDirectory(dataLocation, "osu");
                    zip.Save("OsuDataBackup.zip");
                }
            }
            else
            {
                Console.WriteLine(osuVal);
                MessageBox.Show("Not osu detected in the selected folder");
                gameLocation = "";
            }

            //Validating Restore buttons
            //Game
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuGameBackup.zip"))
            {
                restoreGame_btn.Enabled = true;
            }
            else
            {
                restoreGame_btn.Enabled = false;
            }
            //Data
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuDataBackup.zip"))
            {
                restoreData_btn.Enabled = true;
            }
            else
            {
                restoreData_btn.Enabled = false;
            }
            ///////////////////////////////
        }

        private void backupGame_btn_Click(object sender, EventArgs e)
        {
            //Disable buttons until finish the zip process
            backupGame_btn.Enabled = false;
            backupData_btn.Enabled = false;
            string osuVal = gameLocation + @"\osu!.exe";
            if (System.IO.File.Exists(osuVal))
            {
                using (var zip = new ZipFile())
                {
                    zip.SaveProgress += SaveProgress;
                    zip.StatusMessageTextWriter = System.Console.Out;
                    zip.AddDirectory(gameLocation, "osulazer");
                    zip.Save("OsuGameBackup.zip");
                }
            }
            else
            {
                Console.WriteLine(osuVal);
                MessageBox.Show("Not osu detected in the selected folder");
                gameLocation = "";
            }

            //Validating Restore buttons
            //Game
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuGameBackup.zip"))
            {
                restoreGame_btn.Enabled = true;
            }
            else
            {
                restoreGame_btn.Enabled = false;
            }
            //Data
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\OsuDataBackup.zip"))
            {
                restoreData_btn.Enabled = true;
            }
            else
            {
                restoreData_btn.Enabled = false;
            }
            ///////////////////////////////
        }

        private void dataLocation_btn_Click(object sender, EventArgs e)
        {
            if (dataLocation_txbx.Text.Length <= 3)
            {
                backupData_btn.Enabled = false;
            }
            else
            {
                backupData_btn.Enabled = true;
            }
            dataLocation = dataLocation_txbx.Text;
        }

        private void dataLocation_txbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dataLocation_txbx.Text = "";
            //Disable button if textbox for game path is empty
            if (dataLocation_txbx.Text.Length <= 0)
            {
                backupData_btn.Enabled = false;
            }
            else
            {
                backupData_btn.Enabled = true;
            }

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                dataLocation = dialog.FileName;
                string osuVal = dataLocation + @"\client.db";
                if (System.IO.File.Exists(osuVal))
                {
                    dataLocation = dialog.FileName;
                    dataLocation_txbx.Text = dataLocation;
                }
                else
                {
                    Console.WriteLine(osuVal);
                    MessageBox.Show("Not osu data detected in the selected folder");
                    dataLocation = "";
                }
            }
        }

        private void dataLocation_txbx_TextChanged(object sender, EventArgs e)
        {
            if (dataLocation_txbx.Text.Length <= 3)
            {
                backupData_btn.Enabled = false;
            }
            else
            {
                backupData_btn.Enabled = true;
            }
        }

        private void gameLocation_btn_Click(object sender, EventArgs e)
        {
            if (gameLocation_txbx.Text.Length <= 3)
            {
                backupGame_btn.Enabled = false;
            }
            else
            {
                backupGame_btn.Enabled = true;
            }
            gameLocation = gameLocation_txbx.Text;
        }

        private void gameLocation_txbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gameLocation_txbx.Text = "";
            //Disable button if textbox for game path is empty
            if (gameLocation_txbx.Text.Length <= 0)
            {
                backupGame_btn.Enabled = false;
            }
            else
            {
                backupGame_btn.Enabled = true;
            }

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                gameLocation = dialog.FileName;
                string osuVal = gameLocation + @"\osu!.exe";
                if (System.IO.File.Exists(osuVal))
                {
                    gameLocation = dialog.FileName;
                    gameLocation_txbx.Text = gameLocation;
                }
                else
                {
                    Console.WriteLine(osuVal);
                    MessageBox.Show("Not osu detected in the selected folder");
                    gameLocation = "";
                }
            }
        }

        private void gameLocation_txbx_TextChanged(object sender, EventArgs e)
        {
            if (gameLocation_txbx.Text.Length <= 3)
            {
                backupGame_btn.Enabled = false;
            }
            else
            {
                backupGame_btn.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ImSoSx");
        }

        private void restoreData_btn_Click(object sender, EventArgs e)
        {
            autoBackup_btn.Enabled = false;
            restoreGame_btn.Enabled = false;
            restoreData_btn.Enabled = false;
            backupGame_btn.Enabled = false;
            backupData_btn.Enabled = false;

            string osuData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            using (ZipFile zip = ZipFile.Read(Environment.CurrentDirectory + @"\OsuDataBackup.zip"))
            {
                totalFiles = zip.Count;
                filesExtracted = 0;
                zip.ExtractProgress += zip_ExtractProgress;
                zip.ExtractAll(osuData, ExtractExistingFileAction.OverwriteSilently);
            }
            autoBackup_btn.Enabled = true;
            restoreGame_btn.Enabled = true;
            restoreData_btn.Enabled = true;
            backupGame_btn.Enabled = true;
            backupData_btn.Enabled = true;
        }

        private void restoreGame_btn_Click(object sender, EventArgs e)
        {
            autoBackup_btn.Enabled = false;
            restoreGame_btn.Enabled = false;
            restoreData_btn.Enabled = false;
            backupGame_btn.Enabled = false;
            backupData_btn.Enabled = false;
            string osuGame = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            using (ZipFile zip = ZipFile.Read(Environment.CurrentDirectory + @"\OsuGameBackup.zip"))
            {
                totalFiles = zip.Count;
                filesExtracted = 0;
                zip.ExtractProgress += zip_ExtractProgress;
                zip.ExtractAll(osuGame, ExtractExistingFileAction.OverwriteSilently);
            }

            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\osu!Lazer.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.TargetPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\osulazer\osu!.exe";
            shortcut.Save();

            autoBackup_btn.Enabled = true;
            restoreGame_btn.Enabled = true;
            restoreData_btn.Enabled = true;
            backupGame_btn.Enabled = true;
            backupData_btn.Enabled = true;
        }
    }
}