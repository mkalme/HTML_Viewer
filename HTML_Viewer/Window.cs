using System;
using System.Windows.Forms;
using System.IO;

namespace HTML_Viewer {
    public partial class Window : Form {
        private readonly string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\htmlTest.html";
        
        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebBrowser.DocumentText = File.ReadAllText(FilePath);
        }
    }
}
