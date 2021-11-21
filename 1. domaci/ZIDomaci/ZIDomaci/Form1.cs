using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZIDomaci
{
    public partial class A51Cipher : Form
    {
        public A51 Cipher { get; set; }
        public String OutputFolder { get; set; }
        public bool Initialized { get; set; }
        public A51Cipher()
        {
            InitializeComponent();

            Cipher = new A51();
            Initialized = false;
            fsw.EnableRaisingEvents = false;
            CipherStatusTbx.BackColor = CipherStatusTbx.BackColor;  //needed to trigger color change of a readonly textbox
            SaveCipherMenuStripItem.Enabled = false;
        }

        private void LoadGlobalSeedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ulong seed = ulong.Parse(inputSeedTbx.Text);
                Cipher.LoadSeed(seed);

                DisplayCurrentSeeds();
                ClearSeedInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Seed Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Initialized = Cipher.IsInitialized();
                UpdateUIEnable();
            }
        }
        private void DisplayCurrentSeeds()
        {

            currentSeedTbx.Text = Cipher.Seed.ToString();
            XCurrentSeedTbx.Text = Cipher.XSeed.ToString();
            YCurrentSeedTbx.Text = Cipher.YSeed.ToString();
            ZCurrentSeedTbx.Text = Cipher.ZSeed.ToString();

        }
        private void ClearSeedInputs()
        {
            inputSeedTbx.Text = "";
            inputXSeedTbx.Text = "";
            inputYSeedTbx.Text = "";
            inputZSeedTbx.Text = "";

        }
        private void LoadRegisterSeedsBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ulong xSeed = uint.Parse(inputXSeedTbx.Text);
                ulong ySeed = uint.Parse(inputYSeedTbx.Text);
                ulong zSeed = uint.Parse(inputZSeedTbx.Text);

                if (xSeed == 0 || ySeed == 0 || zSeed == 0)
                    throw new ArgumentNullException();
                Cipher.LoadRegisterSeeds(xSeed, ySeed, zSeed);

                DisplayCurrentSeeds();
                ClearSeedInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Seed Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Initialized = Cipher.IsInitialized();
                UpdateUIEnable();
            }
        }

        private void LoadVoteBitsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte xvb = byte.Parse(XVoteBitNud.Value.ToString());
                byte yvb = byte.Parse(YVoteBitNud.Value.ToString());
                byte zvb = byte.Parse(ZVoteBitNud.Value.ToString());

                Cipher.LoadVoteBits(xvb, yvb, zvb);

                DisplayCurrentVoteBits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vote Bits Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Initialized = Cipher.IsInitialized();
                UpdateUIEnable();
            }
        }
        private void DisplayCurrentVoteBits()
        {
            XCurrentVoteBitTbx.Text = Cipher.XVoteBit.ToString();
            YCurrentVoteBitTbx.Text = Cipher.YVoteBit.ToString();
            ZCurrentVoteBitTbx.Text = Cipher.ZVoteBit.ToString();
        }
        private void LoadStepBitsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Check for valid inputs, empty, bad format etc.
                if (XStepBitsTbx.Text.Trim() == "" ||
                    YStepBitsTbx.Text.Trim() == "" ||
                    ZStepBitsTbx.Text.Trim() == "")
                    throw new FormatException();

                String[] xStepBitsString = XStepBitsTbx.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                String[] yStepBitsString = YStepBitsTbx.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                String[] zStepBitsString = ZStepBitsTbx.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                // Filter duplicates, check each entry for bounds

                List<byte> xStepBits = new List<byte>();
                List<byte> yStepBits = new List<byte>();
                List<byte> zStepBits = new List<byte>();

                foreach (var sb in xStepBitsString)
                {
                    xStepBits.Add(byte.Parse(sb));
                }
                foreach (var sb in yStepBitsString)
                {
                    yStepBits.Add(byte.Parse(sb));
                }
                foreach (var sb in zStepBitsString)
                {
                    zStepBits.Add(byte.Parse(sb));
                }

                Cipher.LoadStepBits(
                        xStepBits.ToArray(),
                        yStepBits.ToArray(),
                        zStepBits.ToArray()
                    );
                ClearStepBitsInputs();
                DisplayCurrentStepBits();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Step Bits Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                Initialized = Cipher.IsInitialized();
                UpdateUIEnable();

            }
        }
        public void ClearStepBitsInputs()
        {
            XStepBitsTbx.Text = "";
            YStepBitsTbx.Text = "";
            ZStepBitsTbx.Text = "";

        }
        public void DisplayCurrentStepBits()
        {
            XCurrentStepBitsTbx.Text = "";
            YCurrentStepBitsTbx.Text = "";
            ZCurrentStepBitsTbx.Text = "";

            foreach (var sb in Cipher.XStepBits)
            {
                XCurrentStepBitsTbx.Text += sb.ToString() + " ";
            }
            foreach (var sb in Cipher.YStepBits)
            {
                YCurrentStepBitsTbx.Text += sb.ToString() + " ";
            }
            foreach (var sb in Cipher.ZStepBits)
            {
                ZCurrentStepBitsTbx.Text += sb.ToString() + " ";
            }

            XCurrentStepBitsTbx.Text = XCurrentStepBitsTbx.Text.Trim();
            YCurrentStepBitsTbx.Text = YCurrentStepBitsTbx.Text.Trim();
            ZCurrentStepBitsTbx.Text = ZCurrentStepBitsTbx.Text.Trim();

        }

        private void InitializeCipherBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputSeedTbx.Text.Trim() != "")
                    LoadGlobalSeedBtn_Click(sender, e);
                else
                    LoadRegisterSeedsBtn_Click(sender, e);
                LoadStepBitsBtn_Click(sender, e);
                LoadVoteBitsBtn_Click(sender, e);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Initialized = Cipher.IsInitialized();
                UpdateUIEnable();
            }


        }
         
        public void Encode(String path, bool ChooseOutput = false)
        {

            String fileContents = string.Empty;
            String fileContentsUTF = string.Empty;

            String encodedFileContents = string.Empty;
            String encodedFileContentsUTF = string.Empty;

            using (StreamReader reader = new StreamReader(path))
            {

                int character = reader.Read();
                int encodedCharacter;
                while (character != -1)
                {
                    encodedCharacter = (int)Cipher.Encode2Bytes((ushort)character);

                    fileContents += character;
                    encodedFileContents += encodedCharacter;

                    fileContentsUTF += char.ConvertFromUtf32(character);
                    encodedFileContentsUTF += char.ConvertFromUtf32(encodedCharacter);

                    character = reader.Read();
                }
            }
            //string message = "Bytes read:\n" + fileContents + "\nIn readable format:\n" + fileContentsUTF + "\nEncoded:\n" + encodedFileContents + "\nEncoded Readable:\n" + encodedFileContentsUTF;
            //MessageBox.Show(message);

            String encodedFilePath = string.Empty;
            if (ChooseOutput)

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "(*.txt)|*.txt|All files (*.*)|*.*" ;
                    if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                        encodedFilePath = sfd.FileName;
                    else
                        return;
                }

            else
            {
                String filename = Path.GetFileNameWithoutExtension(path) + "Encoded" + Path.GetExtension(path);
                encodedFilePath = Path.Join(OutputFolder, filename);
                if (File.Exists(encodedFilePath))
                    File.Delete(encodedFilePath);
            }


            using (StreamWriter saveStream = new StreamWriter(encodedFilePath))
            {
                saveStream.Write(encodedFileContentsUTF);
            }

            Cipher.ResetRegisters();
        }
        private void ManualEncodeBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    Encode(ofd.FileName);
            }

        }
        private void ManualDecodeBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    Encode(ofd.FileName, ChooseOutput: true);
            }
        }

        private void SetWatchFolderBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    if (fbd.SelectedPath.CompareTo(OutputFolder) == 0)
                    {
                        MessageBox.Show("Watch folder cant be the same as Output folder!", "Watch Folder Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    fsw.Path = fbd.SelectedPath;
                    CurrentlyWatchingTbx.Text = fsw.Path;
                    UpdateUIEnable();
                }
            }
        }

        private void EnableDisableWatcherBtn_Click(object sender, EventArgs e)
        {
            if (!fsw.EnableRaisingEvents && (string.IsNullOrEmpty(fsw.Path) || fsw.Path.CompareTo(".") == 0))
            {
                MessageBox.Show("Watch folder not specified!", "Watcher Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!fsw.EnableRaisingEvents && !Initialized)
            {
                MessageBox.Show("Cipher not initialized!", "Cipher Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            fsw.EnableRaisingEvents = !fsw.EnableRaisingEvents;
            UpdateUIEnable();
        }

        private void UpdateUIEnable()
        {
            SaveCipherMenuStripItem.Enabled = Initialized;
            EnableDisableWatcherBtn.Text = fsw.EnableRaisingEvents ? "Disable Watcher" : "Enable Watcher";
            CipherStatusTbx.Text = Initialized ? "Initialized" : "Not Initialized";
            CipherStatusTbx.ForeColor = Initialized ? Color.Green : Color.Red;
            CipherStatusTbx.BackColor = CipherStatusTbx.BackColor;  //needed to trigger color change of a readonly textbox

            EnableDisableWatcherBtn.Enabled = Initialized && !string.IsNullOrEmpty(OutputFolder) && !string.IsNullOrEmpty(fsw.Path) && fsw.Path.CompareTo(".") != 0;
            ManualDecodeBtn.Enabled = (!fsw.EnableRaisingEvents && Initialized);
            ManualEncodeBtn.Enabled = !fsw.EnableRaisingEvents && !string.IsNullOrEmpty(OutputFolder);
            SetOutputFolderBtn.Enabled = !fsw.EnableRaisingEvents;
            SetWatchFolderBtn.Enabled = !fsw.EnableRaisingEvents;

            InitializeCipherBtn.Enabled = !fsw.EnableRaisingEvents && !Initialized;
            LoadStepBitsBtn.Enabled = !fsw.EnableRaisingEvents;
            LoadVoteBitsBtn.Enabled = !fsw.EnableRaisingEvents;
            LoadGlobalSeedBtn.Enabled = !fsw.EnableRaisingEvents;
            LoadRegisterSeedsBtn.Enabled = !fsw.EnableRaisingEvents;
        }

        private void SetOutputFolderBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    if (fbd.SelectedPath.CompareTo(fsw.Path) == 0)
                    {
                        MessageBox.Show("Output folder cant be the same as Watch folder!", "Output Folder Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    OutputFolder = fbd.SelectedPath;
                    CurrentOutputFolderTbx.Text = OutputFolder;
                    UpdateUIEnable();
                }
            }
        }

        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            Encode(e.FullPath);
        }
        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            Encode(e.FullPath);
        }

        private void SaveCipherMenuStripItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    using (TextWriter tw = File.CreateText(sfd.FileName))
                    {
                        tw.WriteLine("Global");
                        tw.WriteLine(Cipher.Seed.ToString());

                        tw.WriteLine(Cipher.XVoteBit.ToString());
                        tw.WriteLine(Cipher.YVoteBit.ToString());
                        tw.WriteLine(Cipher.ZVoteBit.ToString());

                        String xStepBits = string.Empty;
                        String yStepBits = string.Empty;
                        String zStepBits = string.Empty;

                        foreach (var stepBit in Cipher.XStepBits)
                            xStepBits += stepBit.ToString() + " ";
                        foreach (var stepBit in Cipher.YStepBits)
                            yStepBits += stepBit.ToString() + " ";
                        foreach (var stepBit in Cipher.ZStepBits)
                            zStepBits += stepBit.ToString() + " ";

                        tw.WriteLine(xStepBits.Trim());
                        tw.WriteLine(yStepBits.Trim());
                        tw.WriteLine(zStepBits.Trim());

                    }
                }
            }
        }

        private void LoadCipherMenuStripItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                {
                    using (TextReader tr = File.OpenText(ofd.FileName))
                    {
                        String seedType = tr.ReadLine();
                        ulong seed = 0;
                        uint xSeed = 0, ySeed = 0, zSeed = 0;
                        byte xvb, yvb, zvb;
                        List<byte> xsb = new List<byte>(),
                                    ysb = new List<byte>(),
                                        zsb = new List<byte>();
                        String[] xsbString,
                                    ysbString,
                                        zsbString;

                        if (seedType.CompareTo("Global") == 0)
                            seed = ulong.Parse(tr.ReadLine());
                        else
                        {
                            xSeed = uint.Parse(tr.ReadLine());
                            ySeed = uint.Parse(tr.ReadLine());
                            zSeed = uint.Parse(tr.ReadLine());

                        }
                        xvb = byte.Parse(tr.ReadLine());
                        yvb = byte.Parse(tr.ReadLine());
                        zvb = byte.Parse(tr.ReadLine());

                        xsbString = tr.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        ysbString = tr.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        zsbString = tr.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        foreach (var stepBit in xsbString)
                        {
                            xsb.Add(byte.Parse(stepBit));
                        }
                        foreach (var stepBit in ysbString)
                        {
                            ysb.Add(byte.Parse(stepBit));
                        }
                        foreach (var stepBit in zsbString)
                        {
                            zsb.Add(byte.Parse(stepBit));
                        }

                        _ = seedType.CompareTo("Global") == 0 ?
                            Cipher.LoadSeed(seed) :
                            Cipher.LoadRegisterSeeds(xSeed, ySeed, zSeed);
                        Cipher.LoadVoteBits(xvb, yvb, zvb);
                        Cipher.LoadStepBits(xsb.ToArray(), ysb.ToArray(), zsb.ToArray());

                        DisplayCurrentSeeds();
                        DisplayCurrentStepBits();
                        DisplayCurrentVoteBits();

                        Initialized = Cipher.IsInitialized();
                        UpdateUIEnable();
                    }
                }
            }
        }
    }
}
