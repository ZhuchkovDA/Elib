using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Elibrary 
{
    class Lib : INotifyPropertyChanged
    {
        protected SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["libDB"].ConnectionString);

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private string _name;

        public string Name
        {
            get => _name;
            set {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
       
        }

        private string _author;
        public string Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }

        private string _path;
        public string Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }
        public int Id { get; set; }

        public Lib(string name, string author, string path, int id)
        {
            _sqlConnection.Open();
            Name = name;
            Author = author;
            Path = path;
            Id = id;
        }

    }
}
