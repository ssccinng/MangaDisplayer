using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaDisplayer.MVVM.Model
{
    public class MangaModel
    {
        public string Path { get; private set; }
        /// <summary>
        /// 每一话的路径
        /// </summary>
        public List<string> UnitPath { get; set; }

        /// <summary>
        /// 目前在第几话
        /// </summary>
        public int NowHua { get; set; }
        /// <summary>
        /// 目前在第几页
        /// </summary>

        public int NowPage { get; set; }

        public MangaModel(string path)
        {
            Path = path.Trim();
            UnitPath = Directory.GetDirectories(Path).ToList();
        }
    }
}
