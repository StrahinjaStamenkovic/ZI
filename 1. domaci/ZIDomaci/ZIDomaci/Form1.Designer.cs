
namespace ZIDomaci
{
    partial class A51Cipher
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
            this.seedLbl = new System.Windows.Forms.Label();
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
            this.CipherMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCipherMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadCipherMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.XVoteBitNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVoteBitNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVoteBitNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputSeedTbx
            // 
            this.inputSeedTbx.Location = new System.Drawing.Point(12, 44);
            this.inputSeedTbx.Name = "inputSeedTbx";
            this.inputSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputSeedTbx.TabIndex = 0;
            // 
            // seedLbl
            // 
            this.seedLbl.AutoSize = true;
            this.seedLbl.Location = new System.Drawing.Point(12, 26);
            this.seedLbl.Name = "seedLbl";
            this.seedLbl.Size = new System.Drawing.Size(35, 15);
            this.seedLbl.TabIndex = 1;
            this.seedLbl.Text = "Seed:";
            // 
            // currentSeedLbl
            // 
            this.currentSeedLbl.AutoSize = true;
            this.currentSeedLbl.Location = new System.Drawing.Point(360, 26);
            this.currentSeedLbl.Name = "currentSeedLbl";
            this.currentSeedLbl.Size = new System.Drawing.Size(77, 15);
            this.currentSeedLbl.TabIndex = 2;
            this.currentSeedLbl.Text = "Current seed:";
            // 
            // currentSeedTbx
            // 
            this.currentSeedTbx.Location = new System.Drawing.Point(360, 44);
            this.currentSeedTbx.Name = "currentSeedTbx";
            this.currentSeedTbx.ReadOnly = true;
            this.currentSeedTbx.Size = new System.Drawing.Size(279, 23);
            this.currentSeedTbx.TabIndex = 4;
            // 
            // XCurrentSeedTbx
            // 
            this.XCurrentSeedTbx.Location = new System.Drawing.Point(360, 93);
            this.XCurrentSeedTbx.Name = "XCurrentSeedTbx";
            this.XCurrentSeedTbx.ReadOnly = true;
            this.XCurrentSeedTbx.Size = new System.Drawing.Size(279, 23);
            this.XCurrentSeedTbx.TabIndex = 8;
            // 
            // XCurrentSeedLbl
            // 
            this.XCurrentSeedLbl.AutoSize = true;
            this.XCurrentSeedLbl.Location = new System.Drawing.Point(360, 75);
            this.XCurrentSeedLbl.Name = "XCurrentSeedLbl";
            this.XCurrentSeedLbl.Size = new System.Drawing.Size(88, 15);
            this.XCurrentSeedLbl.TabIndex = 7;
            this.XCurrentSeedLbl.Text = "X Current Seed:";
            // 
            // XSeedLbl
            // 
            this.XSeedLbl.AutoSize = true;
            this.XSeedLbl.Location = new System.Drawing.Point(12, 75);
            this.XSeedLbl.Name = "XSeedLbl";
            this.XSeedLbl.Size = new System.Drawing.Size(45, 15);
            this.XSeedLbl.TabIndex = 6;
            this.XSeedLbl.Text = "X Seed:";
            // 
            // inputXSeedTbx
            // 
            this.inputXSeedTbx.Location = new System.Drawing.Point(12, 93);
            this.inputXSeedTbx.Name = "inputXSeedTbx";
            this.inputXSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputXSeedTbx.TabIndex = 5;
            // 
            // ZCurrentSeedTbx
            // 
            this.ZCurrentSeedTbx.Location = new System.Drawing.Point(360, 204);
            this.ZCurrentSeedTbx.Name = "ZCurrentSeedTbx";
            this.ZCurrentSeedTbx.ReadOnly = true;
            this.ZCurrentSeedTbx.Size = new System.Drawing.Size(279, 23);
            this.ZCurrentSeedTbx.TabIndex = 16;
            // 
            // ZCurrentSeedLbl
            // 
            this.ZCurrentSeedLbl.AutoSize = true;
            this.ZCurrentSeedLbl.Location = new System.Drawing.Point(360, 186);
            this.ZCurrentSeedLbl.Name = "ZCurrentSeedLbl";
            this.ZCurrentSeedLbl.Size = new System.Drawing.Size(88, 15);
            this.ZCurrentSeedLbl.TabIndex = 15;
            this.ZCurrentSeedLbl.Text = "Z Current Seed:";
            // 
            // ZSeedLbl
            // 
            this.ZSeedLbl.AutoSize = true;
            this.ZSeedLbl.Location = new System.Drawing.Point(12, 186);
            this.ZSeedLbl.Name = "ZSeedLbl";
            this.ZSeedLbl.Size = new System.Drawing.Size(45, 15);
            this.ZSeedLbl.TabIndex = 14;
            this.ZSeedLbl.Text = "Z Seed:";
            // 
            // inputZSeedTbx
            // 
            this.inputZSeedTbx.Location = new System.Drawing.Point(12, 204);
            this.inputZSeedTbx.Name = "inputZSeedTbx";
            this.inputZSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputZSeedTbx.TabIndex = 13;
            // 
            // YCurrentSeedTbx
            // 
            this.YCurrentSeedTbx.Location = new System.Drawing.Point(360, 149);
            this.YCurrentSeedTbx.Name = "YCurrentSeedTbx";
            this.YCurrentSeedTbx.ReadOnly = true;
            this.YCurrentSeedTbx.Size = new System.Drawing.Size(279, 23);
            this.YCurrentSeedTbx.TabIndex = 12;
            // 
            // YCurrentSeedLbl
            // 
            this.YCurrentSeedLbl.AutoSize = true;
            this.YCurrentSeedLbl.Location = new System.Drawing.Point(360, 131);
            this.YCurrentSeedLbl.Name = "YCurrentSeedLbl";
            this.YCurrentSeedLbl.Size = new System.Drawing.Size(88, 15);
            this.YCurrentSeedLbl.TabIndex = 11;
            this.YCurrentSeedLbl.Text = "Y Current Seed:";
            // 
            // YSeedLbl
            // 
            this.YSeedLbl.AutoSize = true;
            this.YSeedLbl.Location = new System.Drawing.Point(12, 131);
            this.YSeedLbl.Name = "YSeedLbl";
            this.YSeedLbl.Size = new System.Drawing.Size(45, 15);
            this.YSeedLbl.TabIndex = 10;
            this.YSeedLbl.Text = "Y Seed:";
            // 
            // inputYSeedTbx
            // 
            this.inputYSeedTbx.Location = new System.Drawing.Point(12, 149);
            this.inputYSeedTbx.Name = "inputYSeedTbx";
            this.inputYSeedTbx.Size = new System.Drawing.Size(188, 23);
            this.inputYSeedTbx.TabIndex = 9;
            // 
            // LoadGlobalSeedBtn
            // 
            this.LoadGlobalSeedBtn.Location = new System.Drawing.Point(221, 30);
            this.LoadGlobalSeedBtn.Name = "LoadGlobalSeedBtn";
            this.LoadGlobalSeedBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadGlobalSeedBtn.TabIndex = 17;
            this.LoadGlobalSeedBtn.Text = "Load Global Seed";
            this.LoadGlobalSeedBtn.UseVisualStyleBackColor = true;
            this.LoadGlobalSeedBtn.Click += new System.EventHandler(this.LoadGlobalSeedBtn_Click);
            // 
            // LoadRegisterSeedsBtn
            // 
            this.LoadRegisterSeedsBtn.Location = new System.Drawing.Point(221, 93);
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
            this.ZVoteBitLbl.Location = new System.Drawing.Point(12, 330);
            this.ZVoteBitLbl.Name = "ZVoteBitLbl";
            this.ZVoteBitLbl.Size = new System.Drawing.Size(60, 15);
            this.ZVoteBitLbl.TabIndex = 19;
            this.ZVoteBitLbl.Text = "Z Vote Bit:";
            // 
            // YVoteBitLbl
            // 
            this.YVoteBitLbl.AutoSize = true;
            this.YVoteBitLbl.Location = new System.Drawing.Point(12, 284);
            this.YVoteBitLbl.Name = "YVoteBitLbl";
            this.YVoteBitLbl.Size = new System.Drawing.Size(60, 15);
            this.YVoteBitLbl.TabIndex = 22;
            this.YVoteBitLbl.Text = "Y Vote Bit:";
            // 
            // XVoteBitLbl
            // 
            this.XVoteBitLbl.AutoSize = true;
            this.XVoteBitLbl.Location = new System.Drawing.Point(12, 240);
            this.XVoteBitLbl.Name = "XVoteBitLbl";
            this.XVoteBitLbl.Size = new System.Drawing.Size(60, 15);
            this.XVoteBitLbl.TabIndex = 24;
            this.XVoteBitLbl.Text = "X Vote Bit:";
            // 
            // XVoteBitNud
            // 
            this.XVoteBitNud.Location = new System.Drawing.Point(12, 258);
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
            this.YVoteBitNud.Location = new System.Drawing.Point(12, 302);
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
            this.ZVoteBitNud.Location = new System.Drawing.Point(12, 348);
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
            this.LoadVoteBitsBtn.Location = new System.Drawing.Point(221, 243);
            this.LoadVoteBitsBtn.Name = "LoadVoteBitsBtn";
            this.LoadVoteBitsBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadVoteBitsBtn.TabIndex = 28;
            this.LoadVoteBitsBtn.Text = "Load Vote Bits";
            this.LoadVoteBitsBtn.UseVisualStyleBackColor = true;
            this.LoadVoteBitsBtn.Click += new System.EventHandler(this.LoadVoteBitsBtn_Click);
            // 
            // ZCurrentVoteBitTbx
            // 
            this.ZCurrentVoteBitTbx.Location = new System.Drawing.Point(360, 348);
            this.ZCurrentVoteBitTbx.Name = "ZCurrentVoteBitTbx";
            this.ZCurrentVoteBitTbx.ReadOnly = true;
            this.ZCurrentVoteBitTbx.Size = new System.Drawing.Size(56, 23);
            this.ZCurrentVoteBitTbx.TabIndex = 34;
            // 
            // ZCurrentVoteBit
            // 
            this.ZCurrentVoteBit.AutoSize = true;
            this.ZCurrentVoteBit.Location = new System.Drawing.Point(360, 330);
            this.ZCurrentVoteBit.Name = "ZCurrentVoteBit";
            this.ZCurrentVoteBit.Size = new System.Drawing.Size(103, 15);
            this.ZCurrentVoteBit.TabIndex = 33;
            this.ZCurrentVoteBit.Text = "Z Current Vote Bit:";
            // 
            // YCurrentVoteBitTbx
            // 
            this.YCurrentVoteBitTbx.Location = new System.Drawing.Point(360, 302);
            this.YCurrentVoteBitTbx.Name = "YCurrentVoteBitTbx";
            this.YCurrentVoteBitTbx.ReadOnly = true;
            this.YCurrentVoteBitTbx.Size = new System.Drawing.Size(56, 23);
            this.YCurrentVoteBitTbx.TabIndex = 32;
            // 
            // YCurrentVoteBitLbl
            // 
            this.YCurrentVoteBitLbl.AutoSize = true;
            this.YCurrentVoteBitLbl.Location = new System.Drawing.Point(360, 284);
            this.YCurrentVoteBitLbl.Name = "YCurrentVoteBitLbl";
            this.YCurrentVoteBitLbl.Size = new System.Drawing.Size(103, 15);
            this.YCurrentVoteBitLbl.TabIndex = 31;
            this.YCurrentVoteBitLbl.Text = "Y Current Vote Bit:";
            // 
            // XCurrentVoteBitTbx
            // 
            this.XCurrentVoteBitTbx.Location = new System.Drawing.Point(360, 258);
            this.XCurrentVoteBitTbx.Name = "XCurrentVoteBitTbx";
            this.XCurrentVoteBitTbx.ReadOnly = true;
            this.XCurrentVoteBitTbx.Size = new System.Drawing.Size(56, 23);
            this.XCurrentVoteBitTbx.TabIndex = 30;
            // 
            // XCurrentVoteBitLbl
            // 
            this.XCurrentVoteBitLbl.AutoSize = true;
            this.XCurrentVoteBitLbl.Location = new System.Drawing.Point(360, 240);
            this.XCurrentVoteBitLbl.Name = "XCurrentVoteBitLbl";
            this.XCurrentVoteBitLbl.Size = new System.Drawing.Size(103, 15);
            this.XCurrentVoteBitLbl.TabIndex = 29;
            this.XCurrentVoteBitLbl.Text = "X Current Vote Bit:";
            // 
            // ZStepBitsLbl
            // 
            this.ZStepBitsLbl.AutoSize = true;
            this.ZStepBitsLbl.Location = new System.Drawing.Point(12, 490);
            this.ZStepBitsLbl.Name = "ZStepBitsLbl";
            this.ZStepBitsLbl.Size = new System.Drawing.Size(65, 15);
            this.ZStepBitsLbl.TabIndex = 40;
            this.ZStepBitsLbl.Text = "Z Step Bits:";
            // 
            // ZStepBitsTbx
            // 
            this.ZStepBitsTbx.Location = new System.Drawing.Point(12, 508);
            this.ZStepBitsTbx.Name = "ZStepBitsTbx";
            this.ZStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.ZStepBitsTbx.TabIndex = 39;
            // 
            // YStepBitsLbl
            // 
            this.YStepBitsLbl.AutoSize = true;
            this.YStepBitsLbl.Location = new System.Drawing.Point(12, 435);
            this.YStepBitsLbl.Name = "YStepBitsLbl";
            this.YStepBitsLbl.Size = new System.Drawing.Size(65, 15);
            this.YStepBitsLbl.TabIndex = 38;
            this.YStepBitsLbl.Text = "Y Step Bits:";
            // 
            // YStepBitsTbx
            // 
            this.YStepBitsTbx.Location = new System.Drawing.Point(12, 453);
            this.YStepBitsTbx.Name = "YStepBitsTbx";
            this.YStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.YStepBitsTbx.TabIndex = 37;
            // 
            // XStepBitsLbl
            // 
            this.XStepBitsLbl.AutoSize = true;
            this.XStepBitsLbl.Location = new System.Drawing.Point(12, 379);
            this.XStepBitsLbl.Name = "XStepBitsLbl";
            this.XStepBitsLbl.Size = new System.Drawing.Size(65, 15);
            this.XStepBitsLbl.TabIndex = 36;
            this.XStepBitsLbl.Text = "X Step Bits:";
            // 
            // XStepBitsTbx
            // 
            this.XStepBitsTbx.Location = new System.Drawing.Point(12, 397);
            this.XStepBitsTbx.Name = "XStepBitsTbx";
            this.XStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.XStepBitsTbx.TabIndex = 35;
            // 
            // ZCurrentStepBitsLbl
            // 
            this.ZCurrentStepBitsLbl.AutoSize = true;
            this.ZCurrentStepBitsLbl.Location = new System.Drawing.Point(360, 490);
            this.ZCurrentStepBitsLbl.Name = "ZCurrentStepBitsLbl";
            this.ZCurrentStepBitsLbl.Size = new System.Drawing.Size(108, 15);
            this.ZCurrentStepBitsLbl.TabIndex = 46;
            this.ZCurrentStepBitsLbl.Text = "Z Current Step Bits:";
            // 
            // ZCurrentStepBitsTbx
            // 
            this.ZCurrentStepBitsTbx.Location = new System.Drawing.Point(360, 508);
            this.ZCurrentStepBitsTbx.Name = "ZCurrentStepBitsTbx";
            this.ZCurrentStepBitsTbx.ReadOnly = true;
            this.ZCurrentStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.ZCurrentStepBitsTbx.TabIndex = 45;
            // 
            // YCurrentStepBitsLbl
            // 
            this.YCurrentStepBitsLbl.AutoSize = true;
            this.YCurrentStepBitsLbl.Location = new System.Drawing.Point(360, 435);
            this.YCurrentStepBitsLbl.Name = "YCurrentStepBitsLbl";
            this.YCurrentStepBitsLbl.Size = new System.Drawing.Size(108, 15);
            this.YCurrentStepBitsLbl.TabIndex = 44;
            this.YCurrentStepBitsLbl.Text = "Y Current Step Bits:";
            // 
            // YCurrentStepBitsTbx
            // 
            this.YCurrentStepBitsTbx.Location = new System.Drawing.Point(360, 453);
            this.YCurrentStepBitsTbx.Name = "YCurrentStepBitsTbx";
            this.YCurrentStepBitsTbx.ReadOnly = true;
            this.YCurrentStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.YCurrentStepBitsTbx.TabIndex = 43;
            // 
            // XCurrentStepBitsLbl
            // 
            this.XCurrentStepBitsLbl.AutoSize = true;
            this.XCurrentStepBitsLbl.Location = new System.Drawing.Point(360, 379);
            this.XCurrentStepBitsLbl.Name = "XCurrentStepBitsLbl";
            this.XCurrentStepBitsLbl.Size = new System.Drawing.Size(108, 15);
            this.XCurrentStepBitsLbl.TabIndex = 42;
            this.XCurrentStepBitsLbl.Text = "X Current Step Bits:";
            // 
            // XCurrentStepBitsTbx
            // 
            this.XCurrentStepBitsTbx.Location = new System.Drawing.Point(360, 397);
            this.XCurrentStepBitsTbx.Name = "XCurrentStepBitsTbx";
            this.XCurrentStepBitsTbx.ReadOnly = true;
            this.XCurrentStepBitsTbx.Size = new System.Drawing.Size(104, 23);
            this.XCurrentStepBitsTbx.TabIndex = 41;
            // 
            // LoadStepBitsBtn
            // 
            this.LoadStepBitsBtn.Location = new System.Drawing.Point(221, 383);
            this.LoadStepBitsBtn.Name = "LoadStepBitsBtn";
            this.LoadStepBitsBtn.Size = new System.Drawing.Size(91, 48);
            this.LoadStepBitsBtn.TabIndex = 47;
            this.LoadStepBitsBtn.Text = "Load Step Bits";
            this.LoadStepBitsBtn.UseVisualStyleBackColor = true;
            this.LoadStepBitsBtn.Click += new System.EventHandler(this.LoadStepBitsBtn_Click);
            // 
            // InitializeCipherBtn
            // 
            this.InitializeCipherBtn.Location = new System.Drawing.Point(12, 700);
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
            this.ManualDecodeBtn.Location = new System.Drawing.Point(230, 700);
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
            this.SetWatchFolderBtn.Location = new System.Drawing.Point(479, 700);
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
            this.CurrentlyWatchingLbl.Location = new System.Drawing.Point(360, 546);
            this.CurrentlyWatchingLbl.Name = "CurrentlyWatchingLbl";
            this.CurrentlyWatchingLbl.Size = new System.Drawing.Size(113, 15);
            this.CurrentlyWatchingLbl.TabIndex = 51;
            this.CurrentlyWatchingLbl.Text = "Currently Watching:";
            // 
            // CurrentlyWatchingTbx
            // 
            this.CurrentlyWatchingTbx.Location = new System.Drawing.Point(360, 573);
            this.CurrentlyWatchingTbx.Name = "CurrentlyWatchingTbx";
            this.CurrentlyWatchingTbx.ReadOnly = true;
            this.CurrentlyWatchingTbx.Size = new System.Drawing.Size(302, 23);
            this.CurrentlyWatchingTbx.TabIndex = 52;
            // 
            // EnableDisableWatcherBtn
            // 
            this.EnableDisableWatcherBtn.Enabled = false;
            this.EnableDisableWatcherBtn.Location = new System.Drawing.Point(346, 700);
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
            this.ManualEncodeBtn.Location = new System.Drawing.Point(133, 700);
            this.ManualEncodeBtn.Name = "ManualEncodeBtn";
            this.ManualEncodeBtn.Size = new System.Drawing.Size(91, 48);
            this.ManualEncodeBtn.TabIndex = 54;
            this.ManualEncodeBtn.Text = "Manual Encode";
            this.ManualEncodeBtn.UseVisualStyleBackColor = true;
            this.ManualEncodeBtn.Click += new System.EventHandler(this.ManualEncodeBtn_Click);
            // 
            // SetOutputFolderBtn
            // 
            this.SetOutputFolderBtn.Location = new System.Drawing.Point(576, 700);
            this.SetOutputFolderBtn.Name = "SetOutputFolderBtn";
            this.SetOutputFolderBtn.Size = new System.Drawing.Size(91, 48);
            this.SetOutputFolderBtn.TabIndex = 55;
            this.SetOutputFolderBtn.Text = "Set Output Folder";
            this.SetOutputFolderBtn.UseVisualStyleBackColor = true;
            this.SetOutputFolderBtn.Click += new System.EventHandler(this.SetOutputFolderBtn_Click);
            // 
            // CurrentOutputFolderTbx
            // 
            this.CurrentOutputFolderTbx.Location = new System.Drawing.Point(360, 637);
            this.CurrentOutputFolderTbx.Name = "CurrentOutputFolderTbx";
            this.CurrentOutputFolderTbx.ReadOnly = true;
            this.CurrentOutputFolderTbx.Size = new System.Drawing.Size(302, 23);
            this.CurrentOutputFolderTbx.TabIndex = 57;
            // 
            // CurrentOutputFolderLbl
            // 
            this.CurrentOutputFolderLbl.AutoSize = true;
            this.CurrentOutputFolderLbl.Location = new System.Drawing.Point(360, 610);
            this.CurrentOutputFolderLbl.Name = "CurrentOutputFolderLbl";
            this.CurrentOutputFolderLbl.Size = new System.Drawing.Size(127, 15);
            this.CurrentOutputFolderLbl.TabIndex = 56;
            this.CurrentOutputFolderLbl.Text = "Current Output Folder:";
            // 
            // CipherStatusLbl
            // 
            this.CipherStatusLbl.AutoSize = true;
            this.CipherStatusLbl.Location = new System.Drawing.Point(12, 610);
            this.CipherStatusLbl.Name = "CipherStatusLbl";
            this.CipherStatusLbl.Size = new System.Drawing.Size(80, 15);
            this.CipherStatusLbl.TabIndex = 58;
            this.CipherStatusLbl.Text = "Cipher Status:";
            // 
            // CipherStatusTbx
            // 
            this.CipherStatusTbx.ForeColor = System.Drawing.Color.Red;
            this.CipherStatusTbx.Location = new System.Drawing.Point(12, 636);
            this.CipherStatusTbx.Name = "CipherStatusTbx";
            this.CipherStatusTbx.ReadOnly = true;
            this.CipherStatusTbx.Size = new System.Drawing.Size(100, 23);
            this.CipherStatusTbx.TabIndex = 59;
            this.CipherStatusTbx.Text = "Not Initialzied";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CipherMenuStripItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(674, 24);
            this.menuStrip.TabIndex = 60;
            this.menuStrip.Text = "menuStrip1";
            // 
            // CipherMenuStripItem
            // 
            this.CipherMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveCipherMenuStripItem,
            this.LoadCipherMenuStripItem});
            this.CipherMenuStripItem.Name = "CipherMenuStripItem";
            this.CipherMenuStripItem.Size = new System.Drawing.Size(54, 20);
            this.CipherMenuStripItem.Text = "Cipher";
            // 
            // SaveCipherMenuStripItem
            // 
            this.SaveCipherMenuStripItem.Enabled = false;
            this.SaveCipherMenuStripItem.Name = "SaveCipherMenuStripItem";
            this.SaveCipherMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.SaveCipherMenuStripItem.Text = "Save Cipher State";
            this.SaveCipherMenuStripItem.Click += new System.EventHandler(this.SaveCipherMenuStripItem_Click);
            // 
            // LoadCipherMenuStripItem
            // 
            this.LoadCipherMenuStripItem.Name = "LoadCipherMenuStripItem";
            this.LoadCipherMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.LoadCipherMenuStripItem.Text = "Load Cipher State";
            this.LoadCipherMenuStripItem.Click += new System.EventHandler(this.LoadCipherMenuStripItem_Click);
            // 
            // A51Cipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 760);
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
            this.Controls.Add(this.LoadStepBitsBtn);
            this.Controls.Add(this.ZCurrentStepBitsLbl);
            this.Controls.Add(this.ZCurrentStepBitsTbx);
            this.Controls.Add(this.YCurrentStepBitsLbl);
            this.Controls.Add(this.YCurrentStepBitsTbx);
            this.Controls.Add(this.XCurrentStepBitsLbl);
            this.Controls.Add(this.XCurrentStepBitsTbx);
            this.Controls.Add(this.ZStepBitsLbl);
            this.Controls.Add(this.ZStepBitsTbx);
            this.Controls.Add(this.YStepBitsLbl);
            this.Controls.Add(this.YStepBitsTbx);
            this.Controls.Add(this.XStepBitsLbl);
            this.Controls.Add(this.XStepBitsTbx);
            this.Controls.Add(this.ZCurrentVoteBitTbx);
            this.Controls.Add(this.ZCurrentVoteBit);
            this.Controls.Add(this.YCurrentVoteBitTbx);
            this.Controls.Add(this.YCurrentVoteBitLbl);
            this.Controls.Add(this.XCurrentVoteBitTbx);
            this.Controls.Add(this.XCurrentVoteBitLbl);
            this.Controls.Add(this.LoadVoteBitsBtn);
            this.Controls.Add(this.ZVoteBitNud);
            this.Controls.Add(this.YVoteBitNud);
            this.Controls.Add(this.XVoteBitNud);
            this.Controls.Add(this.XVoteBitLbl);
            this.Controls.Add(this.YVoteBitLbl);
            this.Controls.Add(this.ZVoteBitLbl);
            this.Controls.Add(this.LoadRegisterSeedsBtn);
            this.Controls.Add(this.LoadGlobalSeedBtn);
            this.Controls.Add(this.ZCurrentSeedTbx);
            this.Controls.Add(this.ZCurrentSeedLbl);
            this.Controls.Add(this.ZSeedLbl);
            this.Controls.Add(this.inputZSeedTbx);
            this.Controls.Add(this.YCurrentSeedTbx);
            this.Controls.Add(this.YCurrentSeedLbl);
            this.Controls.Add(this.YSeedLbl);
            this.Controls.Add(this.inputYSeedTbx);
            this.Controls.Add(this.XCurrentSeedTbx);
            this.Controls.Add(this.XCurrentSeedLbl);
            this.Controls.Add(this.XSeedLbl);
            this.Controls.Add(this.inputXSeedTbx);
            this.Controls.Add(this.currentSeedTbx);
            this.Controls.Add(this.currentSeedLbl);
            this.Controls.Add(this.seedLbl);
            this.Controls.Add(this.inputSeedTbx);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "A51Cipher";
            this.Text = "A51 Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.XVoteBitNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVoteBitNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVoteBitNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSeedTbx;
        private System.Windows.Forms.Label seedLbl;
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
        private System.Windows.Forms.ToolStripMenuItem CipherMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem SaveCipherMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem LoadCipherMenuStripItem;
    }
}

