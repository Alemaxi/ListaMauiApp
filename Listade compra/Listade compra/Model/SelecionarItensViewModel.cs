using Listade_compra.Entity;
using System.ComponentModel;

namespace Listade_compra.Model
{
    class SelecionarItensViewModel: INotifyPropertyChanged
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

        public SelecionarItensViewModel()
        {
            Itens = new List<Item>
            {
                new Item {Id=1,Nome="Alexandre"},
                new Item {Id=2,Nome="Bruno"}
            };
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
