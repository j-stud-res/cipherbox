using System;
using System.Text;
using System.Collections.Generic;

namespace cipherBox.Tools
{

    class Caeser
    {
        public enum Lang { None, ENG, BG }
        public UInt16 Shift { get; set; }
        public Lang InstanceLang { get; set; }

        public Caeser()
        {
            this.Shift = 3;
        }

        public string Decode(string text)
        {
            var lp = new LanguagePack(this.InstanceLang);
            return this.AlphabetShifter(text, this.Shift * (-1), lp);
        }

        public string Encode(string text)
        {
            var lp = new LanguagePack(this.InstanceLang);
            return this.AlphabetShifter(text, this.Shift, lp);
        }

        public List<string> BruteForce(string text)
        {
            string firstChars = text.Substring(0, (text.Length <= 101) ? text.Length - 1 : 100 );
            List<string> res = new List<string>();
            LanguagePack lp = new LanguagePack(this.InstanceLang);
            for(UInt16 i = 1; i <= lp.AlphabetLenght; i++)
            {
                res.Add("Shif -> " + i);
                res.Add(this.AlphabetShifter(firstChars, i * (-1), lp));
            }

            return res;
        }

        private string AlphabetShifter(string text, int shift, LanguagePack lp)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int lenght = (shift > 0) ? (-1) * lp.AlphabetLenght : lp.AlphabetLenght;
            for(int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (!lp.IsLetter(c))
                {
                    stringBuilder.Append(c);
                    continue;
                }
                if(lp.IsLowerCase(c))
                {
                    c += (char)shift;
                    c = (lp.IsLowerCase(c)) ? c : (char)(c + lenght);
                    stringBuilder.Append(c);
                    continue;
                }
                if(lp.IsUpperCase(c))
                {
                    c += (char)shift;
                    c = (lp.IsUpperCase(c)) ? c : (char)(c + lenght);
                    stringBuilder.Append(c);
                    continue;
                }
            }
            return stringBuilder.ToString();
        }

        private class LanguagePack
        {
            public char UpcFirs { get; private set; }
            public char UpcLast { get; private set; }
            public char LwcFirst { get; private set; }
            public char LwcLast { get; private set; }
            public UInt16 AlphabetLenght { get; private set; }
            public Lang Language
            {
                get
                {
                    return this._language;
                }
                private set
                {
                    this._language = value;
                    this.InitializeLanguageParams(value);
                }
            }

            private Lang _language;

            public LanguagePack(Lang lang)
            {
                this.Language = lang;
            }

            public bool IsUpperCase(char c)
            {
                return c >= this.UpcFirs && c <= this.UpcLast;
            }

            public bool IsLowerCase(char c)
            {
                return c >= this.LwcFirst && c <= this.LwcLast;
            }

            public bool IsLetter(char c)
            {
                return this.IsUpperCase(c) || this.IsLowerCase(c);
            }

            private void InitializeLanguageParams(Lang lang)
            {
                switch (lang)
                {
                    case Lang.ENG:
                        this.UpcFirs = 'A';
                        this.UpcLast = 'Z';
                        this.LwcFirst = 'a';
                        this.LwcLast = 'z';
                        this.AlphabetLenght = (UInt16)('Z' - 'A') + 1;
                            break;
                    case Lang.BG:
                        this.UpcFirs = 'А';
                        this.UpcLast = 'Я';
                        this.LwcFirst = 'а';
                        this.LwcLast = 'я';
                        this.AlphabetLenght = (UInt16)('Я' - 'А') + 1;
                        break;
                }
            }
        }
    }
}
