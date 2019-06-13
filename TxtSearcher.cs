using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextSearcher.Models
{
    public class TxtSearcher
    {
        public string RootDirectory { get; set; }
        public string PatternFileName { get; set; }
        public string Pattern { get; set; }
        public string CurProcessingFileName { get; private set; }
        public int CountProcessingFile { get; private set; }

        private List<string> _foundFileNames = new List<string>();
        private bool _isSearch;
        
        public TxtSearcher(string path,string patternFileName, string pattern)
        {
            RootDirectory = path;
            PatternFileName = patternFileName;
            Pattern = pattern;
        }

        public void StartSearch()
        {
            _isSearch = true;
            Search();
        }

        public void PauseSearch()
        {
            _isSearch = false;
        }

        public void StopSearch()
        {
            _isSearch = false;
            CountProcessingFile = 0;
        }
   
        private void Search()
        {
            RegexOptions options = RegexOptions.IgnoreCase;
            Regex regex = new Regex(Pattern, options);

            List<string> files = FileLoader.GetFileNames(RootDirectory, PatternFileName, true);

            for(int i = CountProcessingFile; i<files.Count;i++)
            {
                if(_isSearch)
                {
                    CountProcessingFile++;
                    CurProcessingFileName = files[i];
                    using (StreamReader sr = new StreamReader(files[i],Encoding.Default))
                    {
                        if (regex.IsMatch(sr.ReadToEnd()))
                        {
                            _foundFileNames.Add(files[i]);
                        }
                    }

                }
                else
                {
                    break;
                }
               
            }

        }

        public List<string> GetFoundFiles()
        {
            return _foundFileNames;
        }

    }
}
