﻿using SharpEcho.Recruiting.SpellChecker.Contracts;
using System.Net;

namespace SharpEcho.Recruiting.SpellChecker.Core
{
    /// <summary>
    /// This is a dictionary based spell checker that uses dictionary.com to determine if
    /// a word is spelled correctly
    /// 
    /// The URL to do this looks like this: http://dictionary.reference.com/browse/<word>
    /// where <word> is the word to be checked
    /// 
    /// Example: http://dictionary.reference.com/browse/SharpEcho would lookup the word SharpEcho
    /// 
    /// We look for something in the response that gives us a clear indication whether the
    /// word is spelled correctly or not
    /// </summary>
    public class DictionaryDotComSpellChecker : ISpellChecker
    {
        public bool Check(string word)
        {
            //dictionary.com url used here for checking the misspelled word.

            string url = ("http://dictionary.reference.com/browse/" + word).ToLower();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Test the url for a redirect to the "misspelling url".
                    int misspellingIndex = request.Address.OriginalString.IndexOf("misspelling?");
                    return misspellingIndex != 32;
                }
            }
            catch (WebException e)
            {
                //web exception is thrown when we try to access a misspelled word.
                return false;
            }
            //return false;
        }
    }
}
