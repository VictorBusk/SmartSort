using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartSort
{
    public class Rule
    {
        public String name { get; set; }
        public String source { get; set; }
        public String destination { get; set; }
        public String keyWord { get; set; }
        public bool includeFolders { get; set; }
        public bool FoldersNeedKey { get; set; }
        public String fileExtension { get; set; }
        public bool keepSource { get; set; }
        public bool replaceFile { get; set; }
        public bool allFilesInKeyFolder { get; set; }
        private String destination_temp;
        private String source_temp;
        private bool startingWith { get; set; }
        private bool endingWith { get; set; }

        public Rule(String _name, String _source, String _destination, String _keyWord, String _fileExtension, bool _includeFolders, bool _FoldersNeedKey, bool _keepSource, bool _replaceFile, bool _allFilesInKeyFolder, bool _startingWith, bool _endingWith)
        {
            name = _name;
            source = _source;
            destination = _destination;
            keyWord = _keyWord;
            keepSource = _keepSource;
            fileExtension = _fileExtension;
            includeFolders = _includeFolders;
            destination_temp = _destination;
            source_temp = _source;
            FoldersNeedKey = _FoldersNeedKey;
            replaceFile = _replaceFile;
            allFilesInKeyFolder = _allFilesInKeyFolder;
            startingWith = _startingWith;
            endingWith = _endingWith;
        }

        public void executeRule()
        {
            SearchDirectory(source);
        }
        private void iterate(String d)
        {
            source_temp = d.Replace(source, "");
            destination_temp = destination + source_temp;
            Directory.CreateDirectory(destination_temp);
            SearchDirectory(d);
        }
        public bool InBeginning(String path)
        {
            if (startingWith)
            {
                return path.Substring(path.LastIndexOf(@"\") + 1).StartsWith(keyWord);
            }
            return false;
        }
        public bool InEnd(String path)
        {
            if (endingWith)
            {
                return path.Substring(path.LastIndexOf(@"\") + 1, path.LastIndexOf('.') - (path.LastIndexOf(@"\") + 1)).EndsWith(keyWord);
            }
            return false;
        }
        private void SearchDirectory(String dir)
        {
            try
            {
                foreach (String f in Directory.GetFiles(dir))
                {
                    if (f.Substring(f.LastIndexOf('\\')).Contains(keyWord) && f.Substring(f.LastIndexOf('.')).Contains(fileExtension) && !startingWith && !endingWith)
                    {
                        moveFile(f);
                    }
                    else if (InBeginning(f) || InEnd(f))
                    {
                        moveFile(f);
                    }
                    else if (allFilesInKeyFolder && f.Substring(f.LastIndexOf('.')).Contains(fileExtension))
                    {
                        moveFile(f);
                    }
                }
                if (includeFolders)
                {
                    foreach (String d in Directory.GetDirectories(dir))
                    {
                        //contain here need to be fixed!!
                        if (FoldersNeedKey == true && d.Contains(keyWord))
                        {
                            iterate(d);
                        }
                        else
                        {
                            iterate(d);
                        }
                    }
                }
            }
            catch (System.Exception) { }
        }
        private void moveFile(String path)
        {
            var fileDestination = destination + path.Replace(source, "");
            String filename = fileDestination.Substring(path.LastIndexOf(@"\"));
            char left = '[', right = ']';
            if (filename.Contains(left) && filename.Contains(right))
            {
                String folderpath = fileDestination.Substring(0, path.LastIndexOf(@"\"));
                String newfolder = inbetween(filename, left.ToString(), right.ToString());
                if (!Directory.Exists(folderpath + newfolder))
                {
                    Directory.CreateDirectory(folderpath + newfolder);
                }
                filename = RemoveBetween(filename, left, right);
                fileDestination = folderpath + newfolder + @"\" + filename;
            }
            if (keepSource)
            {
                unique(fileDestination);
                File.Copy(path, fileDestination, replaceFile);
            }
            else {
                if (!unique(fileDestination))
                {
                    if (File.Exists(fileDestination))
                    {
                        File.Delete(fileDestination);
                    }
                }
                File.Move(path, fileDestination);
            }
        }
        private bool unique(String fileDestination)
        {
            if (!replaceFile)
            {
                fileDestination = fileDestination.Insert(fileDestination.LastIndexOf("."), "(" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ")");
                Console.WriteLine(fileDestination);
                return true;
            }
            else
            {
                return false;
            }
        }
        private String inbetween(String source, String first, String last)
        {
            String st = source;
            int pFrom = st.IndexOf(first) + first.Length;
            int pTo = st.LastIndexOf(last);
            return st.Substring(pFrom, pTo - pFrom);
        }
        private String RemoveBetween(String s, char begin, char end)
        {
            Regex regex = new Regex(string.Format("\\{0}.*?\\{1}", begin, end));
            return regex.Replace(s, string.Empty);
        }

    }
}
