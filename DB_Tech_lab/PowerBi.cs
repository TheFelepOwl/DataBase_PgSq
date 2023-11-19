using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace DB_Tech_lab
{
    public partial class PowerBi : Form
    {
        private ChromiumWebBrowser chromeBrowser;

        public PowerBi()
        {
            InitializeComponent();
            InitializeCef();
            InitializeChromiumWebBrowser();
        }

        private void InitializeCef()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
        }

        private void InitializeChromiumWebBrowser()
        {
            chromeBrowser = new ChromiumWebBrowser
            {
                Dock = DockStyle.Fill
            };

            // Subscribe to the IsBrowserInitializedChanged event
            chromeBrowser.IsBrowserInitializedChanged += ChromeBrowser_IsBrowserInitializedChanged;

            this.Controls.Add(chromeBrowser);
        }

        private void ChromeBrowser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            // Check if the browser is initialized
            if (chromeBrowser.IsBrowserInitialized)
            {
                // Browser is initialized, you can now perform operations on it
                LoadPowerBiReport();
            }
        }

        private void PowerBi_Load(object sender, EventArgs e)
        {
            // Initialization logic, no need to call LoadPowerBiReport() here
        }

        private void LoadPowerBiReport()
        {
            // Load a web page (e.g., a Power BI report URL)
            chromeBrowser.Load("https://app.powerbi.com/view?r=eyJrIjoiNDBkMDI5NzktM2YyZi00NTA2LTgzOTUtMTgxOWQwZTEwYzNlIiwidCI6ImQ2NTk5ZjY4LTJkMmMtNGNhZS05ZWNmLTYwMDUyYjdkMGJkOSIsImMiOjl9");
        }

        private void PowerBIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }


    }
}
