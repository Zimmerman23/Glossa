using ProjectClassLibrary;
using System;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class AddWordForm : Form
    {
        Library library;
        public AddWordForm()
        {
            library = new Library();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var checkWord = CheckString(textBox1.Text);
            bool checkTranslate;
            if (checkWord)
            {
                checkTranslate = CheckString(textBox2.Text);
            }
            else
            {
                checkTranslate = false;
            }
            if (checkWord && checkTranslate)
            {
                library.AddWord(textBox1.Text.ToLower(), textBox2.Text.ToLower());
                label1.Text = "Слово успешно добавлено!";
            }
        }

        private bool CheckString(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (((int)text.ToLower()[i] >= 97 && (int)text.ToLower()[i] <= 122) ||
                    ((int)text.ToLower()[i] >= 224 && (int)text.ToLower()[i] >= 255))
                {
                    return true;
                }
            }
            ShowError();
            return false;
        }

        private void ShowError()
        {
            var errorForm = new ErrorForm();
            if (errorForm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }
    }
}
