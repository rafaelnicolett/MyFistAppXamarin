using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MyFirstAppXamarin.Model;
using MyFirstAppXamarin.Services;
using PropertyChanged;
using System;
using System.Collections.ObjectModel;

namespace MyFirstAppXamarin.ViewModels
{
    [ImplementPropertyChanged]
    public class HomeViewModel : MvxViewModel
    {
        private readonly IBookRepository _bookRepository;

        public HomeViewModel(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ObservableCollection<Book> Books { get; set; }
        
        public void Init()
        {
            GetAllBooks();
        }

        public void GetAllBooks()
        {
            try
            {
                var books = _bookRepository.GetAll();

                Books = new ObservableCollection<Book>(books);
            }
            catch (Exception ex)
            {
                //TODO: aqui você pode personalizar como quiser a sua mensagem de erro
                UserDialogs.Instance.Alert("Ocorreu um erro tente novamente!");
            }
        }
    }
}
