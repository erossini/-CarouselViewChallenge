using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    /// <summary>
    /// Class CarouselPageViewModel.
    /// Implements the <see cref="System.ComponentModel.INotifyPropertyChanged" />
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    public class CarouselPageViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <returns></returns>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The animal
        /// </summary>
        private ObservableCollection<AnimalModel> _animal;
        /// <summary>
        /// The page title
        /// </summary>
        private string _pageTitle;
        /// <summary>
        /// Initializes a new instance of the <see cref="CarouselPageViewModel"/> class.
        /// </summary>
        public CarouselPageViewModel()
        {
            _pageTitle = "CarouselViewChallege";
            _animal = new ObservableCollection<AnimalModel>();
            _animal.Add(new AnimalModel { Title = "Cute dog", ImagePath = "https://th.bing.com/th/id/OIP.iRjeVJfvve4N0MfUky12HgHaEK?w=294&h=164&c=7&o=5&pid=1.7" });
            _animal.Add(new AnimalModel { Title = "Cute cat", ImagePath = "https://th.bing.com/th/id/OIP.__BpwPGRP9yjsUa8MaS5UQHaFj?w=217&h=163&c=7&o=5&pid=1.7" });
            _animal.Add(new AnimalModel { Title = "Whahaha", ImagePath = "https://th.bing.com/th/id/OIP.rKSQ8lmDeHwH29L73NFsUAHaFj?w=242&h=178&c=7&o=5&pid=1.7" });
        }

        /// <summary>
        /// Gets or sets the animals.
        /// </summary>
        /// <value>The animals.</value>
        public ObservableCollection<AnimalModel> Animals
        {
            get
            {
                return _animal;
            }
            set
            {
                if (_animal != value)
                {
                    _animal = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Birds"));
                }
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get
            {
                return _pageTitle;
            }
            set
            {
                if (_pageTitle != value)
                {
                    _pageTitle = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Title"));
                }
            }
        }

        /// <summary>
        /// Handles the <see cref="E:PropertyChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}