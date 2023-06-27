using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCount
{
    internal class FileInformation
    {
        private string path;

            }
        public List<FileInformation> GetExtensions(List<FileInformation> listExtensions)
        {
            var extensionCounts = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
               .GroupBy(x => Path.GetExtension(x))
               .Select(g => new { Extension = g.Key, Count = g.Count() });
            foreach (var item in extensionCounts)
            {
                listExtensions.Add(new FileInformation { Extension = item.Extension, Count = item.Count });
            }
            this.listExtensions = listExtensions;
            return listExtensions;
        }

        public List<FileInformation> OrderByAscending(List<FileInformation> listExtensions)
        {

            listExtensions.OrderBy(x => x.Count);
            return listExtensions;
        }
            {

            listExtensions.OrderByDescending(x => x.Count);
            return listExtensions;
            }

        public string GetListExtensions()
            {
            return $"There are {this.Count} files with extension: {this.Extension}";
        }
    }
}
