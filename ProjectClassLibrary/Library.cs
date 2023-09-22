using System;
using System.Collections.Generic;

namespace ProjectClassLibrary
{
    [Serializable]
    public class Library
    {
        private Dictionary<string, string> Vocabulary;        
        public Library()
        {
            Vocabulary = new Dictionary<string, string>();
        }
        public void AddWord(string word, string translate)
        {
            if(!Vocabulary.ContainsKey(word))
            {
                Vocabulary.Add(word, translate);
            }
        }
        public Dictionary<string, string> ShowVocabulary()
        {
            return Vocabulary;
        }
        public void SetVocabulary(Dictionary<string, string> vocabulary)
        {
            Vocabulary = vocabulary ?? throw new ArgumentNullException("Data cannot be empty.");
        }
        public Dictionary<string, string> GetVocabulary()
        {
            return Vocabulary;
        }
    }
}
