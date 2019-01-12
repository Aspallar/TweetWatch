using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace TweetWatch
{
    internal class SiteBindingList : BindingList<string>
    {
        public SiteBindingList(StringCollection accounts)
        {
            foreach (string account in accounts)
                Add(account);
        }

        public int AddUnique(string item)
        {
            for (int k = 0; k < this.Count; k++)
            {
                if (this[k] == item)
                    return k;
            }
            Add(item);
            return Count - 1;
        }

        public static SiteBindingList LoadFromFile(string fileName)
        {
            var list = new StringCollection();
            if (File.Exists(fileName))
            {
                var sites = File.ReadAllLines(fileName).Select(x => x.Trim()).Where(x => x.Length > 0).ToArray();
                list.AddRange(sites);
            }
            return new SiteBindingList(list);
        }

        public static void SaveToFile(SiteBindingList list, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string entry in list)
                    sw.WriteLine(entry);
            }
        }
    }
}