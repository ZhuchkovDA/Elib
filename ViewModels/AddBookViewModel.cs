using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using Elibrary.Models;

namespace Elibrary
{
    class AddBookViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _author;
        private string _path;
        private int _id;

        private SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RecordBookDB"].ConnectionString);

        private RelayCommand _createCommand;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }

        public string Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public AddBookViewModel()
        {
            _sqlConnection.Open();
        }

        public RelayCommand CreateCommand { get => _createCommand ?? (_createCommand = new RelayCommand(obj => Create())); }

        private void Create()
        {
            try
            {
                string command = $"insert into Elib values (N'{Id}', N'{Name}', {Author}, N'{Path}')";

                SqlCommand sqlCommand = new SqlCommand(command, _sqlConnection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Книга добавлена");

                var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive);
                window.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Еррор");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
