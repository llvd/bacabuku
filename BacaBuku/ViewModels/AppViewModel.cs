using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BacaBuku.ViewModels
{
    class AppViewModel : ObservableObject
    {
        private ObservableObject _currentView;

        public ObservableObject CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                OnPropertyChanged(ref _currentView, value);
            }
        }

        private SearchViewModel _searchVM;
        public SearchViewModel SearchVM
        {
            get { return _searchVM; }
            set { OnPropertyChanged(ref _searchVM, value); }
        }

        private ResultViewModel _resultVM;
        public ResultViewModel ResultVM
        {
            get { return _resultVM; }
            set { OnPropertyChanged(ref _resultVM, value); }
        }

        public ICommand DisplayResultView { get; set; }

        public AppViewModel()
        {
            SearchVM = new SearchViewModel();
            ResultVM = new ResultViewModel();
            DisplayResultView = new RelayCommand(ChangeToResult);
            CurrentView = SearchVM;
        }

        private void ChangeToResult(object obj)
        {
            MessageBox.Show("Yup");
            CurrentView = ResultVM;
        }
    }
}
