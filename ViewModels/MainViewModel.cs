using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Elibrary
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Lib _current;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public ObservableCollection<Lib> BooksAll { get; set; } =
         new ObservableCollection<Lib> { };

        public ObservableCollection<Lib> BooksAllChoosen { get; set; } =
         new ObservableCollection<Lib> { };

        public ObservableCollection<DataTable> LTable { get; set; } =
    new ObservableCollection<DataTable> { };

        protected SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["LibDB"].ConnectionString);
        protected void UpdateRecordBooks()
        {
            BooksAll.Clear();
            BooksAllChoosen.Clear();
            string command = "select * from Elib";
            SqlCommand sqlCommand = new SqlCommand(command, _sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader.GetValue(0));
                string name = reader.GetValue(1) as string;
                string author = reader.GetValue(2) as string;
                string path = reader.GetValue(3) as string;

                BooksAll.Add(new Lib(name, author, path, id));
                BooksAllChoosen.Add(new Lib(name, author, path, id));
            }
            
            reader.Close();
        }

        public MainViewModel()
        {
            _sqlConnection.Open();
            UpdateDataGrid();
            UpdateRecordBooks();
        }

        private void UpdateDataGrid()
        {
            try
            {
                DataTable table = new DataTable();

                string command = $"select * from Elib";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, _sqlConnection);
                dataAdapter.Fill(table);

                LTable.Clear();
                LTable.Add(table);
            }
            catch (Exception) { }
        }

        public Lib CurrentBooks
        {
            get => _current;
            set
            {
                _current = value;

                UpdateDataGrid();

                OnPropertyChanged(nameof(CurrentBooks));
            }
        }
    }
}
