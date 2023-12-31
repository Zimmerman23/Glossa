﻿using ProjectClassLibrary;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class AddWordForm : Form
    {
        Library Library;
        public AddWordForm(Library library)
        {
            Library = library;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var checkWord = CheckString(WordBox.Text);
            bool checkTranslate;
            if (checkWord)
            {
                checkTranslate = CheckString(TranslateBox.Text);
            }
            else
            {
                checkTranslate = false;
            }
            
            if (checkWord && checkTranslate)
            {
                if (!Library.ShowVocabulary().ContainsKey(WordBox.Text))
                {
                    Library.AddWord(WordBox.Text.ToLower(), TranslateBox.Text.ToLower());
                    label1.Text = "Слово успешно добавлено!";
                }
                else
                {
                    label1.Text = "Такое слово уже есть в базе.";
                }
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
                WordBox.Text = "";
                TranslateBox.Text = "";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            WordBox.Text = "";
            TranslateBox.Text = "";
            label1.Text = "";
        }
    }
}
