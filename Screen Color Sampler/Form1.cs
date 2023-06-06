namespace Screen_Color_Sampler
{
    public partial class FrmViewer : Form
    {
        #region Parameters

        /// <summary>
        /// Thread for getting pixel samples.
        /// </summary>
        Thread samplerThread;

        /// <summary>
        /// Delegate for relaying pixel colors to the main thread for info display.
        /// </summary>
        /// <param name="color"></param>
        private delegate void SetValuesDelegate(Color color);

        /// <summary>
        /// Toggle for tracking active sampling state.
        /// </summary>
        private bool Sampling = false;

        /// <summary>
        /// Picks the colors.
        /// </summary>
        private readonly ColorPicker colorPicker = new();

        #endregion
        //===G
        #region Form Events

        public FrmViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Toggle active sampling mode.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">Not used.</param>
        private void BtnToggleSampling_Click(object sender, EventArgs e)
        {
            if (Sampling)
            {
                Sampling = false;
                BtnToggleSampling.Text = "Start Sampling (Enter)";
            }
            else
            {
                Sampling = true;
                BtnToggleSampling.Text = "Stop Sampling (Enter)";

                StartSampler();
            }
        }

        /// <summary>
        /// Copy the hex code of the selected color to the clipboard.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">Not used.</param>
        private void BtnCopyHexToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LblHexCode.Text);
            _ = MessageBox.Show(LblHexCode.Text + " copied to clipboard.");

        }

        #endregion
        //---G
        #region Support Methods

        /// <summary>
        /// Runs the color sampler thread.
        /// </summary>
        private void StartSampler()
        {
            if (!Sampling) { return; }

            samplerThread = new(SamplePixels);
            samplerThread.Start();
        }

        /// <summary>
        /// Samples the color under the cursor and sends the value to the main thread for display.
        /// </summary>
        private void SamplePixels()
        {
            while (Sampling)
            {
                Color color = colorPicker.TimerTick();
                SetValues(color);

                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Displays the provided color and information about it.
        /// </summary>
        /// <param name="color">Color to display.</param>
        private void SetValues(Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new SetValuesDelegate(SetValues), color);
            }

            PanelColor.BackColor = color;

            LblR.Text = color.R.ToString();
            LblG.Text = color.G.ToString();
            LblB.Text = color.B.ToString();

            LblHexCode.Text = "#"
                + color.R.ToString("X2")
                + color.G.ToString("X2")
                + color.B.ToString("X2");
        }

        #endregion
    }
}