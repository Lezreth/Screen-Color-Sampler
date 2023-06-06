namespace Screen_Color_Sampler
{
    partial class FrmViewer
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
            TableMain = new TableLayoutPanel();
            GrpColor = new GroupBox();
            PanelColor = new Panel();
            BtnCopyHexToClipboard = new Button();
            BtnToggleSampling = new Button();
            LblHexCode = new Label();
            LblHexCodeLabel = new Label();
            LblR = new Label();
            LblG = new Label();
            LblB = new Label();
            LblRLabel = new Label();
            LblGLabel = new Label();
            LblBLabel = new Label();
            TableMain.SuspendLayout();
            GrpColor.SuspendLayout();
            SuspendLayout();
            // 
            // TableMain
            // 
            TableMain.ColumnCount = 3;
            TableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            TableMain.ColumnStyles.Add(new ColumnStyle());
            TableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableMain.Controls.Add(GrpColor, 0, 0);
            TableMain.Controls.Add(BtnCopyHexToClipboard, 1, 6);
            TableMain.Controls.Add(BtnToggleSampling, 1, 5);
            TableMain.Controls.Add(LblHexCode, 2, 4);
            TableMain.Controls.Add(LblHexCodeLabel, 1, 4);
            TableMain.Controls.Add(LblR, 2, 1);
            TableMain.Controls.Add(LblG, 2, 2);
            TableMain.Controls.Add(LblB, 2, 3);
            TableMain.Controls.Add(LblRLabel, 1, 1);
            TableMain.Controls.Add(LblGLabel, 1, 2);
            TableMain.Controls.Add(LblBLabel, 1, 3);
            TableMain.Dock = DockStyle.Fill;
            TableMain.Location = new Point(0, 0);
            TableMain.Name = "TableMain";
            TableMain.RowCount = 7;
            TableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableMain.RowStyles.Add(new RowStyle());
            TableMain.RowStyles.Add(new RowStyle());
            TableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TableMain.RowStyles.Add(new RowStyle());
            TableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableMain.Size = new Size(484, 261);
            TableMain.TabIndex = 0;
            // 
            // GrpColor
            // 
            GrpColor.Controls.Add(PanelColor);
            GrpColor.Dock = DockStyle.Fill;
            GrpColor.Location = new Point(3, 3);
            GrpColor.Name = "GrpColor";
            TableMain.SetRowSpan(GrpColor, 7);
            GrpColor.Size = new Size(294, 255);
            GrpColor.TabIndex = 4;
            GrpColor.TabStop = false;
            GrpColor.Text = "Color";
            // 
            // PanelColor
            // 
            PanelColor.Dock = DockStyle.Fill;
            PanelColor.Location = new Point(3, 19);
            PanelColor.Name = "PanelColor";
            PanelColor.Size = new Size(288, 233);
            PanelColor.TabIndex = 0;
            // 
            // BtnCopyHexToClipboard
            // 
            BtnCopyHexToClipboard.AutoSize = true;
            BtnCopyHexToClipboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableMain.SetColumnSpan(BtnCopyHexToClipboard, 2);
            BtnCopyHexToClipboard.FlatStyle = FlatStyle.Popup;
            BtnCopyHexToClipboard.Location = new Point(303, 154);
            BtnCopyHexToClipboard.Name = "BtnCopyHexToClipboard";
            BtnCopyHexToClipboard.Size = new Size(170, 25);
            BtnCopyHexToClipboard.TabIndex = 1;
            BtnCopyHexToClipboard.Text = "Copy Hex Code To Clipboard";
            BtnCopyHexToClipboard.UseVisualStyleBackColor = true;
            BtnCopyHexToClipboard.Click += BtnCopyHexToClipboard_Click;
            // 
            // BtnToggleSampling
            // 
            BtnToggleSampling.AutoSize = true;
            BtnToggleSampling.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableMain.SetColumnSpan(BtnToggleSampling, 2);
            BtnToggleSampling.FlatStyle = FlatStyle.Popup;
            BtnToggleSampling.Location = new Point(303, 123);
            BtnToggleSampling.Name = "BtnToggleSampling";
            BtnToggleSampling.Size = new Size(132, 25);
            BtnToggleSampling.TabIndex = 0;
            BtnToggleSampling.Text = "Start Sampling (Enter)";
            BtnToggleSampling.UseVisualStyleBackColor = true;
            BtnToggleSampling.Click += BtnToggleSampling_Click;
            // 
            // LblHexCode
            // 
            LblHexCode.AutoSize = true;
            LblHexCode.Location = new Point(350, 80);
            LblHexCode.Name = "LblHexCode";
            LblHexCode.Size = new Size(56, 15);
            LblHexCode.TabIndex = 6;
            LblHexCode.Text = "#A0A0A0";
            // 
            // LblHexCodeLabel
            // 
            LblHexCodeLabel.AutoSize = true;
            LblHexCodeLabel.Location = new Point(303, 80);
            LblHexCodeLabel.Name = "LblHexCodeLabel";
            LblHexCodeLabel.Size = new Size(31, 15);
            LblHexCodeLabel.TabIndex = 7;
            LblHexCodeLabel.Text = "Hex:";
            // 
            // LblR
            // 
            LblR.AutoSize = true;
            LblR.Location = new Point(350, 20);
            LblR.Name = "LblR";
            LblR.Size = new Size(25, 15);
            LblR.TabIndex = 1;
            LblR.Text = "160";
            // 
            // LblG
            // 
            LblG.AutoSize = true;
            LblG.Location = new Point(350, 35);
            LblG.Name = "LblG";
            LblG.Size = new Size(25, 15);
            LblG.TabIndex = 2;
            LblG.Text = "160";
            // 
            // LblB
            // 
            LblB.AutoSize = true;
            LblB.Location = new Point(350, 50);
            LblB.Name = "LblB";
            LblB.Size = new Size(25, 15);
            LblB.TabIndex = 3;
            LblB.Text = "160";
            // 
            // LblRLabel
            // 
            LblRLabel.AutoSize = true;
            LblRLabel.Location = new Point(303, 20);
            LblRLabel.Name = "LblRLabel";
            LblRLabel.Size = new Size(30, 15);
            LblRLabel.TabIndex = 8;
            LblRLabel.Text = "Red:";
            // 
            // LblGLabel
            // 
            LblGLabel.AutoSize = true;
            LblGLabel.Location = new Point(303, 35);
            LblGLabel.Name = "LblGLabel";
            LblGLabel.Size = new Size(41, 15);
            LblGLabel.TabIndex = 9;
            LblGLabel.Text = "Green:";
            // 
            // LblBLabel
            // 
            LblBLabel.AutoSize = true;
            LblBLabel.Location = new Point(303, 50);
            LblBLabel.Name = "LblBLabel";
            LblBLabel.Size = new Size(33, 15);
            LblBLabel.TabIndex = 10;
            LblBLabel.Text = "Blue:";
            // 
            // FrmViewer
            // 
            AcceptButton = BtnToggleSampling;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(484, 261);
            Controls.Add(TableMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Color Sampler";
            TableMain.ResumeLayout(false);
            TableMain.PerformLayout();
            GrpColor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableMain;
        private Label LblR;
        private Label LblG;
        private Label LblB;
        private GroupBox GrpColor;
        private Button BtnCopyHexToClipboard;
        private Label LblHexCode;
        private Button BtnToggleSampling;
        private Panel PanelColor;
        private Label LblHexCodeLabel;
        private Label LblRLabel;
        private Label LblGLabel;
        private Label LblBLabel;
    }
}