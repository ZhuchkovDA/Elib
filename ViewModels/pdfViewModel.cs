using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;


namespace Elibrary
{
    class pdfViewModel
    {
        private Stream docStream;

        public event PropertyChangedEventHandler PropertyChanged;

        public Stream DocumentStream
        {
            get
            {
                return docStream;
            }
            set
            {
                docStream = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DocumentStream"));
            }
        }

        public pdfViewModel()
        {
            //Load the stream from the local system.
#if NETCORE
            docStream = new FileStream(@"../../../Data/HTTP Succinctly.pdf", FileMode.OpenOrCreate);
#else
            docStream = new FileStream(@"../../Books/voina-i-mir.pdf", FileMode.OpenOrCreate);
#endif
        }

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }
}
