
namespace ZIDomaci
{
    partial class CipherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputSeedTbx = new System.Windows.Forms.TextBox();
            this.SeedLbl = new System.Windows.Forms.Label();
            this.currentSeedLbl = new System.Windows.Forms.Label();
            this.currentSeedTbx = new System.Windows.Forms.TextBox();
            this.XCurrentSeedTbx = new System.Windows.Forms.TextBox();
            this.XCurrentSeedLbl = new System.Windows.Forms.Label();
            this.XSeedLbl = new System.Windows.Forms.Label();
            this.inputXSeedTbx = new System.Windows.Forms.TextBox();
            this.ZCurrentSeedTbx = new System.Windows.Forms.TextBox();
            this.ZCurrentSeedLbl = new System.Windows.Forms.Label();
            this.ZSeedLbl = new System.Windows.Forms.Label();
            this.inputZSeedTbx = new System.Windows.Forms.TextBox();
            this.YCurrentSeedTbx = new System.Windows.Forms.TextBox();
            this.YCurrentSeedLbl = new System.Windows.Forms.Label();
            this.YSeedLbl = new System.Windows.Forms.Label();
            this.inputYSeedTbx = new System.Windows.Forms.TextBox();
            this.LoadGlobalSeedBtn = new System.Windows.Forms.Button();
            this.LoadRegisterSeedsBtn = new System.Windows.Forms.Button();
            this.ZVoteBitLbl = new System.Windows.Forms.Label();
            this.YVoteBitLbl = new System.Windows.Forms.Label();
            this.XVoteBitLbl = new System.Windows.Forms.Label();
            this.XVoteBitNud = new System.Windows.Forms.NumericUpDown();
            this.YVoteBitNud = new System.Windows.Forms.NumericUpDown();
            this.ZVoteBitNud = new System.Windows.Forms.NumericUpDown();
            this.LoadVoteBitsBtn = new System.Windows.Forms.Button();
            this.ZCurrentVoteBitTbx = new System.Windows.Forms.TextBox();
            this.ZCurrentVoteBit = new System.Windows.Forms.Label();
            this.YCurrentVoteBitTbx = new System.Windows.Forms.TextBox();
            this.YCurrentVoteBitLbl = new System.Windows.Forms.Label();
            this.XCurrentVoteBitTbx = new System.Windows.Forms.TextBox();
            this.XCurrentVoteBitLbl = new System.Windows.Forms.Label();
            this.ZStepBitsLbl = new System.Windows.Forms.Label();
            this.ZStepBitsTbx = new System.Windows.Forms.TextBox();
            this.YStepBitsLbl = new System.Windows.Forms.Label();
            this.YStepBitsTbx = new System.Windows.Forms.TextBox();
            this.XStepBitsLbl = new System.Windows.Forms.Label();
            this.XStepBitsTbx = new System.Windows.Forms.TextBox();
            this.ZCurrentStepBitsLbl = new System.Windows.Forms.Label();
            this.ZCurrentStepBitsTbx = new System.Windows.Forms.TextBox();
            this.YCurrentStepBitsLbl = new System.Windows.Forms.Label();
            this.YCurrentStepBitsTbx = new System.Windows.Forms.TextBox();
            this.XCurrentStepBitsLbl = new System.Windows.Forms.Label();
            this.XCurrentStepBitsTbx = new System.Windows.Forms.TextBox();
            this.LoadStepBitsBtn = new System.Windows.Forms.Button();
            this.InitializeCipherBtn = new System.Windows.Forms.Button();
            this.ManualDecodeBtn = new System.Windows.Forms.Button();
            this.fsw = new System.IO.FileSystemWatcher();
            this.SetWatchFolderBtn = new System.Windows.Forms.Button();
            this.CurrentlyWatchingLbl = new System.Windows.Forms.Label();
            this.CurrentlyWatchingTbx = new System.Windows.Forms.TextBox();
            this.EnableDisableWatcherBtn = new System.Windows.Forms.Button();
            this.ManualEncodeBtn = new System.Windows.Forms.Button();
            this.SetOutputFolderBtn = new System.Windows.Forms.Button();
            this.CurrentOutputFolderTbx = new System.Windows.Forms.TextBox();
            this.CurrentOutputFolderLbl = new System.Windows.Forms.Label();
            this.CipherStatusLbl = new System.Windows.Forms.Label();
            this.CipherStatusTbx = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.A51MenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A51SaveCipherMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A51LoadCipherMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XTEAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XXTEASaveCipherStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XXTEALoadCipherStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CipherSelectionTc = new System.Windows.Forms.TabControl();
            this.A51tab = new System.Windows.Forms.TabPage();
            this.A51LoadInitializationVectorBtn = new System.Windows.Forms.Button();
            this.A51CurrentInitializationVectorTbx = new System.Windows.Forms.TextBox();
            this.A51CurrentInitializationVectorLbl = new System.Windows.Forms.Label();
            this.A51InitializationVectorTbx = new System.Windows.Forms.TextBox();
            this.A51InitializationVectorLbl = new System.Windows.Forms.Label();
            this.XXTEAtab = new System.Windows.Forms.TabPage();
            this.XXTEALoadInitializationVectorBtn = new System.Windows.Forms.Button();
            this.XXTEACurrentInitializationVectorTbx = new System.Windows.Forms.TextBox();
            this.XXTEACurrentInitializationVectorLbl = new System.Windows.Forms.Label();
            this.XXTEAInitializationVectorTbx = new System.Windows.Forms.TextBox();
            this.XXTEAInitializationVectorLbl = new System.Windows.Forms.Label();
            this.CurrentBlockSizeLbl = new System.Windows.Forms.Label();
            this.CurrentBlockSizeTbx = new System.Windows.Forms.TextBox();
            this.BlockSizeLbl = new System.Windows.Forms.Label();
            this.BlockSizeNud = new System.Windows.Forms.NumericUpDown();
            this.LoadBlockSizeBtn = new System.Windows.Forms.Button();
            this.LoadKeysBtn = new System.Windows.Forms.Button();
            this.CurrentKeyOneLbl = new System.Windows.Forms.Label();
            this.CurrentKeyOneTbx = new System.Windows.Forms.TextBox();
            this.CurrentKeyTwoLbl = new System.Windows.Forms.Label();
            this.CurrentKeyTwoTbx = new System.Windows.Forms.TextBox();
            this.CurrentKeyThreeLbl = new System.Windows.Forms.Label();
            this.CurrentKeyThreeTbx = new System.Windows.Forms.TextBox();
            this.CurrentKeyFourLbl = new System.Windows.Forms.Label();
            this.CurrentKeyFourTbx = new System.Windows.Forms.TextBox();
            this.KeyOneTbx = new System.Windows.Forms.TextBox();
            this.KeyOneLbl = new System.Windows.Forms.Label();
            this.KeyTwoTbx = new System.Windows.Forms.TextBox();
            this.KeyTwoLbl = new System.Windows.Forms.Label();
            this.KeyThreeTbx = new System.Windows.Forms.TextBox();
            this.KeyThreeLbl = new System.Windows.Forms.Label();
            this.KeyFourTbx = new System.Windows.Forms.TextBox();
            this.KeyFourLbl = new System.Windows.Forms.Label();
            this.ActiveCipherTbx = new System.Windows.Forms.TextBox();
            this.ActiveCipherLbl = new System.Windows.Forms.Label();
            this.CBCStatusTbx = new System.Windows.Forms.TextBox();
            this.CBCStatusLbl = new System.Windows.Forms.Label();
            this.EnableDisableCBCBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.XVoteBitNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVoteBitNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVoteBitNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.CipherSelectionTc.SuspendLayout();
            this.A51tab.SuspendLayout();
            this.XXTEAtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlockSizeNud)).BeginInit();
            this.SuspendLayout();
            // 
            // inputSeedTbx
            // 
            this.inputSeedTbx.Location = new System.Drawing.Point(8, 23);
            this.inputSeedTbx.Name = "inputSeedTbx";
            this.inputSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputSeedTbx.TabIndex = 0;
            // 
            // SeedLbl
            // 
            this.SeedLbl.AutoSize = true;
            this.SeedLbl.Location = new System.Drawing.Point(8, 5);
            this.SeedLbl.Name = "SeedLbl";
            this.SeedLbl.Size = new System.Drawing.Size(35, 15);
            this.SeedLbl.TabIndex = 1;
            this.SeedLbl.Text = "Seed:";
            // 
            // currentSeedLbl
            // 
            this.currentSeedLbl.AutoSize = true;
            this.currentSeedLbl.Location = new System.Drawing.Point(8, 56);
            this.currentSeedLbl.Name = "currentSeedLbl";
            this.currentSeedLbl.Size = new System.Drawing.Size(77, 15);
            this.currentSeedLbl.TabIndex = 2;
            this.currentSeedLbl.Text = "Current seed:";
            // 
            // currentSeedTbx
            // 
            this.currentSeedTbx.Location = new System.Drawing.Point(8, 74);
            this.currentSeedTbx.Name = "currentSeedTbx";
            this.currentSeedTbx.ReadOnly = true;
            this.currentSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.currentSeedTbx.TabIndex = 4;
            // 
            // XCurrentSeedTbx
            // 
            this.XCurrentSeedTbx.Location = new System.Drawing.Point(202, 74);
            this.XCurrentSeedTbx.Name = "XCurrentSeedTbx";
            this.XCurrentSeedTbx.ReadOnly = true;
            this.XCurrentSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.XCurrentSeedTbx.TabIndex = 8;
            // 
            // XCurrentSeedLbl
            // 
            this.XCurrentSeedLbl.AutoSize = true;
            this.XCurrentSeedLbl.Location = new System.Drawing.Point(202, 56);
            this.XCurrentSeedLbl.Name = "XCurrentSeedLbl";
            this.XCurrentSeedLbl.Size = new System.Drawing.Size(88, 15);
            this.XCurrentSeedLbl.TabIndex = 7;
            this.XCurrentSeedLbl.Text = "X Current Seed:";
            // 
            // XSeedLbl
            // 
            this.XSeedLbl.AutoSize = true;
            this.XSeedLbl.Location = new System.Drawing.Point(202, 5);
            this.XSeedLbl.Name = "XSeedLbl";
            this.XSeedLbl.Size = new System.Drawing.Size(45, 15);
            this.XSeedLbl.TabIndex = 6;
            this.XSeedLbl.Text = "X Seed:";
            // 
            // inputXSeedTbx
            // 
            this.inputXSeedTbx.Location = new System.Drawing.Point(202, 23);
            this.inputXSeedTbx.Name = "inputXSeedTbx";
            this.inputXSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputXSeedTbx.TabIndex = 5;
            // 
            // ZCurrentSeedTbx
            // 
            this.ZCurrentSeedTbx.Location = new System.Drawing.Point(590, 74);
            this.ZCurrentSeedTbx.Name = "ZCurrentSeedTbx";
            this.ZCurrentSeedTbx.ReadOnly = true;
            this.ZCurrentSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.ZCurrentSeedTbx.TabIndex = 16;
            // 
            // ZCurrentSeedLbl
            // 
            this.ZCurrentSeedLbl.AutoSize = true;
            this.ZCurrentSeedLbl.Location = new System.Drawing.Point(590, 56);
            this.ZCurrentSeedLbl.Name = "ZCurrentSeedLbl";
            this.ZCurrentSeedLbl.Size = new System.Drawing.Size(88, 15);
            this.ZCurrentSeedLbl.TabIndex = 15;
            this.ZCurrentSeedLbl.Text = "Z Current Seed:";
            // 
            // ZSeedLbl
            // 
            this.ZSeedLbl.AutoSize = true;
            this.ZSeedLbl.Location = new System.Drawing.Point(590, 5);
            this.ZSeedLbl.Name = "ZSeedLbl";
            this.ZSeedLbl.Size = new System.Drawing.Size(45, 15);
            this.ZSeedLbl.TabIndex = 14;
            this.ZSeedLbl.Text = "Z Seed:";
            // 
            // inputZSeedTbx
            // 
            this.inputZSeedTbx.Location = new System.Drawing.Point(590, 23);
            this.inputZSeedTbx.Name = "inputZSeedTbx";
            this.inputZSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputZSeedTbx.TabIndex = 13;
            // 
            // YCurrentSeedTbx
            // 
            this.YCurrentSeedTbx.Location = new System.Drawing.Point(396, 74);
            this.YCurrentSeedTbx.Name = "YCurrentSeedTbx";
            this.YCurrentSeedTbx.ReadOnly = true;
            this.YCurrentSeedTbx.Size = new System.Drawing.Size(177, 23);
            this.YCurrentSeedTbx.TabIndex = 12;
            // 
            // YCurrentSeedLbl
            // 
            this.YCurrentSeedLbl.AutoSize = true;
            this.YCurrentSeedLbl.Location = new System.Drawing.Point(396, 56);
            this.YCurrentSeedLbl.Name = "YCurrentSeedLbl";
            this.YCurrentSeedLbl.Size = new System.Drawing.Size(88, 15);
            this.YCurrentSeedLbl.TabIndex = 11;
            this.YCurrentSeedLbl.Text = "Y Current Seed:";
            // 
            // YSeedLbl
            // 
            this.YSeedLbl.AutoSize = true;
            this.YSeedLbl.Location = new System.Drawing.Point(396, 5);
            this.YSeedLbl.Name = "YSeedLbl";
            this.YSeedLbl.Size = new System.Drawing.Size(45, 15);
            this.YSeedLbl.TabIndex = 10;
            this.YSeedLbl.Text = "Y Seed:";
            // 
            // inputYSeedTbx
            // 
            this.inputYSeedTbx.Location = new System.Drawing.Point(396, 23);
            this.inputYSeedTbx.Name = "inputYSeedTbx";
            this.inputYSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputYSeedTbx.TabIndex = 9;
            // 
            // LoadGlobalSeedBtn
            // 
            this.LoadGlobalSeedBtn.Location = new System.Drawing.Point(788, 9);
            this.LoadGlobalSeedBtn.Name = "LoadGlobalSeedBtn";
            this.LoadGlobalSeedBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadGlobalSeedBtn.TabIndex = 17;
            this.LoadGlobalSeedBtn.Text = "Load Global Seed";
            this.LoadGlobalSeedBtn.UseVisualStyleBackColor = true;
            this.LoadGlobalSeedBtn.Click += new System.EventHandler(this.LoadGlobalSeedBtn_Click);
            // 
            // LoadRegisterSeedsBtn
            // 
            this.LoadRegisterSeedsBtn.Location = new System.Drawing.Point(788, 63);
            this.LoadRegisterSeedsBtn.Name = "LoadRegisterSeedsBtn";
            this.LoadRegisterSeedsBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadRegisterSeedsBtn.TabIndex = 18;
            this.LoadRegisterSeedsBtn.Text = "Load Register Seeds";
            this.LoadRegisterSeedsBtn.UseVisualStyleBackColor = true;
            this.LoadRegisterSeedsBtn.Click += new System.EventHandler(this.LoadRegisterSeedsBtn_Click);
            // 
            // ZVoteBitLbl
            // 
            this.ZVoteBitLbl.AutoSize = true;
            this.ZVoteBitLbl.Location = new System.Drawing.Point(234, 134);
            this.ZVoteBitLbl.Name = "ZVoteBitLbl";
            this.ZVoteBitLbl.Size = new System.Drawing.Size(60, 15);
            this.ZVoteBitLbl.TabIndex = 19;
            this.ZVoteBitLbl.Text = "Z Vote Bit:";
            // 
            // YVoteBitLbl
            // 
            this.YVoteBitLbl.AutoSize = true;
            this.YVoteBitLbl.Location = new System.Drawing.Point(117, 134);
            this.YVoteBitLbl.Name = "YVoteBitLbl";
            this.YVoteBitLbl.Size = new System.Drawing.Size(60, 15);
            this.YVoteBitLbl.TabIndex = 22;
            this.YVoteBitLbl.Text = "Y Vote Bit:";
            // 
            // XVoteBitLbl
            // 
            this.XVoteBitLbl.AutoSize = true;
            this.XVoteBitLbl.Location = new System.Drawing.Point(8, 134);
            this.XVoteBitLbl.Name = "XVoteBitLbl";
            this.XVoteBitLbl.Size = new System.Drawing.Size(60, 15);
            this.XVoteBitLbl.TabIndex = 24;
            this.XVoteBitLbl.Text = "X Vote Bit:";
            // 
            // XVoteBitNud
            // 
            this.XVoteBitNud.Location = new System.Drawing.Point(8, 152);
            this.XVoteBitNud.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.XVoteBitNud.Name = "XVoteBitNud";
            this.XVoteBitNud.Size = new System.Drawing.Size(60, 23);
            this.XVoteBitNud.TabIndex = 25;
            // 
            // YVoteBitNud
            // 
            this.YVoteBitNud.Location = new System.Drawing.Point(117, 152);
            this.YVoteBitNud.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.YVoteBitNud.Name = "YVoteBitNud";
            this.YVoteBitNud.Size = new System.Drawing.Size(60, 23);
            this.YVoteBitNud.TabIndex = 26;
            // 
            // ZVoteBitNud
            // 
            this.ZVoteBitNud.Location = new System.Drawing.Point(234, 152);
            this.ZVoteBitNud.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.ZVoteBitNud.Name = "ZVoteBitNud";
            this.ZVoteBitNud.Size = new System.Drawing.Size(60, 23);
            this.ZVoteBitNud.TabIndex = 27;
            // 
            // LoadVoteBitsBtn
            // 
            this.LoadVoteBitsBtn.Location = new System.Drawing.Point(786, 127);
            this.LoadVoteBitsBtn.Name = "LoadVoteBitsBtn";
            this.LoadVoteBitsBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadVoteBitsBtn.TabIndex = 28;
            this.LoadVoteBitsBtn.Text = "Load Vote Bits";
            this.LoadVoteBitsBtn.UseVisualStyleBackColor = true;
            this.LoadVoteBitsBtn.Click += new System.EventHandler(this.LoadVoteBitsBtn_Click);
            // 
            // ZCurrentVoteBitTbx
            // 
            this.ZCurrentVoteBitTbx.Location = new System.Drawing.Point(234, 202);
            this.ZCurrentVoteBitTbx.Name = "ZCurrentVoteBitTbx";
            this.ZCurrentVoteBitTbx.ReadOnly = true;
            this.ZCurrentVoteBitTbx.Size = new System.Drawing.Size(56, 23);
            this.ZCurrentVoteBitTbx.TabIndex = 34;
            // 
            // ZCurrentVoteBit
            // 
            this.ZCurrentVoteBit.AutoSize = true;
            this.ZCurrentVoteBit.Location = new System.Drawing.Point(234, 184);
            this.ZCurrentVoteBit.Name = "ZCurrentVoteBit";
            this.ZCurrentVoteBit.Size = new System.Drawing.Size(103, 15);
            this.ZCurrentVoteBit.TabIndex = 33;
            this.ZCurrentVoteBit.Text = "Z Current Vote Bit:";
            // 
            // YCurrentVoteBitTbx
            // 
            this.YCurrentVoteBitTbx.Location = new System.Drawing.Point(117, 202);
            this.YCurrentVoteBitTbx.Name = "YCurrentVoteBitTbx";
            this.YCurrentVoteBitTbx.ReadOnly = true;
            this.YCurrentVoteBitTbx.Size = new System.Drawing.Size(56, 23);
            this.YCurrentVoteBitTbx.TabIndex = 32;
            // 
            // YCurrentVoteBitLbl
            // 
            this.YCurrentVoteBitLbl.AutoSize = true;
            this.YCurrentVoteBitLbl.Location = new System.Drawing.Point(117, 184);
            this.YCurrentVoteBitLbl.Name = "YCurrentVoteBitLbl";
            this.YCurrentVoteBitLbl.Size = new System.Drawing.Size(103, 15);
            this.YCurrentVoteBitLbl.TabIndex = 31;
            this.YCurrentVoteBitLbl.Text = "Y Current Vote Bit:";
            // 
            // XCurrentVoteBitTbx
            // 
            this.XCurrentVoteBitTbx.Location = new System.Drawing.Point(8, 202);
            this.XCurrentVoteBitTbx.Name = "XCurrentVoteBitTbx";
            this.XCurrentVoteBitTbx.ReadOnly = true;
            this.XCurrentVoteBitTbx.Size = new System.Drawing.Size(56, 23);
            this.XCurrentVoteBitTbx.TabIndex = 30;
            // 
            // XCurrentVoteBitLbl
            // 
            this.XCurrentVoteBitLbl.AutoSize = true;
            this.XCurrentVoteBitLbl.Location = new System.Drawing.Point(8, 184);
            this.XCurrentVoteBitLbl.Name = "XCurrentVoteBitLbl";
            this.XCurrentVoteBitLbl.Size = new System.Drawing.Size(103, 15);
            this.XCurrentVoteBitLbl.TabIndex = 29;
            this.XCurrentVoteBitLbl.Text = "X Current Vote Bit:";
            // 
            // ZStepBitsLbl
            // 
            this.ZStepBitsLbl.AutoSize = true;
            this.ZStepBitsLbl.Location = new System.Drawing.Point(616, 134);
            this.ZStepBitsLbl.Name = "ZStepBitsLbl";
            this.ZStepBitsLbl.Size = new System.Drawing.Size(65, 15);
            this.ZStepBitsLbl.TabIndex = 40;
            this.ZStepBitsLbl.Text = "Z Step Bits:";
            // 
            // ZStepBitsTbx
            // 
            this.ZStepBitsTbx.Location = new System.Drawing.Point(616, 152);
            this.ZStepBitsTbx.Name = "ZStepBitsTbx";
            this.ZStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.ZStepBitsTbx.TabIndex = 39;
            // 
            // YStepBitsLbl
            // 
            this.YStepBitsLbl.AutoSize = true;
            this.YStepBitsLbl.Location = new System.Drawing.Point(506, 134);
            this.YStepBitsLbl.Name = "YStepBitsLbl";
            this.YStepBitsLbl.Size = new System.Drawing.Size(65, 15);
            this.YStepBitsLbl.TabIndex = 38;
            this.YStepBitsLbl.Text = "Y Step Bits:";
            // 
            // YStepBitsTbx
            // 
            this.YStepBitsTbx.Location = new System.Drawing.Point(506, 152);
            this.YStepBitsTbx.Name = "YStepBitsTbx";
            this.YStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.YStepBitsTbx.TabIndex = 37;
            // 
            // XStepBitsLbl
            // 
            this.XStepBitsLbl.AutoSize = true;
            this.XStepBitsLbl.Location = new System.Drawing.Point(396, 134);
            this.XStepBitsLbl.Name = "XStepBitsLbl";
            this.XStepBitsLbl.Size = new System.Drawing.Size(65, 15);
            this.XStepBitsLbl.TabIndex = 36;
            this.XStepBitsLbl.Text = "X Step Bits:";
            // 
            // XStepBitsTbx
            // 
            this.XStepBitsTbx.Location = new System.Drawing.Point(396, 152);
            this.XStepBitsTbx.Name = "XStepBitsTbx";
            this.XStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.XStepBitsTbx.TabIndex = 35;
            // 
            // ZCurrentStepBitsLbl
            // 
            this.ZCurrentStepBitsLbl.AutoSize = true;
            this.ZCurrentStepBitsLbl.Location = new System.Drawing.Point(616, 184);
            this.ZCurrentStepBitsLbl.Name = "ZCurrentStepBitsLbl";
            this.ZCurrentStepBitsLbl.Size = new System.Drawing.Size(108, 15);
            this.ZCurrentStepBitsLbl.TabIndex = 46;
            this.ZCurrentStepBitsLbl.Text = "Z Current Step Bits:";
            // 
            // ZCurrentStepBitsTbx
            // 
            this.ZCurrentStepBitsTbx.Location = new System.Drawing.Point(616, 202);
            this.ZCurrentStepBitsTbx.Name = "ZCurrentStepBitsTbx";
            this.ZCurrentStepBitsTbx.ReadOnly = true;
            this.ZCurrentStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.ZCurrentStepBitsTbx.TabIndex = 45;
            // 
            // YCurrentStepBitsLbl
            // 
            this.YCurrentStepBitsLbl.AutoSize = true;
            this.YCurrentStepBitsLbl.Location = new System.Drawing.Point(506, 184);
            this.YCurrentStepBitsLbl.Name = "YCurrentStepBitsLbl";
            this.YCurrentStepBitsLbl.Size = new System.Drawing.Size(108, 15);
            this.YCurrentStepBitsLbl.TabIndex = 44;
            this.YCurrentStepBitsLbl.Text = "Y Current Step Bits:";
            // 
            // YCurrentStepBitsTbx
            // 
            this.YCurrentStepBitsTbx.Location = new System.Drawing.Point(506, 202);
            this.YCurrentStepBitsTbx.Name = "YCurrentStepBitsTbx";
            this.YCurrentStepBitsTbx.ReadOnly = true;
            this.YCurrentStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.YCurrentStepBitsTbx.TabIndex = 43;
            // 
            // XCurrentStepBitsLbl
            // 
            this.XCurrentStepBitsLbl.AutoSize = true;
            this.XCurrentStepBitsLbl.Location = new System.Drawing.Point(396, 184);
            this.XCurrentStepBitsLbl.Name = "XCurrentStepBitsLbl";
            this.XCurrentStepBitsLbl.Size = new System.Drawing.Size(108, 15);
            this.XCurrentStepBitsLbl.TabIndex = 42;
            this.XCurrentStepBitsLbl.Text = "X Current Step Bits:";
            // 
            // XCurrentStepBitsTbx
            // 
            this.XCurrentStepBitsTbx.Location = new System.Drawing.Point(396, 202);
            this.XCurrentStepBitsTbx.Name = "XCurrentStepBitsTbx";
            this.XCurrentStepBitsTbx.ReadOnly = true;
            this.XCurrentStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.XCurrentStepBitsTbx.TabIndex = 41;
            // 
            // LoadStepBitsBtn
            // 
            this.LoadStepBitsBtn.Location = new System.Drawing.Point(786, 184);
            this.LoadStepBitsBtn.Name = "LoadStepBitsBtn";
            this.LoadStepBitsBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadStepBitsBtn.TabIndex = 47;
            this.LoadStepBitsBtn.Text = "Load Step Bits";
            this.LoadStepBitsBtn.UseVisualStyleBackColor = true;
            this.LoadStepBitsBtn.Click += new System.EventHandler(this.LoadStepBitsBtn_Click);
            // 
            // InitializeCipherBtn
            // 
            this.InitializeCipherBtn.Location = new System.Drawing.Point(12, 582);
            this.InitializeCipherBtn.Name = "InitializeCipherBtn";
            this.InitializeCipherBtn.Size = new System.Drawing.Size(91, 48);
            this.InitializeCipherBtn.TabIndex = 48;
            this.InitializeCipherBtn.Text = "Initialize Cipher";
            this.InitializeCipherBtn.UseVisualStyleBackColor = true;
            this.InitializeCipherBtn.Click += new System.EventHandler(this.InitializeCipherBtn_Click);
            // 
            // ManualDecodeBtn
            // 
            this.ManualDecodeBtn.Enabled = false;
            this.ManualDecodeBtn.Location = new System.Drawing.Point(230, 582);
            this.ManualDecodeBtn.Name = "ManualDecodeBtn";
            this.ManualDecodeBtn.Size = new System.Drawing.Size(91, 48);
            this.ManualDecodeBtn.TabIndex = 49;
            this.ManualDecodeBtn.Text = "Manual Decode";
            this.ManualDecodeBtn.UseVisualStyleBackColor = true;
            this.ManualDecodeBtn.Click += new System.EventHandler(this.ManualDecodeBtn_Click);
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fsw.Path = ".";
            this.fsw.SynchronizingObject = this;
            this.fsw.Changed += new System.IO.FileSystemEventHandler(this.fsw_Changed);
            this.fsw.Created += new System.IO.FileSystemEventHandler(this.fsw_Created);
            // 
            // SetWatchFolderBtn
            // 
            this.SetWatchFolderBtn.Location = new System.Drawing.Point(693, 582);
            this.SetWatchFolderBtn.Name = "SetWatchFolderBtn";
            this.SetWatchFolderBtn.Size = new System.Drawing.Size(91, 48);
            this.SetWatchFolderBtn.TabIndex = 50;
            this.SetWatchFolderBtn.Text = "Set Watch Folder";
            this.SetWatchFolderBtn.UseVisualStyleBackColor = true;
            this.SetWatchFolderBtn.Click += new System.EventHandler(this.SetWatchFolderBtn_Click);
            // 
            // CurrentlyWatchingLbl
            // 
            this.CurrentlyWatchingLbl.AutoSize = true;
            this.CurrentlyWatchingLbl.Location = new System.Drawing.Point(579, 454);
            this.CurrentlyWatchingLbl.Name = "CurrentlyWatchingLbl";
            this.CurrentlyWatchingLbl.Size = new System.Drawing.Size(113, 15);
            this.CurrentlyWatchingLbl.TabIndex = 51;
            this.CurrentlyWatchingLbl.Text = "Currently Watching:";
            // 
            // CurrentlyWatchingTbx
            // 
            this.CurrentlyWatchingTbx.Location = new System.Drawing.Point(579, 481);
            this.CurrentlyWatchingTbx.Name = "CurrentlyWatchingTbx";
            this.CurrentlyWatchingTbx.ReadOnly = true;
            this.CurrentlyWatchingTbx.Size = new System.Drawing.Size(302, 23);
            this.CurrentlyWatchingTbx.TabIndex = 52;
            // 
            // EnableDisableWatcherBtn
            // 
            this.EnableDisableWatcherBtn.Enabled = false;
            this.EnableDisableWatcherBtn.Location = new System.Drawing.Point(469, 582);
            this.EnableDisableWatcherBtn.Name = "EnableDisableWatcherBtn";
            this.EnableDisableWatcherBtn.Size = new System.Drawing.Size(91, 48);
            this.EnableDisableWatcherBtn.TabIndex = 53;
            this.EnableDisableWatcherBtn.Text = "Enable Watcher";
            this.EnableDisableWatcherBtn.UseVisualStyleBackColor = true;
            this.EnableDisableWatcherBtn.Click += new System.EventHandler(this.EnableDisableWatcherBtn_Click);
            // 
            // ManualEncodeBtn
            // 
            this.ManualEncodeBtn.Enabled = false;
            this.ManualEncodeBtn.Location = new System.Drawing.Point(133, 582);
            this.ManualEncodeBtn.Name = "ManualEncodeBtn";
            this.ManualEncodeBtn.Size = new System.Drawing.Size(91, 48);
            this.ManualEncodeBtn.TabIndex = 54;
            this.ManualEncodeBtn.Text = "Manual Encode";
            this.ManualEncodeBtn.UseVisualStyleBackColor = true;
            this.ManualEncodeBtn.Click += new System.EventHandler(this.ManualEncodeBtn_Click);
            // 
            // SetOutputFolderBtn
            // 
            this.SetOutputFolderBtn.Location = new System.Drawing.Point(790, 582);
            this.SetOutputFolderBtn.Name = "SetOutputFolderBtn";
            this.SetOutputFolderBtn.Size = new System.Drawing.Size(91, 48);
            this.SetOutputFolderBtn.TabIndex = 55;
            this.SetOutputFolderBtn.Text = "Set Output Folder";
            this.SetOutputFolderBtn.UseVisualStyleBackColor = true;
            this.SetOutputFolderBtn.Click += new System.EventHandler(this.SetOutputFolderBtn_Click);
            // 
            // CurrentOutputFolderTbx
            // 
            this.CurrentOutputFolderTbx.Location = new System.Drawing.Point(579, 545);
            this.CurrentOutputFolderTbx.Name = "CurrentOutputFolderTbx";
            this.CurrentOutputFolderTbx.ReadOnly = true;
            this.CurrentOutputFolderTbx.Size = new System.Drawing.Size(302, 23);
            this.CurrentOutputFolderTbx.TabIndex = 57;
            // 
            // CurrentOutputFolderLbl
            // 
            this.CurrentOutputFolderLbl.AutoSize = true;
            this.CurrentOutputFolderLbl.Location = new System.Drawing.Point(579, 518);
            this.CurrentOutputFolderLbl.Name = "CurrentOutputFolderLbl";
            this.CurrentOutputFolderLbl.Size = new System.Drawing.Size(127, 15);
            this.CurrentOutputFolderLbl.TabIndex = 56;
            this.CurrentOutputFolderLbl.Text = "Current Output Folder:";
            // 
            // CipherStatusLbl
            // 
            this.CipherStatusLbl.AutoSize = true;
            this.CipherStatusLbl.Location = new System.Drawing.Point(12, 518);
            this.CipherStatusLbl.Name = "CipherStatusLbl";
            this.CipherStatusLbl.Size = new System.Drawing.Size(80, 15);
            this.CipherStatusLbl.TabIndex = 58;
            this.CipherStatusLbl.Text = "Cipher Status:";
            // 
            // CipherStatusTbx
            // 
            this.CipherStatusTbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CipherStatusTbx.ForeColor = System.Drawing.Color.Red;
            this.CipherStatusTbx.Location = new System.Drawing.Point(12, 544);
            this.CipherStatusTbx.Name = "CipherStatusTbx";
            this.CipherStatusTbx.ReadOnly = true;
            this.CipherStatusTbx.Size = new System.Drawing.Size(100, 23);
            this.CipherStatusTbx.TabIndex = 59;
            this.CipherStatusTbx.Text = "Not Initialzied";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.A51MenuStripItem,
            this.XTEAToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(895, 24);
            this.menuStrip.TabIndex = 60;
            this.menuStrip.Text = "menuStrip1";
            // 
            // A51MenuStripItem
            // 
            this.A51MenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.A51SaveCipherMenuStripItem,
            this.A51LoadCipherMenuStripItem});
            this.A51MenuStripItem.Name = "A51MenuStripItem";
            this.A51MenuStripItem.Size = new System.Drawing.Size(39, 20);
            this.A51MenuStripItem.Text = "A51";
            // 
            // A51SaveCipherMenuStripItem
            // 
            this.A51SaveCipherMenuStripItem.Enabled = false;
            this.A51SaveCipherMenuStripItem.Name = "A51SaveCipherMenuStripItem";
            this.A51SaveCipherMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.A51SaveCipherMenuStripItem.Text = "Save Cipher State";
            this.A51SaveCipherMenuStripItem.Click += new System.EventHandler(this.A51SaveCipherMenuStripItem_Click);
            // 
            // A51LoadCipherMenuStripItem
            // 
            this.A51LoadCipherMenuStripItem.Name = "A51LoadCipherMenuStripItem";
            this.A51LoadCipherMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.A51LoadCipherMenuStripItem.Text = "Load Cipher State";
            this.A51LoadCipherMenuStripItem.Click += new System.EventHandler(this.A51LoadCipherMenuStripItem_Click);
            // 
            // XTEAToolStripMenuItem
            // 
            this.XTEAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XXTEASaveCipherStateToolStripMenuItem,
            this.XXTEALoadCipherStateToolStripMenuItem});
            this.XTEAToolStripMenuItem.Name = "XTEAToolStripMenuItem";
            this.XTEAToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.XTEAToolStripMenuItem.Text = "XXTEA";
            // 
            // XXTEASaveCipherStateToolStripMenuItem
            // 
            this.XXTEASaveCipherStateToolStripMenuItem.Enabled = false;
            this.XXTEASaveCipherStateToolStripMenuItem.Name = "XXTEASaveCipherStateToolStripMenuItem";
            this.XXTEASaveCipherStateToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.XXTEASaveCipherStateToolStripMenuItem.Text = "Save Cipher State";
            this.XXTEASaveCipherStateToolStripMenuItem.Click += new System.EventHandler(this.XXTEASaveCipherStateToolStripMenuItem_Click);
            // 
            // XXTEALoadCipherStateToolStripMenuItem
            // 
            this.XXTEALoadCipherStateToolStripMenuItem.Name = "XXTEALoadCipherStateToolStripMenuItem";
            this.XXTEALoadCipherStateToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.XXTEALoadCipherStateToolStripMenuItem.Text = "Load Cipher State";
            this.XXTEALoadCipherStateToolStripMenuItem.Click += new System.EventHandler(this.XXTEALloadCipherStateToolStripMenuItem_Click);
            // 
            // CipherSelectionTc
            // 
            this.CipherSelectionTc.Controls.Add(this.A51tab);
            this.CipherSelectionTc.Controls.Add(this.XXTEAtab);
            this.CipherSelectionTc.Location = new System.Drawing.Point(0, 27);
            this.CipherSelectionTc.Name = "CipherSelectionTc";
            this.CipherSelectionTc.SelectedIndex = 0;
            this.CipherSelectionTc.Size = new System.Drawing.Size(893, 361);
            this.CipherSelectionTc.TabIndex = 61;
            this.CipherSelectionTc.SelectedIndexChanged += new System.EventHandler(this.CipherSelectionTc_SelectedIndexChanged);
            this.CipherSelectionTc.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.CipherSelectionTc_Selecting);
            // 
            // A51tab
            // 
            this.A51tab.Controls.Add(this.A51LoadInitializationVectorBtn);
            this.A51tab.Controls.Add(this.A51CurrentInitializationVectorTbx);
            this.A51tab.Controls.Add(this.A51CurrentInitializationVectorLbl);
            this.A51tab.Controls.Add(this.inputSeedTbx);
            this.A51tab.Controls.Add(this.A51InitializationVectorTbx);
            this.A51tab.Controls.Add(this.SeedLbl);
            this.A51tab.Controls.Add(this.A51InitializationVectorLbl);
            this.A51tab.Controls.Add(this.currentSeedLbl);
            this.A51tab.Controls.Add(this.currentSeedTbx);
            this.A51tab.Controls.Add(this.inputXSeedTbx);
            this.A51tab.Controls.Add(this.XSeedLbl);
            this.A51tab.Controls.Add(this.XCurrentSeedLbl);
            this.A51tab.Controls.Add(this.XCurrentSeedTbx);
            this.A51tab.Controls.Add(this.inputYSeedTbx);
            this.A51tab.Controls.Add(this.YSeedLbl);
            this.A51tab.Controls.Add(this.YCurrentSeedLbl);
            this.A51tab.Controls.Add(this.YCurrentSeedTbx);
            this.A51tab.Controls.Add(this.inputZSeedTbx);
            this.A51tab.Controls.Add(this.ZSeedLbl);
            this.A51tab.Controls.Add(this.LoadStepBitsBtn);
            this.A51tab.Controls.Add(this.ZCurrentSeedLbl);
            this.A51tab.Controls.Add(this.ZCurrentStepBitsLbl);
            this.A51tab.Controls.Add(this.ZCurrentSeedTbx);
            this.A51tab.Controls.Add(this.ZCurrentStepBitsTbx);
            this.A51tab.Controls.Add(this.LoadGlobalSeedBtn);
            this.A51tab.Controls.Add(this.YCurrentStepBitsLbl);
            this.A51tab.Controls.Add(this.LoadRegisterSeedsBtn);
            this.A51tab.Controls.Add(this.YCurrentStepBitsTbx);
            this.A51tab.Controls.Add(this.ZVoteBitLbl);
            this.A51tab.Controls.Add(this.XCurrentStepBitsLbl);
            this.A51tab.Controls.Add(this.YVoteBitLbl);
            this.A51tab.Controls.Add(this.XCurrentStepBitsTbx);
            this.A51tab.Controls.Add(this.XVoteBitLbl);
            this.A51tab.Controls.Add(this.ZStepBitsLbl);
            this.A51tab.Controls.Add(this.XVoteBitNud);
            this.A51tab.Controls.Add(this.ZStepBitsTbx);
            this.A51tab.Controls.Add(this.YVoteBitNud);
            this.A51tab.Controls.Add(this.YStepBitsLbl);
            this.A51tab.Controls.Add(this.ZVoteBitNud);
            this.A51tab.Controls.Add(this.YStepBitsTbx);
            this.A51tab.Controls.Add(this.LoadVoteBitsBtn);
            this.A51tab.Controls.Add(this.XStepBitsLbl);
            this.A51tab.Controls.Add(this.XCurrentVoteBitLbl);
            this.A51tab.Controls.Add(this.XStepBitsTbx);
            this.A51tab.Controls.Add(this.XCurrentVoteBitTbx);
            this.A51tab.Controls.Add(this.ZCurrentVoteBitTbx);
            this.A51tab.Controls.Add(this.YCurrentVoteBitLbl);
            this.A51tab.Controls.Add(this.ZCurrentVoteBit);
            this.A51tab.Controls.Add(this.YCurrentVoteBitTbx);
            this.A51tab.Location = new System.Drawing.Point(4, 24);
            this.A51tab.Name = "A51tab";
            this.A51tab.Padding = new System.Windows.Forms.Padding(3);
            this.A51tab.Size = new System.Drawing.Size(885, 333);
            this.A51tab.TabIndex = 0;
            this.A51tab.Text = "A51";
            this.A51tab.UseVisualStyleBackColor = true;
            // 
            // A51LoadInitializationVectorBtn
            // 
            this.A51LoadInitializationVectorBtn.Location = new System.Drawing.Point(786, 253);
            this.A51LoadInitializationVectorBtn.Name = "A51LoadInitializationVectorBtn";
            this.A51LoadInitializationVectorBtn.Size = new System.Drawing.Size(91, 56);
            this.A51LoadInitializationVectorBtn.TabIndex = 67;
            this.A51LoadInitializationVectorBtn.Text = "Load Initialization Vector";
            this.A51LoadInitializationVectorBtn.UseVisualStyleBackColor = true;
            this.A51LoadInitializationVectorBtn.Click += new System.EventHandler(this.A51LoadInitializationVectorBtn_Click);
            // 
            // A51CurrentInitializationVectorTbx
            // 
            this.A51CurrentInitializationVectorTbx.Location = new System.Drawing.Point(8, 304);
            this.A51CurrentInitializationVectorTbx.Name = "A51CurrentInitializationVectorTbx";
            this.A51CurrentInitializationVectorTbx.ReadOnly = true;
            this.A51CurrentInitializationVectorTbx.Size = new System.Drawing.Size(188, 23);
            this.A51CurrentInitializationVectorTbx.TabIndex = 69;
            // 
            // A51CurrentInitializationVectorLbl
            // 
            this.A51CurrentInitializationVectorLbl.AutoSize = true;
            this.A51CurrentInitializationVectorLbl.Location = new System.Drawing.Point(8, 286);
            this.A51CurrentInitializationVectorLbl.Name = "A51CurrentInitializationVectorLbl";
            this.A51CurrentInitializationVectorLbl.Size = new System.Drawing.Size(153, 15);
            this.A51CurrentInitializationVectorLbl.TabIndex = 70;
            this.A51CurrentInitializationVectorLbl.Text = "Current Initialization Vector:";
            // 
            // A51InitializationVectorTbx
            // 
            this.A51InitializationVectorTbx.Location = new System.Drawing.Point(8, 253);
            this.A51InitializationVectorTbx.Name = "A51InitializationVectorTbx";
            this.A51InitializationVectorTbx.Size = new System.Drawing.Size(188, 23);
            this.A51InitializationVectorTbx.TabIndex = 67;
            // 
            // A51InitializationVectorLbl
            // 
            this.A51InitializationVectorLbl.AutoSize = true;
            this.A51InitializationVectorLbl.Location = new System.Drawing.Point(8, 235);
            this.A51InitializationVectorLbl.Name = "A51InitializationVectorLbl";
            this.A51InitializationVectorLbl.Size = new System.Drawing.Size(110, 15);
            this.A51InitializationVectorLbl.TabIndex = 68;
            this.A51InitializationVectorLbl.Text = "Initialization Vector:";
            // 
            // XXTEAtab
            // 
            this.XXTEAtab.Controls.Add(this.XXTEALoadInitializationVectorBtn);
            this.XXTEAtab.Controls.Add(this.XXTEACurrentInitializationVectorTbx);
            this.XXTEAtab.Controls.Add(this.XXTEACurrentInitializationVectorLbl);
            this.XXTEAtab.Controls.Add(this.XXTEAInitializationVectorTbx);
            this.XXTEAtab.Controls.Add(this.XXTEAInitializationVectorLbl);
            this.XXTEAtab.Controls.Add(this.CurrentBlockSizeLbl);
            this.XXTEAtab.Controls.Add(this.CurrentBlockSizeTbx);
            this.XXTEAtab.Controls.Add(this.BlockSizeLbl);
            this.XXTEAtab.Controls.Add(this.BlockSizeNud);
            this.XXTEAtab.Controls.Add(this.LoadBlockSizeBtn);
            this.XXTEAtab.Controls.Add(this.LoadKeysBtn);
            this.XXTEAtab.Controls.Add(this.CurrentKeyOneLbl);
            this.XXTEAtab.Controls.Add(this.CurrentKeyOneTbx);
            this.XXTEAtab.Controls.Add(this.CurrentKeyTwoLbl);
            this.XXTEAtab.Controls.Add(this.CurrentKeyTwoTbx);
            this.XXTEAtab.Controls.Add(this.CurrentKeyThreeLbl);
            this.XXTEAtab.Controls.Add(this.CurrentKeyThreeTbx);
            this.XXTEAtab.Controls.Add(this.CurrentKeyFourLbl);
            this.XXTEAtab.Controls.Add(this.CurrentKeyFourTbx);
            this.XXTEAtab.Controls.Add(this.KeyOneTbx);
            this.XXTEAtab.Controls.Add(this.KeyOneLbl);
            this.XXTEAtab.Controls.Add(this.KeyTwoTbx);
            this.XXTEAtab.Controls.Add(this.KeyTwoLbl);
            this.XXTEAtab.Controls.Add(this.KeyThreeTbx);
            this.XXTEAtab.Controls.Add(this.KeyThreeLbl);
            this.XXTEAtab.Controls.Add(this.KeyFourTbx);
            this.XXTEAtab.Controls.Add(this.KeyFourLbl);
            this.XXTEAtab.Location = new System.Drawing.Point(4, 24);
            this.XXTEAtab.Name = "XXTEAtab";
            this.XXTEAtab.Padding = new System.Windows.Forms.Padding(3);
            this.XXTEAtab.Size = new System.Drawing.Size(885, 333);
            this.XXTEAtab.TabIndex = 1;
            this.XXTEAtab.Text = "XXTEA";
            this.XXTEAtab.UseVisualStyleBackColor = true;
            // 
            // XXTEALoadInitializationVectorBtn
            // 
            this.XXTEALoadInitializationVectorBtn.Location = new System.Drawing.Point(788, 253);
            this.XXTEALoadInitializationVectorBtn.Name = "XXTEALoadInitializationVectorBtn";
            this.XXTEALoadInitializationVectorBtn.Size = new System.Drawing.Size(91, 56);
            this.XXTEALoadInitializationVectorBtn.TabIndex = 41;
            this.XXTEALoadInitializationVectorBtn.Text = "Load Initialization Vector";
            this.XXTEALoadInitializationVectorBtn.UseVisualStyleBackColor = true;
            this.XXTEALoadInitializationVectorBtn.Click += new System.EventHandler(this.XXTEALoadInitializationVectorBtn_Click);
            // 
            // XXTEACurrentInitializationVectorTbx
            // 
            this.XXTEACurrentInitializationVectorTbx.Location = new System.Drawing.Point(8, 304);
            this.XXTEACurrentInitializationVectorTbx.Name = "XXTEACurrentInitializationVectorTbx";
            this.XXTEACurrentInitializationVectorTbx.ReadOnly = true;
            this.XXTEACurrentInitializationVectorTbx.Size = new System.Drawing.Size(188, 23);
            this.XXTEACurrentInitializationVectorTbx.TabIndex = 39;
            // 
            // XXTEACurrentInitializationVectorLbl
            // 
            this.XXTEACurrentInitializationVectorLbl.AutoSize = true;
            this.XXTEACurrentInitializationVectorLbl.Location = new System.Drawing.Point(8, 286);
            this.XXTEACurrentInitializationVectorLbl.Name = "XXTEACurrentInitializationVectorLbl";
            this.XXTEACurrentInitializationVectorLbl.Size = new System.Drawing.Size(153, 15);
            this.XXTEACurrentInitializationVectorLbl.TabIndex = 40;
            this.XXTEACurrentInitializationVectorLbl.Text = "Current Initialization Vector:";
            // 
            // XXTEAInitializationVectorTbx
            // 
            this.XXTEAInitializationVectorTbx.Location = new System.Drawing.Point(8, 253);
            this.XXTEAInitializationVectorTbx.Name = "XXTEAInitializationVectorTbx";
            this.XXTEAInitializationVectorTbx.Size = new System.Drawing.Size(188, 23);
            this.XXTEAInitializationVectorTbx.TabIndex = 37;
            // 
            // XXTEAInitializationVectorLbl
            // 
            this.XXTEAInitializationVectorLbl.AutoSize = true;
            this.XXTEAInitializationVectorLbl.Location = new System.Drawing.Point(8, 235);
            this.XXTEAInitializationVectorLbl.Name = "XXTEAInitializationVectorLbl";
            this.XXTEAInitializationVectorLbl.Size = new System.Drawing.Size(110, 15);
            this.XXTEAInitializationVectorLbl.TabIndex = 38;
            this.XXTEAInitializationVectorLbl.Text = "Initialization Vector:";
            // 
            // CurrentBlockSizeLbl
            // 
            this.CurrentBlockSizeLbl.AutoSize = true;
            this.CurrentBlockSizeLbl.Location = new System.Drawing.Point(8, 164);
            this.CurrentBlockSizeLbl.Name = "CurrentBlockSizeLbl";
            this.CurrentBlockSizeLbl.Size = new System.Drawing.Size(148, 15);
            this.CurrentBlockSizeLbl.TabIndex = 35;
            this.CurrentBlockSizeLbl.Text = "Current Block Size (words):";
            // 
            // CurrentBlockSizeTbx
            // 
            this.CurrentBlockSizeTbx.Location = new System.Drawing.Point(8, 182);
            this.CurrentBlockSizeTbx.Name = "CurrentBlockSizeTbx";
            this.CurrentBlockSizeTbx.ReadOnly = true;
            this.CurrentBlockSizeTbx.Size = new System.Drawing.Size(56, 23);
            this.CurrentBlockSizeTbx.TabIndex = 36;
            // 
            // BlockSizeLbl
            // 
            this.BlockSizeLbl.AutoSize = true;
            this.BlockSizeLbl.Location = new System.Drawing.Point(8, 113);
            this.BlockSizeLbl.Name = "BlockSizeLbl";
            this.BlockSizeLbl.Size = new System.Drawing.Size(105, 15);
            this.BlockSizeLbl.TabIndex = 32;
            this.BlockSizeLbl.Text = "Block Size (words):";
            // 
            // BlockSizeNud
            // 
            this.BlockSizeNud.Location = new System.Drawing.Point(8, 131);
            this.BlockSizeNud.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.BlockSizeNud.Name = "BlockSizeNud";
            this.BlockSizeNud.Size = new System.Drawing.Size(100, 23);
            this.BlockSizeNud.TabIndex = 33;
            // 
            // LoadBlockSizeBtn
            // 
            this.LoadBlockSizeBtn.Location = new System.Drawing.Point(788, 106);
            this.LoadBlockSizeBtn.Name = "LoadBlockSizeBtn";
            this.LoadBlockSizeBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadBlockSizeBtn.TabIndex = 34;
            this.LoadBlockSizeBtn.Text = "Load Block Size";
            this.LoadBlockSizeBtn.UseVisualStyleBackColor = true;
            this.LoadBlockSizeBtn.Click += new System.EventHandler(this.LoadBlockSizeBtn_Click);
            // 
            // LoadKeysBtn
            // 
            this.LoadKeysBtn.Location = new System.Drawing.Point(786, 37);
            this.LoadKeysBtn.Name = "LoadKeysBtn";
            this.LoadKeysBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadKeysBtn.TabIndex = 31;
            this.LoadKeysBtn.Text = "Load Keys";
            this.LoadKeysBtn.UseVisualStyleBackColor = true;
            this.LoadKeysBtn.Click += new System.EventHandler(this.LoadKeysBtn_Click);
            // 
            // CurrentKeyOneLbl
            // 
            this.CurrentKeyOneLbl.AutoSize = true;
            this.CurrentKeyOneLbl.Location = new System.Drawing.Point(8, 54);
            this.CurrentKeyOneLbl.Name = "CurrentKeyOneLbl";
            this.CurrentKeyOneLbl.Size = new System.Drawing.Size(81, 15);
            this.CurrentKeyOneLbl.TabIndex = 23;
            this.CurrentKeyOneLbl.Text = "Current Key 1:";
            // 
            // CurrentKeyOneTbx
            // 
            this.CurrentKeyOneTbx.Location = new System.Drawing.Point(8, 72);
            this.CurrentKeyOneTbx.Name = "CurrentKeyOneTbx";
            this.CurrentKeyOneTbx.ReadOnly = true;
            this.CurrentKeyOneTbx.Size = new System.Drawing.Size(188, 23);
            this.CurrentKeyOneTbx.TabIndex = 24;
            // 
            // CurrentKeyTwoLbl
            // 
            this.CurrentKeyTwoLbl.AutoSize = true;
            this.CurrentKeyTwoLbl.Location = new System.Drawing.Point(202, 54);
            this.CurrentKeyTwoLbl.Name = "CurrentKeyTwoLbl";
            this.CurrentKeyTwoLbl.Size = new System.Drawing.Size(81, 15);
            this.CurrentKeyTwoLbl.TabIndex = 25;
            this.CurrentKeyTwoLbl.Text = "Current Key 2:";
            // 
            // CurrentKeyTwoTbx
            // 
            this.CurrentKeyTwoTbx.Location = new System.Drawing.Point(202, 72);
            this.CurrentKeyTwoTbx.Name = "CurrentKeyTwoTbx";
            this.CurrentKeyTwoTbx.ReadOnly = true;
            this.CurrentKeyTwoTbx.Size = new System.Drawing.Size(188, 23);
            this.CurrentKeyTwoTbx.TabIndex = 26;
            // 
            // CurrentKeyThreeLbl
            // 
            this.CurrentKeyThreeLbl.AutoSize = true;
            this.CurrentKeyThreeLbl.Location = new System.Drawing.Point(396, 54);
            this.CurrentKeyThreeLbl.Name = "CurrentKeyThreeLbl";
            this.CurrentKeyThreeLbl.Size = new System.Drawing.Size(81, 15);
            this.CurrentKeyThreeLbl.TabIndex = 27;
            this.CurrentKeyThreeLbl.Text = "Current Key 3:";
            // 
            // CurrentKeyThreeTbx
            // 
            this.CurrentKeyThreeTbx.Location = new System.Drawing.Point(396, 72);
            this.CurrentKeyThreeTbx.Name = "CurrentKeyThreeTbx";
            this.CurrentKeyThreeTbx.ReadOnly = true;
            this.CurrentKeyThreeTbx.Size = new System.Drawing.Size(188, 23);
            this.CurrentKeyThreeTbx.TabIndex = 28;
            // 
            // CurrentKeyFourLbl
            // 
            this.CurrentKeyFourLbl.AutoSize = true;
            this.CurrentKeyFourLbl.Location = new System.Drawing.Point(590, 54);
            this.CurrentKeyFourLbl.Name = "CurrentKeyFourLbl";
            this.CurrentKeyFourLbl.Size = new System.Drawing.Size(81, 15);
            this.CurrentKeyFourLbl.TabIndex = 29;
            this.CurrentKeyFourLbl.Text = "Current Key 4:";
            // 
            // CurrentKeyFourTbx
            // 
            this.CurrentKeyFourTbx.Location = new System.Drawing.Point(590, 72);
            this.CurrentKeyFourTbx.Name = "CurrentKeyFourTbx";
            this.CurrentKeyFourTbx.ReadOnly = true;
            this.CurrentKeyFourTbx.Size = new System.Drawing.Size(188, 23);
            this.CurrentKeyFourTbx.TabIndex = 30;
            // 
            // KeyOneTbx
            // 
            this.KeyOneTbx.Location = new System.Drawing.Point(8, 21);
            this.KeyOneTbx.Name = "KeyOneTbx";
            this.KeyOneTbx.Size = new System.Drawing.Size(188, 23);
            this.KeyOneTbx.TabIndex = 15;
            // 
            // KeyOneLbl
            // 
            this.KeyOneLbl.AutoSize = true;
            this.KeyOneLbl.Location = new System.Drawing.Point(8, 3);
            this.KeyOneLbl.Name = "KeyOneLbl";
            this.KeyOneLbl.Size = new System.Drawing.Size(38, 15);
            this.KeyOneLbl.TabIndex = 16;
            this.KeyOneLbl.Text = "Key 1:";
            // 
            // KeyTwoTbx
            // 
            this.KeyTwoTbx.Location = new System.Drawing.Point(202, 21);
            this.KeyTwoTbx.Name = "KeyTwoTbx";
            this.KeyTwoTbx.Size = new System.Drawing.Size(188, 23);
            this.KeyTwoTbx.TabIndex = 17;
            // 
            // KeyTwoLbl
            // 
            this.KeyTwoLbl.AutoSize = true;
            this.KeyTwoLbl.Location = new System.Drawing.Point(202, 3);
            this.KeyTwoLbl.Name = "KeyTwoLbl";
            this.KeyTwoLbl.Size = new System.Drawing.Size(38, 15);
            this.KeyTwoLbl.TabIndex = 18;
            this.KeyTwoLbl.Text = "Key 2:";
            // 
            // KeyThreeTbx
            // 
            this.KeyThreeTbx.Location = new System.Drawing.Point(396, 21);
            this.KeyThreeTbx.Name = "KeyThreeTbx";
            this.KeyThreeTbx.Size = new System.Drawing.Size(188, 23);
            this.KeyThreeTbx.TabIndex = 19;
            // 
            // KeyThreeLbl
            // 
            this.KeyThreeLbl.AutoSize = true;
            this.KeyThreeLbl.Location = new System.Drawing.Point(396, 3);
            this.KeyThreeLbl.Name = "KeyThreeLbl";
            this.KeyThreeLbl.Size = new System.Drawing.Size(38, 15);
            this.KeyThreeLbl.TabIndex = 20;
            this.KeyThreeLbl.Text = "Key 3:";
            // 
            // KeyFourTbx
            // 
            this.KeyFourTbx.Location = new System.Drawing.Point(590, 21);
            this.KeyFourTbx.Name = "KeyFourTbx";
            this.KeyFourTbx.Size = new System.Drawing.Size(188, 23);
            this.KeyFourTbx.TabIndex = 21;
            // 
            // KeyFourLbl
            // 
            this.KeyFourLbl.AutoSize = true;
            this.KeyFourLbl.Location = new System.Drawing.Point(590, 3);
            this.KeyFourLbl.Name = "KeyFourLbl";
            this.KeyFourLbl.Size = new System.Drawing.Size(38, 15);
            this.KeyFourLbl.TabIndex = 22;
            this.KeyFourLbl.Text = "Key 4:";
            // 
            // ActiveCipherTbx
            // 
            this.ActiveCipherTbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActiveCipherTbx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ActiveCipherTbx.Location = new System.Drawing.Point(12, 481);
            this.ActiveCipherTbx.Name = "ActiveCipherTbx";
            this.ActiveCipherTbx.ReadOnly = true;
            this.ActiveCipherTbx.Size = new System.Drawing.Size(100, 23);
            this.ActiveCipherTbx.TabIndex = 63;
            this.ActiveCipherTbx.Text = "A51";
            // 
            // ActiveCipherLbl
            // 
            this.ActiveCipherLbl.AutoSize = true;
            this.ActiveCipherLbl.Location = new System.Drawing.Point(12, 455);
            this.ActiveCipherLbl.Name = "ActiveCipherLbl";
            this.ActiveCipherLbl.Size = new System.Drawing.Size(81, 15);
            this.ActiveCipherLbl.TabIndex = 62;
            this.ActiveCipherLbl.Text = "Active Cipher:";
            // 
            // CBCStatusTbx
            // 
            this.CBCStatusTbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBCStatusTbx.ForeColor = System.Drawing.Color.Red;
            this.CBCStatusTbx.Location = new System.Drawing.Point(12, 418);
            this.CBCStatusTbx.Name = "CBCStatusTbx";
            this.CBCStatusTbx.ReadOnly = true;
            this.CBCStatusTbx.Size = new System.Drawing.Size(100, 23);
            this.CBCStatusTbx.TabIndex = 65;
            this.CBCStatusTbx.Text = "Disabled";
            // 
            // CBCStatusLbl
            // 
            this.CBCStatusLbl.AutoSize = true;
            this.CBCStatusLbl.Location = new System.Drawing.Point(12, 392);
            this.CBCStatusLbl.Name = "CBCStatusLbl";
            this.CBCStatusLbl.Size = new System.Drawing.Size(67, 15);
            this.CBCStatusLbl.TabIndex = 64;
            this.CBCStatusLbl.Text = "CBC status:";
            // 
            // EnableDisableCBCBtn
            // 
            this.EnableDisableCBCBtn.Enabled = false;
            this.EnableDisableCBCBtn.Location = new System.Drawing.Point(362, 582);
            this.EnableDisableCBCBtn.Name = "EnableDisableCBCBtn";
            this.EnableDisableCBCBtn.Size = new System.Drawing.Size(91, 48);
            this.EnableDisableCBCBtn.TabIndex = 66;
            this.EnableDisableCBCBtn.Text = "Enable CBC";
            this.EnableDisableCBCBtn.UseVisualStyleBackColor = true;
            this.EnableDisableCBCBtn.Click += new System.EventHandler(this.EnableDisableCBCBtn_Click);
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 646);
            this.Controls.Add(this.EnableDisableCBCBtn);
            this.Controls.Add(this.CBCStatusTbx);
            this.Controls.Add(this.CBCStatusLbl);
            this.Controls.Add(this.ActiveCipherTbx);
            this.Controls.Add(this.ActiveCipherLbl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.CipherStatusTbx);
            this.Controls.Add(this.CipherStatusLbl);
            this.Controls.Add(this.CurrentOutputFolderTbx);
            this.Controls.Add(this.CurrentOutputFolderLbl);
            this.Controls.Add(this.SetOutputFolderBtn);
            this.Controls.Add(this.ManualEncodeBtn);
            this.Controls.Add(this.EnableDisableWatcherBtn);
            this.Controls.Add(this.CurrentlyWatchingTbx);
            this.Controls.Add(this.CurrentlyWatchingLbl);
            this.Controls.Add(this.SetWatchFolderBtn);
            this.Controls.Add(this.ManualDecodeBtn);
            this.Controls.Add(this.InitializeCipherBtn);
            this.Controls.Add(this.CipherSelectionTc);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(911, 685);
            this.MinimumSize = new System.Drawing.Size(911, 685);
            this.Name = "CipherForm";
            this.Text = "Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.XVoteBitNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVoteBitNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVoteBitNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.CipherSelectionTc.ResumeLayout(false);
            this.A51tab.ResumeLayout(false);
            this.A51tab.PerformLayout();
            this.XXTEAtab.ResumeLayout(false);
            this.XXTEAtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlockSizeNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSeedTbx;
        private System.Windows.Forms.Label SeedLbl;
        private System.Windows.Forms.Label currentSeedLbl;
        private System.Windows.Forms.TextBox currentSeedTbx;
        private System.Windows.Forms.TextBox XCurrentSeedTbx;
        private System.Windows.Forms.Label XCurrentSeedLbl;
        private System.Windows.Forms.Label XSeedLbl;
        private System.Windows.Forms.TextBox inputXSeedTbx;
        private System.Windows.Forms.TextBox ZCurrentSeedTbx;
        private System.Windows.Forms.Label ZCurrentSeedLbl;
        private System.Windows.Forms.Label ZSeedLbl;
        private System.Windows.Forms.TextBox inputZSeedTbx;
        private System.Windows.Forms.TextBox YCurrentSeedTbx;
        private System.Windows.Forms.Label YCurrentSeedLbl;
        private System.Windows.Forms.Label YSeedLbl;
        private System.Windows.Forms.TextBox inputYSeedTbx;
        private System.Windows.Forms.Button LoadGlobalSeedBtn;
        private System.Windows.Forms.Button LoadRegisterSeedsBtn;
        private System.Windows.Forms.Label ZVoteBitLbl;
        private System.Windows.Forms.Label YVoteBitLbl;
        private System.Windows.Forms.Label XVoteBitLbl;
        private System.Windows.Forms.NumericUpDown XVoteBitNud;
        private System.Windows.Forms.NumericUpDown YVoteBitNud;
        private System.Windows.Forms.NumericUpDown ZVoteBitNud;
        private System.Windows.Forms.Button LoadVoteBitsBtn;
        private System.Windows.Forms.TextBox ZCurrentVoteBitTbx;
        private System.Windows.Forms.Label ZCurrentVoteBit;
        private System.Windows.Forms.TextBox YCurrentVoteBitTbx;
        private System.Windows.Forms.Label YCurrentVoteBitLbl;
        private System.Windows.Forms.TextBox XCurrentVoteBitTbx;
        private System.Windows.Forms.Label XCurrentVoteBitLbl;
        private System.Windows.Forms.Label ZStepBitsLbl;
        private System.Windows.Forms.TextBox ZStepBitsTbx;
        private System.Windows.Forms.Label YStepBitsLbl;
        private System.Windows.Forms.TextBox YStepBitsTbx;
        private System.Windows.Forms.Label XStepBitsLbl;
        private System.Windows.Forms.TextBox XStepBitsTbx;
        private System.Windows.Forms.Label ZCurrentStepBitsLbl;
        private System.Windows.Forms.TextBox ZCurrentStepBitsTbx;
        private System.Windows.Forms.Label YCurrentStepBitsLbl;
        private System.Windows.Forms.TextBox YCurrentStepBitsTbx;
        private System.Windows.Forms.Label XCurrentStepBitsLbl;
        private System.Windows.Forms.TextBox XCurrentStepBitsTbx;
        private System.Windows.Forms.Button LoadStepBitsBtn;
        private System.Windows.Forms.Button InitializeCipherBtn;
        private System.Windows.Forms.Button ManualDecodeBtn;
        private System.Windows.Forms.Button SetWatchFolderBtn;
        private System.Windows.Forms.TextBox CurrentlyWatchingTbx;
        private System.Windows.Forms.Label CurrentlyWatchingLbl;
        private System.Windows.Forms.Button EnableDisableWatcherBtn;
        private System.Windows.Forms.Button ManualEncodeBtn;
        private System.Windows.Forms.TextBox CurrentOutputFolderTbx;
        private System.Windows.Forms.Label CurrentOutputFolderLbl;
        private System.Windows.Forms.Button SetOutputFolderBtn;
        public System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.TextBox CipherStatusTbx;
        private System.Windows.Forms.Label CipherStatusLbl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem A51MenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem A51SaveCipherMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem A51LoadCipherMenuStripItem;
        private System.Windows.Forms.TabControl CipherSelectionTc;
        private System.Windows.Forms.TabPage A51tab;
        private System.Windows.Forms.TabPage XXTEAtab;
        private System.Windows.Forms.TextBox KeyOneTbx;
        private System.Windows.Forms.Label KeyOneLbl;
        private System.Windows.Forms.TextBox KeyTwoTbx;
        private System.Windows.Forms.Label KeyTwoLbl;
        private System.Windows.Forms.TextBox KeyThreeTbx;
        private System.Windows.Forms.Label KeyThreeLbl;
        private System.Windows.Forms.TextBox KeyFourTbx;
        private System.Windows.Forms.Label KeyFourLbl;
        private System.Windows.Forms.Button LoadKeysBtn;
        private System.Windows.Forms.Label CurrentKeyOneLbl;
        private System.Windows.Forms.TextBox CurrentKeyOneTbx;
        private System.Windows.Forms.Label CurrentKeyTwoLbl;
        private System.Windows.Forms.TextBox CurrentKeyTwoTbx;
        private System.Windows.Forms.Label CurrentKeyThreeLbl;
        private System.Windows.Forms.TextBox CurrentKeyThreeTbx;
        private System.Windows.Forms.Label CurrentKeyFourLbl;
        private System.Windows.Forms.TextBox CurrentKeyFourTbx;
        private System.Windows.Forms.Label BlockSizeLbl;
        private System.Windows.Forms.NumericUpDown BlockSizeNud;
        private System.Windows.Forms.Button LoadBlockSizeBtn;
        private System.Windows.Forms.Label CurrentBlockSizeLbl;
        private System.Windows.Forms.TextBox CurrentBlockSizeTbx;
        private System.Windows.Forms.ToolStripMenuItem XTEAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XXTEASaveCipherStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XXTEALoadCipherStateToolStripMenuItem;
        private System.Windows.Forms.TextBox ActiveCipherTbx;
        private System.Windows.Forms.Label ActiveCipherLbl;
        private System.Windows.Forms.Button EnableDisableCBCBtn;
        private System.Windows.Forms.TextBox CBCStatusTbx;
        private System.Windows.Forms.Label CBCStatusLbl;
        private System.Windows.Forms.Button A51LoadInitializationVectorBtn;
        private System.Windows.Forms.TextBox A51CurrentInitializationVectorTbx;
        private System.Windows.Forms.Label A51CurrentInitializationVectorLbl;
        private System.Windows.Forms.TextBox A51InitializationVectorTbx;
        private System.Windows.Forms.Label A51InitializationVectorLbl;
        private System.Windows.Forms.Button XXTEALoadInitializationVectorBtn;
        private System.Windows.Forms.TextBox XXTEACurrentInitializationVectorTbx;
        private System.Windows.Forms.Label XXTEACurrentInitializationVectorLbl;
        private System.Windows.Forms.TextBox XXTEAInitializationVectorTbx;
        private System.Windows.Forms.Label XXTEAInitializationVectorLbl;
    }
}

