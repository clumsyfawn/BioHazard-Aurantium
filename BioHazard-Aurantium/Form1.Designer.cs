namespace BioHazard_Aurantium
{
    partial class thegame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thegame));
            this.Play_Button = new System.Windows.Forms.Button();
            this.Instructions_Button = new System.Windows.Forms.Button();
            this.Options_Button = new System.Windows.Forms.Button();
            this.optionspanel = new System.Windows.Forms.Panel();
            this.volumepercentage = new System.Windows.Forms.Button();
            this.volumebutton100 = new System.Windows.Forms.Button();
            this.volumebutton75 = new System.Windows.Forms.Button();
            this.volumebutton50 = new System.Windows.Forms.Button();
            this.volumebutton25 = new System.Windows.Forms.Button();
            this.Back_Button_Options = new System.Windows.Forms.Button();
            this.Mute_Button = new System.Windows.Forms.Button();
            this.Volume_Percentage = new System.Windows.Forms.PictureBox();
            this.Volume_Picturebox = new System.Windows.Forms.PictureBox();
            this.instructionspanel = new System.Windows.Forms.Panel();
            this.Back_Button_Instructions = new System.Windows.Forms.Button();
            this.Instructions_Controls = new System.Windows.Forms.PictureBox();
            this.MainMenuMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.talentspanel = new System.Windows.Forms.Panel();
            this.TalentsExit_Button = new System.Windows.Forms.Button();
            this.TalentsBackground = new System.Windows.Forms.PictureBox();
            this.MainMenuRain = new AxWMPLib.AxWindowsMediaPlayer();
            this.MainMenuButtons = new AxWMPLib.AxWindowsMediaPlayer();
            this.gameloop = new System.Windows.Forms.Timer(this.components);
            this.MainMenuBackButtons = new AxWMPLib.AxWindowsMediaPlayer();
            this.angletest = new System.Windows.Forms.Label();
            this.healthtext = new System.Windows.Forms.Label();
            this.optionspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Percentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Picturebox)).BeginInit();
            this.instructionspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instructions_Controls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuMusic)).BeginInit();
            this.talentspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TalentsBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBackButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.Transparent;
            this.Play_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play_Button.BackgroundImage")));
            this.Play_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Play_Button.FlatAppearance.BorderSize = 0;
            this.Play_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Play_Button.Location = new System.Drawing.Point(579, 407);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(232, 63);
            this.Play_Button.TabIndex = 0;
            this.Play_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Play_Button.UseVisualStyleBackColor = false;
            this.Play_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Play_Button_MouseClick);
            this.Play_Button.MouseEnter += new System.EventHandler(this.Play_Button_MouseEnter);
            this.Play_Button.MouseLeave += new System.EventHandler(this.Play_Button_MouseLeave);
            // 
            // Instructions_Button
            // 
            this.Instructions_Button.BackColor = System.Drawing.Color.Transparent;
            this.Instructions_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Instructions_Button.BackgroundImage")));
            this.Instructions_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Instructions_Button.FlatAppearance.BorderSize = 0;
            this.Instructions_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Instructions_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Instructions_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Instructions_Button.Location = new System.Drawing.Point(506, 501);
            this.Instructions_Button.Name = "Instructions_Button";
            this.Instructions_Button.Size = new System.Drawing.Size(402, 75);
            this.Instructions_Button.TabIndex = 1;
            this.Instructions_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Instructions_Button.UseVisualStyleBackColor = false;
            this.Instructions_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Instructions_Button_MouseClick);
            this.Instructions_Button.MouseEnter += new System.EventHandler(this.Instructions_Button_MouseEnter);
            this.Instructions_Button.MouseLeave += new System.EventHandler(this.Instructions_Button_MouseLeave);
            // 
            // Options_Button
            // 
            this.Options_Button.BackColor = System.Drawing.Color.Transparent;
            this.Options_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Options_Button.BackgroundImage")));
            this.Options_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Options_Button.FlatAppearance.BorderSize = 0;
            this.Options_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Options_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Options_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options_Button.Location = new System.Drawing.Point(547, 618);
            this.Options_Button.Name = "Options_Button";
            this.Options_Button.Size = new System.Drawing.Size(290, 101);
            this.Options_Button.TabIndex = 2;
            this.Options_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Options_Button.UseVisualStyleBackColor = false;
            this.Options_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Options_Button_MouseClick);
            this.Options_Button.MouseEnter += new System.EventHandler(this.Options_Button_MouseEnter);
            this.Options_Button.MouseLeave += new System.EventHandler(this.Options_Button_MouseLeave);
            // 
            // optionspanel
            // 
            this.optionspanel.BackColor = System.Drawing.Color.Transparent;
            this.optionspanel.Controls.Add(this.volumepercentage);
            this.optionspanel.Controls.Add(this.volumebutton100);
            this.optionspanel.Controls.Add(this.volumebutton75);
            this.optionspanel.Controls.Add(this.volumebutton50);
            this.optionspanel.Controls.Add(this.volumebutton25);
            this.optionspanel.Controls.Add(this.Back_Button_Options);
            this.optionspanel.Controls.Add(this.Mute_Button);
            this.optionspanel.Controls.Add(this.Volume_Percentage);
            this.optionspanel.Controls.Add(this.Volume_Picturebox);
            this.optionspanel.Location = new System.Drawing.Point(506, 307);
            this.optionspanel.Name = "optionspanel";
            this.optionspanel.Size = new System.Drawing.Size(391, 446);
            this.optionspanel.TabIndex = 3;
            this.optionspanel.Visible = false;
            // 
            // volumepercentage
            // 
            this.volumepercentage.BackColor = System.Drawing.Color.Black;
            this.volumepercentage.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.volume100;
            this.volumepercentage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumepercentage.Enabled = false;
            this.volumepercentage.FlatAppearance.BorderSize = 0;
            this.volumepercentage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volumepercentage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volumepercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumepercentage.Location = new System.Drawing.Point(102, 187);
            this.volumepercentage.Name = "volumepercentage";
            this.volumepercentage.Size = new System.Drawing.Size(75, 32);
            this.volumepercentage.TabIndex = 8;
            this.volumepercentage.UseVisualStyleBackColor = false;
            // 
            // volumebutton100
            // 
            this.volumebutton100.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Volume_Button100;
            this.volumebutton100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volumebutton100.FlatAppearance.BorderSize = 0;
            this.volumebutton100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volumebutton100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volumebutton100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumebutton100.Location = new System.Drawing.Point(183, 242);
            this.volumebutton100.Name = "volumebutton100";
            this.volumebutton100.Size = new System.Drawing.Size(45, 40);
            this.volumebutton100.TabIndex = 7;
            this.volumebutton100.UseVisualStyleBackColor = true;
            this.volumebutton100.MouseClick += new System.Windows.Forms.MouseEventHandler(this.volumebutton100_MouseClick);
            this.volumebutton100.MouseEnter += new System.EventHandler(this.volumebutton100_MouseEnter);
            this.volumebutton100.MouseLeave += new System.EventHandler(this.volumebutton100_MouseLeave);
            // 
            // volumebutton75
            // 
            this.volumebutton75.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Volume_Button75;
            this.volumebutton75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volumebutton75.FlatAppearance.BorderSize = 0;
            this.volumebutton75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volumebutton75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volumebutton75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumebutton75.Location = new System.Drawing.Point(132, 242);
            this.volumebutton75.Name = "volumebutton75";
            this.volumebutton75.Size = new System.Drawing.Size(45, 40);
            this.volumebutton75.TabIndex = 6;
            this.volumebutton75.UseVisualStyleBackColor = true;
            this.volumebutton75.MouseClick += new System.Windows.Forms.MouseEventHandler(this.volumebutton75_MouseClick);
            this.volumebutton75.MouseEnter += new System.EventHandler(this.volumebutton75_MouseEnter);
            this.volumebutton75.MouseLeave += new System.EventHandler(this.volumebutton75_MouseLeave);
            // 
            // volumebutton50
            // 
            this.volumebutton50.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Volume_Button50;
            this.volumebutton50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volumebutton50.FlatAppearance.BorderSize = 0;
            this.volumebutton50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volumebutton50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volumebutton50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumebutton50.Location = new System.Drawing.Point(81, 242);
            this.volumebutton50.Name = "volumebutton50";
            this.volumebutton50.Size = new System.Drawing.Size(45, 40);
            this.volumebutton50.TabIndex = 5;
            this.volumebutton50.UseVisualStyleBackColor = true;
            this.volumebutton50.MouseClick += new System.Windows.Forms.MouseEventHandler(this.volumebutton50_MouseClick);
            this.volumebutton50.MouseEnter += new System.EventHandler(this.volumebutton50_MouseEnter);
            this.volumebutton50.MouseLeave += new System.EventHandler(this.volumebutton50_MouseLeave);
            // 
            // volumebutton25
            // 
            this.volumebutton25.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Volume_Button25;
            this.volumebutton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volumebutton25.FlatAppearance.BorderSize = 0;
            this.volumebutton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volumebutton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volumebutton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumebutton25.Location = new System.Drawing.Point(30, 242);
            this.volumebutton25.Name = "volumebutton25";
            this.volumebutton25.Size = new System.Drawing.Size(45, 40);
            this.volumebutton25.TabIndex = 4;
            this.volumebutton25.UseVisualStyleBackColor = true;
            this.volumebutton25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.volumebutton25_MouseClick);
            this.volumebutton25.MouseEnter += new System.EventHandler(this.volumebutton25_MouseEnter);
            this.volumebutton25.MouseLeave += new System.EventHandler(this.volumebutton25_MouseLeave);
            // 
            // Back_Button_Options
            // 
            this.Back_Button_Options.BackColor = System.Drawing.Color.Transparent;
            this.Back_Button_Options.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Back_Button;
            this.Back_Button_Options.FlatAppearance.BorderSize = 0;
            this.Back_Button_Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back_Button_Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back_Button_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button_Options.Location = new System.Drawing.Point(60, 344);
            this.Back_Button_Options.Name = "Back_Button_Options";
            this.Back_Button_Options.Size = new System.Drawing.Size(245, 102);
            this.Back_Button_Options.TabIndex = 3;
            this.Back_Button_Options.UseVisualStyleBackColor = false;
            this.Back_Button_Options.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Back_Button_MouseClick);
            this.Back_Button_Options.MouseEnter += new System.EventHandler(this.Back_Button_Options_MouseEnter);
            this.Back_Button_Options.MouseLeave += new System.EventHandler(this.Back_Button_Options_MouseLeave);
            // 
            // Mute_Button
            // 
            this.Mute_Button.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Mute;
            this.Mute_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mute_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mute_Button.FlatAppearance.BorderSize = 0;
            this.Mute_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Mute_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Mute_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mute_Button.Location = new System.Drawing.Point(231, 169);
            this.Mute_Button.Name = "Mute_Button";
            this.Mute_Button.Size = new System.Drawing.Size(109, 58);
            this.Mute_Button.TabIndex = 2;
            this.Mute_Button.UseVisualStyleBackColor = true;
            this.Mute_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mute_Button_MouseClick);
            // 
            // Volume_Percentage
            // 
            this.Volume_Percentage.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Volume_Background;
            this.Volume_Percentage.Location = new System.Drawing.Point(0, 148);
            this.Volume_Percentage.Name = "Volume_Percentage";
            this.Volume_Percentage.Size = new System.Drawing.Size(235, 88);
            this.Volume_Percentage.TabIndex = 1;
            this.Volume_Percentage.TabStop = false;
            // 
            // Volume_Picturebox
            // 
            this.Volume_Picturebox.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Volume;
            this.Volume_Picturebox.Location = new System.Drawing.Point(30, 3);
            this.Volume_Picturebox.Name = "Volume_Picturebox";
            this.Volume_Picturebox.Size = new System.Drawing.Size(301, 109);
            this.Volume_Picturebox.TabIndex = 0;
            this.Volume_Picturebox.TabStop = false;
            // 
            // instructionspanel
            // 
            this.instructionspanel.BackColor = System.Drawing.Color.Transparent;
            this.instructionspanel.Controls.Add(this.Back_Button_Instructions);
            this.instructionspanel.Controls.Add(this.Instructions_Controls);
            this.instructionspanel.Location = new System.Drawing.Point(273, 307);
            this.instructionspanel.Name = "instructionspanel";
            this.instructionspanel.Size = new System.Drawing.Size(844, 443);
            this.instructionspanel.TabIndex = 4;
            this.instructionspanel.Visible = false;
            // 
            // Back_Button_Instructions
            // 
            this.Back_Button_Instructions.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Back_Button;
            this.Back_Button_Instructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Button_Instructions.FlatAppearance.BorderSize = 0;
            this.Back_Button_Instructions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back_Button_Instructions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back_Button_Instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button_Instructions.Location = new System.Drawing.Point(365, 400);
            this.Back_Button_Instructions.Name = "Back_Button_Instructions";
            this.Back_Button_Instructions.Size = new System.Drawing.Size(115, 46);
            this.Back_Button_Instructions.TabIndex = 1;
            this.Back_Button_Instructions.UseVisualStyleBackColor = true;
            this.Back_Button_Instructions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Back_Button_Instructions_MouseClick);
            this.Back_Button_Instructions.MouseEnter += new System.EventHandler(this.Back_Button_Instructions_MouseEnter);
            this.Back_Button_Instructions.MouseLeave += new System.EventHandler(this.Back_Button_Instructions_MouseLeave);
            // 
            // Instructions_Controls
            // 
            this.Instructions_Controls.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.KeyboardandMouse;
            this.Instructions_Controls.Location = new System.Drawing.Point(186, 0);
            this.Instructions_Controls.Name = "Instructions_Controls";
            this.Instructions_Controls.Size = new System.Drawing.Size(435, 412);
            this.Instructions_Controls.TabIndex = 0;
            this.Instructions_Controls.TabStop = false;
            // 
            // MainMenuMusic
            // 
            this.MainMenuMusic.Enabled = true;
            this.MainMenuMusic.Location = new System.Drawing.Point(0, 0);
            this.MainMenuMusic.Name = "MainMenuMusic";
            this.MainMenuMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainMenuMusic.OcxState")));
            this.MainMenuMusic.Size = new System.Drawing.Size(0, 0);
            this.MainMenuMusic.TabIndex = 5;
            this.MainMenuMusic.Visible = false;
            // 
            // talentspanel
            // 
            this.talentspanel.BackColor = System.Drawing.Color.Transparent;
            this.talentspanel.Controls.Add(this.TalentsExit_Button);
            this.talentspanel.Controls.Add(this.TalentsBackground);
            this.talentspanel.Location = new System.Drawing.Point(357, 147);
            this.talentspanel.Name = "talentspanel";
            this.talentspanel.Size = new System.Drawing.Size(600, 600);
            this.talentspanel.TabIndex = 6;
            this.talentspanel.Visible = false;
            // 
            // TalentsExit_Button
            // 
            this.TalentsExit_Button.BackColor = System.Drawing.Color.Transparent;
            this.TalentsExit_Button.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.TalentsExit;
            this.TalentsExit_Button.FlatAppearance.BorderSize = 0;
            this.TalentsExit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TalentsExit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TalentsExit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TalentsExit_Button.ForeColor = System.Drawing.Color.Transparent;
            this.TalentsExit_Button.Location = new System.Drawing.Point(534, 205);
            this.TalentsExit_Button.Name = "TalentsExit_Button";
            this.TalentsExit_Button.Size = new System.Drawing.Size(32, 22);
            this.TalentsExit_Button.TabIndex = 1;
            this.TalentsExit_Button.UseVisualStyleBackColor = false;
            this.TalentsExit_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TalentsExit_Button_MouseClick);
            // 
            // TalentsBackground
            // 
            this.TalentsBackground.BackgroundImage = global::BioHazard_Aurantium.Properties.Resources.Talents;
            this.TalentsBackground.Location = new System.Drawing.Point(3, 163);
            this.TalentsBackground.Name = "TalentsBackground";
            this.TalentsBackground.Size = new System.Drawing.Size(585, 434);
            this.TalentsBackground.TabIndex = 0;
            this.TalentsBackground.TabStop = false;
            // 
            // MainMenuRain
            // 
            this.MainMenuRain.Enabled = true;
            this.MainMenuRain.Location = new System.Drawing.Point(0, 0);
            this.MainMenuRain.Name = "MainMenuRain";
            this.MainMenuRain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainMenuRain.OcxState")));
            this.MainMenuRain.Size = new System.Drawing.Size(0, 0);
            this.MainMenuRain.TabIndex = 7;
            this.MainMenuRain.Visible = false;
            // 
            // MainMenuButtons
            // 
            this.MainMenuButtons.Enabled = true;
            this.MainMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.MainMenuButtons.Name = "MainMenuButtons";
            this.MainMenuButtons.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainMenuButtons.OcxState")));
            this.MainMenuButtons.Size = new System.Drawing.Size(0, 0);
            this.MainMenuButtons.TabIndex = 8;
            this.MainMenuButtons.Visible = false;
            // 
            // gameloop
            // 
            this.gameloop.Interval = 33;
            this.gameloop.Tick += new System.EventHandler(this.gameloop_Tick);
            // 
            // MainMenuBackButtons
            // 
            this.MainMenuBackButtons.Enabled = true;
            this.MainMenuBackButtons.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBackButtons.Name = "MainMenuBackButtons";
            this.MainMenuBackButtons.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainMenuBackButtons.OcxState")));
            this.MainMenuBackButtons.Size = new System.Drawing.Size(0, 0);
            this.MainMenuBackButtons.TabIndex = 9;
            this.MainMenuBackButtons.Visible = false;
            // 
            // angletest
            // 
            this.angletest.AutoSize = true;
            this.angletest.Location = new System.Drawing.Point(1167, 13);
            this.angletest.Name = "angletest";
            this.angletest.Size = new System.Drawing.Size(0, 13);
            this.angletest.TabIndex = 10;
            // 
            // healthtext
            // 
            this.healthtext.AutoSize = true;
            this.healthtext.BackColor = System.Drawing.Color.Transparent;
            this.healthtext.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthtext.ForeColor = System.Drawing.Color.DarkOrange;
            this.healthtext.Location = new System.Drawing.Point(159, 944);
            this.healthtext.Name = "healthtext";
            this.healthtext.Size = new System.Drawing.Size(0, 25);
            this.healthtext.TabIndex = 11;
            // 
            // thegame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1274, 1000);
            this.Controls.Add(this.healthtext);
            this.Controls.Add(this.angletest);
            this.Controls.Add(this.MainMenuBackButtons);
            this.Controls.Add(this.MainMenuButtons);
            this.Controls.Add(this.MainMenuRain);
            this.Controls.Add(this.talentspanel);
            this.Controls.Add(this.MainMenuMusic);
            this.Controls.Add(this.instructionspanel);
            this.Controls.Add(this.optionspanel);
            this.Controls.Add(this.Options_Button);
            this.Controls.Add(this.Instructions_Button);
            this.Controls.Add(this.Play_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "thegame";
            this.Text = "BioHazard: Aurantium";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.thegame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.thegame_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.thegame_MouseMove);
            this.optionspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Percentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Picturebox)).EndInit();
            this.instructionspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Instructions_Controls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuMusic)).EndInit();
            this.talentspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TalentsBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBackButtons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Button Instructions_Button;
        private System.Windows.Forms.Button Options_Button;
        private System.Windows.Forms.Panel optionspanel;
        private System.Windows.Forms.Button Mute_Button;
        private System.Windows.Forms.PictureBox Volume_Percentage;
        private System.Windows.Forms.PictureBox Volume_Picturebox;
        private System.Windows.Forms.Button Back_Button_Options;
        private System.Windows.Forms.Button volumebutton25;
        private System.Windows.Forms.Button volumebutton100;
        private System.Windows.Forms.Button volumebutton75;
        private System.Windows.Forms.Button volumebutton50;
        private System.Windows.Forms.Button volumepercentage;
        private System.Windows.Forms.Panel instructionspanel;
        private System.Windows.Forms.PictureBox Instructions_Controls;
        private System.Windows.Forms.Button Back_Button_Instructions;
        private AxWMPLib.AxWindowsMediaPlayer MainMenuMusic;
        private System.Windows.Forms.Panel talentspanel;
        private System.Windows.Forms.PictureBox TalentsBackground;
        private System.Windows.Forms.Button TalentsExit_Button;
        private AxWMPLib.AxWindowsMediaPlayer MainMenuRain;
        public AxWMPLib.AxWindowsMediaPlayer MainMenuButtons;
        private System.Windows.Forms.Timer gameloop;
        public AxWMPLib.AxWindowsMediaPlayer MainMenuBackButtons;
        private System.Windows.Forms.Label angletest;
        private System.Windows.Forms.Label healthtext;
    }
}

