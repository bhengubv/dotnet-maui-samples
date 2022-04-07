﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class MonkeyDetailViewModel : IQueryAttributable, INotifyPropertyChanged
    {
        public Animal Monkey { get; private set; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            // Only a single query parameter is passed, which needs URL decoding.
            //string name = HttpUtility.UrlDecode(query["name"]);
            string name = string.Empty;
            LoadAnimal(name);
        }
        void LoadAnimal(string name)
        {
            try
            {
                Monkey = MonkeyData.Monkeys.FirstOrDefault(a => a.Name == name);
                OnPropertyChanged("Monkey");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load animal.");
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
