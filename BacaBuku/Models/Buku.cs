using BacaBuku.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacaBuku.Models
{
    class Buku : ObservableObject
    {
        private string _judul;
        public string Judul
        {
            get { return _judul; }
            set { OnPropertyChanged(ref _judul, value); }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { OnPropertyChanged(ref _author, value); }
        }

        private string _deskripsi;
        public string Deskripsi
        {
            get { return _deskripsi; }
            set { OnPropertyChanged(ref _deskripsi, value); }
        }

        public int _yearpublished;
        public int YearPublished
        {
            get { return _yearpublished; }
            set { OnPropertyChanged(ref _yearpublished, value); }
        }

        public int _halaman;
        public int Halaman
        {
            get { return _halaman; }
            set { OnPropertyChanged(ref _halaman, value); }
        }

        public string _coverurl;
        public string CoverUrl
        {
            get { return _coverurl; }
            set { OnPropertyChanged(ref _coverurl, value); }
        }

        public string _downloadurl;
        public string DownloadUrl
        {
            get { return _downloadurl; }
            set { OnPropertyChanged(ref _downloadurl, value); }
        }
    }
}
