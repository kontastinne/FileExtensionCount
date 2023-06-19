using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCount
{
    internal class FileExtensionCount
    {
        private string path;
        private List<string> filesPath;
        public FileExtensionCount(string path)
        {
            if (path == string.Empty)
            {
                throw new ArgumentNullException("The path cannot be empty");

            }
            this.path = path;
            GetExtensionsFromPath();
        }
        /// <summary>
        /// extracts the extension name from the file in the specified directory
        /// </summary>
        private void GetExtensionsFromPath()
        {
            var filesPath = new List<string>();
            var result = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var item in result)
            {
                filesPath.Add(Path.GetExtension(item));
            }
            this.filesPath = filesPath;
        }
        /// <summary>
        /// Sort extensions of files in the specified directory from largest to smallest
        /// </summary>
        public void GroupByDescending()
        {
            var result = filesPath.GroupBy(g => g, (ext, extcnt) => new { Extension = ext, Count = extcnt.Count() }).OrderByDescending(x => x.Count);
            foreach (var ext in result)
            {
                Console.WriteLine("There are {0} files with extension: {1}", ext.Count, ext.Extension);
            }

        }
        /// <summary>
        /// Sort extensions of files in the specified directory from smallest to largest
        /// </summary>
        public void GroupByAscending()
        {
            var result = filesPath.GroupBy(g => g, (ext, extcnt) => new { Extension = ext, Count = extcnt.Count() }).OrderBy(x => x.Count);
            foreach (var ext in result)
            {
                Console.WriteLine("There are {0} files with extension: {1}", ext.Count, ext.Extension);
            }
        }
    }
}

