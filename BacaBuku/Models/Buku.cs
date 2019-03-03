using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacaBuku.Models
{
    class Buku
    {
        public string Judul { get; set; }
        public string Author { get; set; }
        public string DownloadLink { get; set; }
        public int YearPublished { get; set; }
        public string Description { get; set; }
        public int JumlahHalaman { get; set; }
    }
}
