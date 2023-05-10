using Listade_compra.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listade_compra.Model
{
    public class ListaCompraViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        IEnumerable<Item> _itens;
        public IEnumerable<Item> Itens { 
            get { return _itens; }
            set
            {
                _itens = value;
                OnPropertyChanged(nameof(Itens));
            }
        }

        public ListaCompraViewModel()
        {
            Itens = new List<Item>
            {
                new Item {Id=1,Nome="Alexandre"},
                new Item {Id=2,Nome="Bruno"},
                new Item {Id=2,Nome="Isabella"},
                new Item {Id=2,Nome="Charles"}
            };
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
