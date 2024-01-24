using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionViewIssues
{
	public class MainPageVM : INotifyPropertyChanged
	{
        public List<SettingsModel> SettingsList { get; set; } = new();

        public MainPageVM()
		{
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                SettingsList.Add(new SettingsModel { Title = $"Title Test {i}", Value = $"Value Test {i}", Height = rand.Next(200,400) });
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

