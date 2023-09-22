using ProjectClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class StartForm : Form
    {
        Library Library;
        public StartForm(Library library)
        {
            InitializeComponent();
            Library = library;
            SetWordOnLabel();
        }
        private void SetWordOnLabel()
        {
            if (Library != null)
            {
                var list = new List<string>(Library.GetVocabulary().Keys);
                var rnd = new Random();
                WordLabel.Text = list[rnd.Next(list.Count)];
                list.Remove(WordLabel.Text);
                var words = SetTranlsateOnButton(WordLabel.Text);
            }
        }
        private List<string> SetTranlsateOnButton(string word)
        {
            List<string> words = new List<string>();
            return words;
        }
    }
}
