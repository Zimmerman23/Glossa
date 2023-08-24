using ProjectClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class Main : Form
    {
        Library library;
        BinaryFormatter formatter;
        public Main()
        {
            library = new Library();
            formatter = new BinaryFormatter();
            using (var file = new FileStream("English-Russian.bin", FileMode.OpenOrCreate))
            {
                if (file.Length > 0)
                {
                    library.SetVocabulary(formatter.Deserialize(file) as Dictionary<string, string>);
                }
            }
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            startForm.ShowDialog();
        }

        private void AddWordAndTranslateButton_Click(object sender, EventArgs e)
        {
            var addWordForm = new AddWordForm();
            addWordForm.ShowDialog();
            using (var file = new FileStream("English-Russian.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, library.ShowVocabulary());
            }
        }
    } 
}
