using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MyFirstAppXamarin.Model;
using MyFirstAppXamarin.Services;
using PropertyChanged;
using System;

namespace MyFirstAppXamarin.ViewModels
{
    [ImplementPropertyChanged]
    public class BookViewModel : MvxViewModel
    {
        private readonly IBookRepository _bookRepository;

        public BookViewModel(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public string Name { get; set; }
        public string Author { get; set; }

        private MvxCommand _saveBookCommand;
        public MvxCommand SaveBookCommand => _saveBookCommand = _saveBookCommand ?? new MvxCommand(Save);

        private void Save()
        {
            try
            {
                if(Name == string.Empty ||
                    Author == string.Empty)
                {
                    UserDialogs.Instance.Alert("Preencha o nome e o autor do livro!");
                    return;
                }

                var book = new Book
                {
                    Name = Name,
                    Author = Author
                };

                _bookRepository.Save(book);

                Close(this);
            }
            catch (Exception)
            {
                //TODO: aqui você pode personalizar como quiser a sua mensagem de erro
                UserDialogs.Instance.Alert("Ocorreu um erro tente novamente!");
            }
        }
    }
}
