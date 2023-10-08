using ProjectClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectUI
{
    public partial class StartForm : Form
    {
        Dictionary<string, string> Library;
        List<string> Words;
        public StartForm(Dictionary<string, string> library)
        {
            InitializeComponent();
            Library = library;
            SetWordOnLabel();
        }
        private void SetWordOnLabel()
        {
            if (Library != null)
            {
                var listOfWords = new List<string>(Library.Keys);
                var rnd = new Random();
                WordLabel.Text = listOfWords[rnd.Next(listOfWords.Count)];
                Words = new List<string>
                {
                    Library[WordLabel.Text]
                };
                SetTranlsateOnButtons(WordLabel.Text);
            }
        }
        private void SetTranlsateOnButtons(string word)
        {
            var rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                var randomWordFromList = Library.Values.ElementAt(rnd.Next(Library.Count));
                Words.Add(randomWordFromList);
            }
            WordButton1.Text = Words.ElementAt(rnd.Next(Words.Count));
            Words.Remove(WordButton1.Text);
            WordButton2.Text = Words.ElementAt(rnd.Next(Words.Count));
            Words.Remove(WordButton2.Text);
            WordButton3.Text = Words.ElementAt(rnd.Next(Words.Count));
            Words.Remove(WordButton3.Text);
            WordButton4.Text = Words.ElementAt(rnd.Next(Words.Count));
        }

        private void WordButton1_Click(object sender, EventArgs e)
        {
            var flag = CheckWordAndTranclate(WordButton1.Text);
            if (flag)
            {
                ChangeBackBottomColor();
                Words.Clear();
                SetWordOnLabel();
            }
            else
            {
                WordButton1.BackColor = Color.Red;
            }
        }

        private void WordButton2_Click(object sender, EventArgs e)
        {
            var flag = CheckWordAndTranclate(WordButton2.Text);
            if (flag)
            {
                ChangeBackBottomColor();
                Words.Clear();
                SetWordOnLabel();
            }
            else
            {
                WordButton2.BackColor = Color.Red;
            }
        }

        private void WordButton3_Click(object sender, EventArgs e)
        {
            var flag = CheckWordAndTranclate(WordButton3.Text);
            if (flag)
            {
                ChangeBackBottomColor();
                Words.Clear();
                SetWordOnLabel();
            }
            else
            {
                WordButton3.BackColor = Color.Red;
            }
        }

        private void WordButton4_Click(object sender, EventArgs e)
        {
            var flag = CheckWordAndTranclate(WordButton4.Text);
            if (flag)
            {
                ChangeBackBottomColor();
                Words.Clear();
                SetWordOnLabel();
            }
            else
            {
                WordButton4.BackColor = Color.Red;
            }
        }
        private bool CheckWordAndTranclate(string word)
        {
            if (Library[WordLabel.Text].Equals(word))
            {
                return true;
            }
            return false;
        }
        private void ChangeBackBottomColor()
        {
            WordButton1.BackColor = Color.Transparent;
            WordButton2.BackColor = Color.Transparent;
            WordButton3.BackColor = Color.Transparent;
            WordButton4.BackColor = Color.Transparent;
        }
    }
}
