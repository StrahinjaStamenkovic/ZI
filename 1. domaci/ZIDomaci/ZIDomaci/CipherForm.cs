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
    public partial class CipherForm : Form
    {
        public A51 A51Cipher { get; set; }
        public XXTEA XXTEACipher { get; set; }
        public String OutputFolder { get; set; }
        public bool A51Initialized { get; set; }
        public bool XXTEAInitialized { get; set; }
        public String SelectedCipher { get; set; }
        public CipherForm()
        {
            InitializeComponent();

            A51Cipher = new A51();
            XXTEACipher = new XXTEA();
            A51Initialized = false;
            XXTEAInitialized = false;
            fsw.EnableRaisingEvents = false;
            CipherStatusTbx.BackColor = CipherStatusTbx.BackColor;  //needed to trigger color change of a readonly textbox
            A51SaveCipherMenuStripItem.Enabled = false;
            SelectedCipher = "A51";
        }

        #region Load and display methods for A51
        private void LoadGlobalSeedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ulong seed = ulong.Parse(inputSeedTbx.Text);
                A51Cipher.LoadSeed(seed);

                DisplayCurrentSeeds();
                ClearSeedInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Seed Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                A51Initialized = A51Cipher.IsInitialized();
                UpdateUIEnable();
            }
        }
        private void DisplayCurrentSeeds()
        {

            currentSeedTbx.Text = A51Cipher.Seed.ToString();
            XCurrentSeedTbx.Text = A51Cipher.XSeed.ToString();
            YCurrentSeedTbx.Text = A51Cipher.YSeed.ToString();
            ZCurrentSeedTbx.Text = A51Cipher.ZSeed.ToString();

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
                A51Cipher.LoadRegisterSeeds(xSeed, ySeed, zSeed);

                DisplayCurrentSeeds();
                ClearSeedInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Seed Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                A51Initialized = A51Cipher.IsInitialized();
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

                A51Cipher.LoadVoteBits(xvb, yvb, zvb);

                DisplayCurrentVoteBits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vote Bits Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                A51Initialized = A51Cipher.IsInitialized();
                UpdateUIEnable();
            }
        }
        private void DisplayCurrentVoteBits()
        {
            XCurrentVoteBitTbx.Text = A51Cipher.XVoteBit.ToString();
            YCurrentVoteBitTbx.Text = A51Cipher.YVoteBit.ToString();
            ZCurrentVoteBitTbx.Text = A51Cipher.ZVoteBit.ToString();
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

                A51Cipher.LoadStepBits(
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
                A51Initialized = A51Cipher.IsInitialized();
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

            foreach (var sb in A51Cipher.XStepBits)
            {
                XCurrentStepBitsTbx.Text += sb.ToString() + " ";
            }
            foreach (var sb in A51Cipher.YStepBits)
            {
                YCurrentStepBitsTbx.Text += sb.ToString() + " ";
            }
            foreach (var sb in A51Cipher.ZStepBits)
            {
                ZCurrentStepBitsTbx.Text += sb.ToString() + " ";
            }

            XCurrentStepBitsTbx.Text = XCurrentStepBitsTbx.Text.Trim();
            YCurrentStepBitsTbx.Text = YCurrentStepBitsTbx.Text.Trim();
            ZCurrentStepBitsTbx.Text = ZCurrentStepBitsTbx.Text.Trim();

        }

        #endregion


        #region Load/Save to file A51
        private void A51SaveCipherMenuStripItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    using (TextWriter tw = File.CreateText(sfd.FileName))
                    {
                        tw.WriteLine("A51");
                        tw.WriteLine("Global");
                        tw.WriteLine(A51Cipher.Seed.ToString());

                        tw.WriteLine(A51Cipher.XVoteBit.ToString());
                        tw.WriteLine(A51Cipher.YVoteBit.ToString());
                        tw.WriteLine(A51Cipher.ZVoteBit.ToString());

                        String xStepBits = string.Empty;
                        String yStepBits = string.Empty;
                        String zStepBits = string.Empty;

                        foreach (var stepBit in A51Cipher.XStepBits)
                            xStepBits += stepBit.ToString() + " ";
                        foreach (var stepBit in A51Cipher.YStepBits)
                            yStepBits += stepBit.ToString() + " ";
                        foreach (var stepBit in A51Cipher.ZStepBits)
                            zStepBits += stepBit.ToString() + " ";

                        tw.WriteLine(xStepBits.Trim());
                        tw.WriteLine(yStepBits.Trim());
                        tw.WriteLine(zStepBits.Trim());

                    }
                }
            }
        }

        private void A51LoadCipherMenuStripItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                {
                    using (TextReader tr = File.OpenText(ofd.FileName))
                    {
                        try
                        {
                            if (tr.ReadLine().Trim().CompareTo("A51") != 0)
                                throw new Exception("Invalid key file format.");

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
                                A51Cipher.LoadSeed(seed) :
                                A51Cipher.LoadRegisterSeeds(xSeed, ySeed, zSeed);
                            A51Cipher.LoadVoteBits(xvb, yvb, zvb);
                            A51Cipher.LoadStepBits(xsb.ToArray(), ysb.ToArray(), zsb.ToArray());

                            DisplayCurrentSeeds();
                            DisplayCurrentStepBits();
                            DisplayCurrentVoteBits();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while parsing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            A51Initialized = A51Cipher.IsInitialized();
                            UpdateUIEnable();
                        }
                    }
                }
            }
        }
        #endregion

        private void InitializeCipherBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedCipher=="A51")
                {
                    if (inputSeedTbx.Text.Trim() != "")
                        LoadGlobalSeedBtn_Click(sender, e);
                    else
                        LoadRegisterSeedsBtn_Click(sender, e);
                    LoadStepBitsBtn_Click(sender, e);
                    LoadVoteBitsBtn_Click(sender, e);
                }
                else if (SelectedCipher == "XXTEA")
                {
                    LoadKeysBtn_Click(sender, e);
                    LoadBlockSizeBtn_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                A51Initialized = A51Cipher.IsInitialized();
                XXTEAInitialized = XXTEACipher.IsInitialized();
                UpdateUIEnable();
            }


        }

        public void EncodeDecodeFile(String path, bool chooseOutput = false, bool isEncode = true)
        {
            String encodedDecodedFileContentsUTF = string.Empty;

            if (SelectedCipher == "A51")
                encodedDecodedFileContentsUTF = A51EncodeDecodeFile(path);

            else if (SelectedCipher == "XXTEA")
                if(isEncode)
                    encodedDecodedFileContentsUTF = XXTEAEncodeFile(path);
                else
                    encodedDecodedFileContentsUTF = XXTEADecodeFile(path);

            String encodedFilePath = string.Empty;

            if (chooseOutput)
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "(*.txt)|*.txt|All files (*.*)|*.*";
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
            using (StreamWriter saveStream = new StreamWriter(encodedFilePath, append:false, Encoding.UTF8))
            {
                saveStream.Write(encodedDecodedFileContentsUTF);
            }


        }

        private String A51EncodeDecodeFile(String path)
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
                    encodedCharacter = (int)A51Cipher.Encode2Bytes((ushort)character);

                    fileContents += character;
                    encodedFileContents += encodedCharacter;

                    fileContentsUTF += char.ConvertFromUtf32(character);
                    encodedFileContentsUTF += char.ConvertFromUtf32(encodedCharacter);

                    character = reader.Read();
                }
                string message = "Bytes read:\n" + fileContents + "\nIn readable format:\n" + fileContentsUTF + "\nEncoded:\n" + encodedFileContents + "\nEncoded Readable:\n" + encodedFileContentsUTF;
                MessageBox.Show(message);
            }

            A51Cipher.ResetRegisters();
            return encodedFileContentsUTF;
        }
        //private String XXTEAEncodeDecodeFile(String path, bool isEncode)
        //{
        //    String encodedDecodedFileContentsUTF = string.Empty;

        //    using (StreamReader reader = new StreamReader(path,Encoding.UTF8))
        //    {

        //        char[] block = new char[XXTEACipher.N * 2];

        //        int size = reader.ReadBlock(block, 0, XXTEACipher.N * 2);
        //        encodedDecodedFileContentsUTF = string.Empty;
        //        while (size != 0)
        //        {
        //            int wordsSize = (size % 2 == 0) ? size / 2 : (size + 1) / 2;     //+1 kako bih mogao da upakujem sve u 32b reci
        //            uint[] words = new uint[wordsSize];
        //            for (var i = 0; i < wordsSize; i++)
        //            {
        //                ushort upper = block[i * 2];
        //                ushort lower = (i * 2 + 1 > size) ? ' ' : block[i * 2 + 1];
        //                words[i] = ((uint)upper << 16) | lower;
        //            }
        //           // MessageBox.Show(new String(block));
                   
        //            if (isEncode)
        //                XXTEACipher.EncodeBlock(ref words, (ushort)wordsSize);
        //            else
        //                XXTEACipher.DecodeBlock(ref words, (ushort)wordsSize);

        //            for (var i = 0; i < wordsSize; i++)
        //            {
        //                ushort upper = (ushort)(words[i] >> 16);
        //                ushort lower = (ushort)words[i];
        //                //encodedDecodedFileContentsUTF += char.ConvertFromUtf32(upper);
        //                //encodedDecodedFileContentsUTF += char.ConvertFromUtf32(lower);
        //                encodedDecodedFileContentsUTF += Convert.ToChar(upper);
        //                encodedDecodedFileContentsUTF += Convert.ToChar(lower);

        //            }
        //            //MessageBox.Show(encodedDecodedFileContentsUTF);
        //            size = reader.ReadBlock(block, 0, XXTEACipher.N * 2);
        //        }
        //        //string message = "Bytes read:\n" + fileContents + "\nIn readable format:\n" + fileContentsUTF + "\nEncoded:\n" + encodedFileContents + "\nEncoded Readable:\n" + encodedFileContentsUTF;
        //        //MessageBox.Show(message);
        //    }
        //    return encodedDecodedFileContentsUTF;
        //}
        private String XXTEAEncodeFile(String path)
        {
            String plaintext = string.Empty;
            String encodedFileContents = string.Empty;

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                plaintext = reader.ReadToEnd();

                if (plaintext.Length == 0) { return ""; }

                List<uint> packedPlaintext = new List<uint>(BytesToWords((new UTF8Encoding()).GetBytes(plaintext)));

                List<uint> encodedWords = new List<uint>();
                List<uint> block = new List<uint>();
                
                var iterator = 0;

                while (iterator < packedPlaintext.Count)
                {
                    int blockSize = (iterator + XXTEACipher.N <= packedPlaintext.Count) ? XXTEACipher.N :packedPlaintext.Count-iterator;
                    block = packedPlaintext.GetRange(iterator, blockSize);
                    uint[] blockArray = block.ToArray();

                    if (blockArray.Length == 1) { blockArray[0] = 0; }


                    XXTEACipher.EncodeBlock(ref blockArray);

                    encodedWords.AddRange(blockArray);
                   
                    iterator += XXTEACipher.N;
                }

                encodedFileContents = Convert.ToBase64String(WordsToBytes(encodedWords.ToArray()));
            }
            return encodedFileContents;
        }
        private String XXTEADecodeFile(String path)
        {
            String ciphertext = string.Empty;
            String decodedFileContents = string.Empty;

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                ciphertext = reader.ReadToEnd();

                if (ciphertext.Length == 0) { return ""; }

                List<uint> packedCiphertext = new List<uint>(BytesToWords(Convert.FromBase64String(ciphertext)));


                List<uint> block = new List<uint>();

                var iterator = 0;

                while (iterator < packedCiphertext.Count)
                {
                    int blockSize = (iterator + XXTEACipher.N <= packedCiphertext.Count) ? XXTEACipher.N : packedCiphertext.Count - iterator;
                    block = packedCiphertext.GetRange(iterator, blockSize);
                    uint[] blockArray = block.ToArray();

                    if (blockArray.Length == 1) { blockArray[0] = 0; }


                    XXTEACipher.DecodeBlock(ref blockArray);

                    decodedFileContents += (new UTF8Encoding()).GetString(WordsToBytes(blockArray));
                    iterator += XXTEACipher.N;
                }


            }
            return decodedFileContents;
        }
        private static uint[] BytesToWords(byte[] s)
        {

            var l = new uint[(int)Math.Ceiling(((decimal)s.Length / 4))];

            for (int i = 0; i < l.Length; i++)
            {
                l[i] = ((s[i * 4])) +
                       ((i * 4 + 1) >= s.Length ? (uint)0 << 8 : ((uint)s[i * 4 + 1] << 8)) +
                       ((i * 4 + 2) >= s.Length ? (uint)0 << 16 : ((uint)s[i * 4 + 2] << 16)) +
                       ((i * 4 + 3) >= s.Length ? (uint)0 << 24 : ((uint)s[i * 4 + 3] << 24));
            }

            return l;
        }
        private static byte[] WordsToBytes(uint[] w)
        {
            byte[] b = new byte[w.Length * 4];

            for (var i = 0; i < w.Length; i++)
            {
                b[(i * 4)] = (byte)(w[i] & 0xFF);
                b[(i * 4) + 1] = (byte)(w[i] >> (8 & 0xFF));
                b[(i * 4) + 2] = (byte)(w[i] >> (16 & 0xFF));
                b[(i * 4) + 3] = (byte)(w[i] >> (24 & 0xFF));
            }
            return b;
        }
        private void ManualEncodeBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    EncodeDecodeFile(ofd.FileName);
            }

        }
        private void ManualDecodeBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    EncodeDecodeFile(ofd.FileName, chooseOutput: true, isEncode: false);
            }
        }


        private void UpdateUIEnable()
        {

            EnableDisableWatcherBtn.Text = fsw.EnableRaisingEvents ? "Disable Watcher" : "Enable Watcher";
            //CipherStatusTbx.BackColor = CipherStatusTbx.BackColor;  //needed to trigger color change of a readonly textbox


            SetOutputFolderBtn.Enabled = !fsw.EnableRaisingEvents;
            SetWatchFolderBtn.Enabled = !fsw.EnableRaisingEvents;

            bool Initialized = false;
            //Specific Cipher properties
            if (SelectedCipher == "A51")
            {
                Initialized = A51Initialized;
                ActiveCipherTbx.Text = "A51";

                A51SaveCipherMenuStripItem.Enabled = A51Initialized;

                LoadStepBitsBtn.Enabled = !fsw.EnableRaisingEvents;
                LoadVoteBitsBtn.Enabled = !fsw.EnableRaisingEvents;
                LoadGlobalSeedBtn.Enabled = !fsw.EnableRaisingEvents;
                LoadRegisterSeedsBtn.Enabled = !fsw.EnableRaisingEvents;
            }
            else if (SelectedCipher == "XXTEA")
            {
                Initialized = XXTEAInitialized;
                ActiveCipherTbx.Text = "XXTEA";

                XXTEASaveCipherStateToolStripMenuItem.Enabled = XXTEAInitialized;

                LoadKeysBtn.Enabled = !fsw.EnableRaisingEvents;
                LoadBlockSizeBtn.Enabled = !fsw.EnableRaisingEvents;
            }
            //FSW and other buttons/status display
            CipherStatusTbx.Text = Initialized ? "Initialized" : "Not Initialized";
            CipherStatusTbx.ForeColor = Initialized ? Color.Green : Color.Red;

            EnableDisableWatcherBtn.Enabled = Initialized && !string.IsNullOrEmpty(OutputFolder) && !string.IsNullOrEmpty(fsw.Path) && fsw.Path.CompareTo(".") != 0;
            ManualEncodeBtn.Enabled = !fsw.EnableRaisingEvents && !string.IsNullOrEmpty(OutputFolder) && Initialized;
            ManualDecodeBtn.Enabled = (!fsw.EnableRaisingEvents && Initialized);
            InitializeCipherBtn.Enabled = !fsw.EnableRaisingEvents && !Initialized;



        }

        #region FSW related methods
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
        private void EnableDisableWatcherBtn_Click(object sender, EventArgs e)
        {
            if (!fsw.EnableRaisingEvents && (string.IsNullOrEmpty(fsw.Path) || fsw.Path.CompareTo(".") == 0))
            {
                MessageBox.Show("Watch folder not specified!", "Watcher Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!fsw.EnableRaisingEvents && (SelectedCipher == "A51" && !A51Initialized || SelectedCipher == "XXTEA" && !XXTEAInitialized))
            {
                MessageBox.Show("Cipher not initialized!", "Cipher Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            fsw.EnableRaisingEvents = !fsw.EnableRaisingEvents;
            UpdateUIEnable();
        }
        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            EncodeDecodeFile(e.FullPath);
        }
        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            EncodeDecodeFile(e.FullPath);
        }
        #endregion


        //XXTEA
        #region Load and display methods for XXTEA
        private void LoadKeysBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uint K1 = uint.Parse(KeyOneTbx.Text);
                uint K2 = uint.Parse(KeyTwoTbx.Text);
                uint K3 = uint.Parse(KeyThreeTbx.Text);
                uint K4 = uint.Parse(KeyFourTbx.Text);


                if (K1 == 0 || K2 == 0 || K3 == 0 || K4 == 0)
                    throw new ArgumentNullException();
                XXTEACipher.LoadKeys(K1, K2, K3, K4);

                DisplayCurrentKeys();
                ClearKeyInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Key Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                XXTEAInitialized = XXTEACipher.IsInitialized();
                UpdateUIEnable();
            }
        }

        private void ClearKeyInputs()
        {
            KeyOneTbx.Text = "";
            KeyTwoTbx.Text = "";
            KeyThreeTbx.Text = "";
            KeyFourTbx.Text = "";

        }

        private void DisplayCurrentKeys()
        {
            CurrentKeyOneTbx.Text = XXTEACipher.K1.ToString();
            CurrentKeyTwoTbx.Text = XXTEACipher.K2.ToString();
            CurrentKeyThreeTbx.Text = XXTEACipher.K3.ToString();
            CurrentKeyFourTbx.Text = XXTEACipher.K4.ToString();
        }

        private void ClearBlockSizeInput()
        {
            BlockSizeNud.Value = 0;
        }
        private void LoadBlockSizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ushort n = ushort.Parse(BlockSizeNud.Value.ToString());

                XXTEACipher.LoadBlockSize(n);

                DisplayCurrentBlockSize();
                ClearBlockSizeInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vote Bits Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                XXTEAInitialized = XXTEACipher.IsInitialized();
                UpdateUIEnable();
            }
        }

        private void DisplayCurrentBlockSize()
        {
            CurrentBlockSizeTbx.Text = XXTEACipher.N.ToString();
        }
        #endregion

        #region Load/Save to file XXTEA
        private void XXTEASaveCipherStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    using (TextWriter tw = File.CreateText(sfd.FileName))
                    {
                        tw.WriteLine("XXTEA");
                        tw.WriteLine(XXTEACipher.K1.ToString());
                        tw.WriteLine(XXTEACipher.K2.ToString());
                        tw.WriteLine(XXTEACipher.K3.ToString());
                        tw.WriteLine(XXTEACipher.K4.ToString());
                        tw.WriteLine(XXTEACipher.N.ToString());
                    }
                }
            }
        }

        private void XXTEALloadCipherStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                {
                    using (TextReader tr = File.OpenText(ofd.FileName))
                    {
                        try
                        {
                            if (tr.ReadLine().CompareTo("A51") == 0)
                                throw new Exception("Invalid key file format.");

                            uint k1 = uint.Parse(tr.ReadLine());
                            uint k2 = uint.Parse(tr.ReadLine());
                            uint k3 = uint.Parse(tr.ReadLine());
                            uint k4 = uint.Parse(tr.ReadLine());
                            ushort n = ushort.Parse(tr.ReadLine());

                            XXTEACipher.LoadKeys(k1, k2, k3, k4);
                            XXTEACipher.LoadBlockSize(n);

                            DisplayCurrentKeys();
                            DisplayCurrentBlockSize();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while parsing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            XXTEAInitialized = XXTEACipher.IsInitialized();
                            UpdateUIEnable();
                        }
                    }
                }
            }

        }
        #endregion

        private void CipherSelectionTc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CipherSelectionTc.SelectedTab == A51tab)
                SelectedCipher = "A51";
            else if (CipherSelectionTc.SelectedTab == XXTEAtab)
                SelectedCipher = "XXTEA";
            UpdateUIEnable();
        }

        private void CipherSelectionTc_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (fsw.EnableRaisingEvents)    // Disable tab switching if file watcher is active
            {
                e.Cancel = true;
            }
        }
    }
}
