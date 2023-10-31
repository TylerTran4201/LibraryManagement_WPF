using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    class StringConvert
    {
        public string ConvertIdToName(string Ids)
        {
            ObservableCollection<Author> Authors = new AuthorViewModel().GetAuthors();
            string[] arrId = Ids.Split(',');
            StringBuilder name = new StringBuilder();
            int flag = 0;
            foreach (var item in arrId)
            {
                foreach (var item2 in Authors)
                {
                    if (string.Compare(item, item2.Id) == 0)
                    {
                        if (flag == 0)
                        {
                            flag++;
                            name.Append(item2.Name);
                        }
                        else
                            name.Append(string.Format(", " + item2.Name));
                    }
                }
            }
            return name.ToString();
        }
        public string ConvertIdReaderToName(string id)
        {
            ObservableCollection<Reader> readers = new ReaderViewModel().GetReaders();
            foreach (var item in readers)
            {
                if (string.Compare(id, item.Id) == 0)
                {
                    return item.Name.FullName;
                }
            }
            return string.Empty;
        }
    }
}
