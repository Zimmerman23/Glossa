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
            InitializeComponent();
            library = new Library();
            formatter = new BinaryFormatter();
            using(var file = new FileStream("English-Russian.bin", FileMode.OpenOrCreate))
            {
                if (file.Length > 0)
                {
                    library.SetVocabulary((Dictionary<string, string>)formatter.Deserialize(file));
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
        }
    } 
}
