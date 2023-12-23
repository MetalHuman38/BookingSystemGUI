using BookingSystem.Core;
using BookingSystem.MVVM.Model;
using BookingSystem.MVVM.View;
using BookingSystem.Repositories;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Windows.Input;

namespace BookingSystem.MVVM.ViewModel
{
    public class LoginViewModel : ObservableObject
    {
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        private IUserRepository userRepository;


        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }

            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        // Commands
        public ICommand LoginCommand { get; }
        public ICommand StartBookingCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }





        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            StartBookingCommand = new RelayCommand(ExecuteStartBookingCommand);
            RecoverPasswordCommand = new RelayCommand(p => ExecuteRecoverPassword("", ""));

        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData = !string.IsNullOrWhiteSpace(Username) && Username.Length >= 3 &&
                Password != null && Password.Length >= 3;
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Username, Password));
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(Username), null);
                IsViewVisible = false;


            }
            else
            {
                ErrorMessage = "* Invalid username or password";

            }
        }

        private void ExecuteRecoverPassword(string username, string email)
        {
            throw new NotImplementedException();
        }

        private void ExecuteStartBookingCommand(object obj)
        {
            // Open the StartBookingPage.xaml window
            StartBookingPage startBookingPage = new StartBookingPage();
            startBookingPage.Show();
        }


    }
}
