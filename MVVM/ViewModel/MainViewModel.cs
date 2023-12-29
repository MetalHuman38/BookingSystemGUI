﻿using BookingSystem.Core;
using BookingSystem.MVVM.Model;
using BookingSystem.Repositories;
using System.Collections.ObjectModel;

namespace BookingSystem.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        //Fields
        private UserAccountModel _currentUserAccount;

        private IUserRepository userRepository;

        private IUserBookingRepository userBookingRepository;

        private ObservableCollection<BookingModel> _bookings;


        public UserAccountModel CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }

            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }

        public MainViewModel()
        {
            userBookingRepository = new UserBookingRepository();
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            LoadCurrentUserData();
            LoadBookings();
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Username = user.Username;
                CurrentUserAccount.DisplayName = $"Welcome {user.Name} {user.LastName}";
                CurrentUserAccount.ProfilePicture = null;
            }
            else
            {
                CurrentUserAccount = new UserAccountModel // Ensure CurrentUserAccount is initialized
                {
                    DisplayName = "Invalid user, not logged in"
                };
                // Hide child views.
            }
        }

        private void LoadBookings()
        {
            // Assuming you have a method in your repository to get all bookings
            var bookings = userBookingRepository.GetAllBookings();

            // Assign the fetched bookings to the Bookings property
            Bookings = new ObservableCollection<BookingModel>(bookings);
        }

        public ObservableCollection<BookingModel> Bookings
        {
            get { return _bookings; }
            set
            {
                if (_bookings != value)
                {
                    _bookings = value;
                    OnPropertyChanged(nameof(Bookings));
                }
            }
        }

    }
}
