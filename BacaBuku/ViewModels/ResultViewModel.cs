using BacaBuku.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacaBuku.ViewModels
{
    class ResultViewModel : ObservableObject
    {
        delegate IEnumerable<Buku> SortDelegate(ObservableCollection<Buku> obj);
        private ObservableCollection<Buku> _pustaka;
        public ObservableCollection<Buku> Pustaka
        {
            get { return _pustaka; }
            private set { OnPropertyChanged(ref _pustaka, value); }
        }

        public ResultViewModel()
        {

        }

        private void Sort(SortDelegate sd)
        {
            Pustaka = new ObservableCollection<Buku>(sd(Pustaka));
        }

        private IEnumerable<Buku> Tahun (ObservableCollection<Buku> bukus, bool descending=false)
        {
            if(descending)
            {
                return bukus.OrderByDescending(b => b.YearPublished);
            }

            return bukus.OrderBy(b => b.YearPublished);
        }

        private IEnumerable<Buku> Judul (ObservableCollection<Buku> bukus, bool descending = false)
        {
            if (descending)
            {
                return bukus.OrderByDescending(b => b.Judul);
            }

            return bukus.OrderBy(b => b.Judul);
        }

        private IEnumerable<Buku> JumlahHalaman(ObservableCollection<Buku> bukus, bool descending = false)
        {
            if (descending)
            {
                return bukus.OrderByDescending(b => b.Halaman);
            }

            return bukus.OrderBy(b => b.Halaman);
        }
    }
}
