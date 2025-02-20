using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace PowerpointExporter
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private string imageFilePrefix = "Slide";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();

            var workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            openFileDialog.InitialDirectory = workingDirectory;
            openFileDialog.Filter = "(*.ppt)|*.pptx";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            label2.Text = filePath;
            label4.Text = workingDirectory;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ApplicationClass pptApplication = new();
            Presentation pptPresentation = pptApplication.Presentations.Open(filePath, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);

            for (int i = 1; i <= pptPresentation.Slides.Count; i++)
            {
                pptPresentation.Slides[i].Export($"{imageFilePrefix}-{i}.png", "png", 1920, 1080);
            }

            Form1.ActiveForm?.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            imageFilePrefix = textBox1.Text;
        }
    }
}
