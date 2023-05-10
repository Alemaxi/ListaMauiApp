using Listade_compra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listade_compra.Servico.Interface
{
    public interface IItemService
    {
        public IEnumerable<Item> ObterTodos();
        public void Adicionar(Item item);
        public void RemoverUm(Item item);
        
    }
}
