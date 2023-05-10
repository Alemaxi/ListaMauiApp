using Listade_compra.Entity;
using Listade_compra.Servico.Interface;
using LiteDB;

namespace Listade_compra.Servico.Implementacao
{
    public class ItemService: IItemService
    {
        string _path;
        public ItemService()
        {
            _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lista.db");

            using (var db = new LiteDatabase(_path))
            {
                var collection = db.GetCollection<Item>("Itens");

                collection.EnsureIndex(x => x.Id);

            }
        }
        public IEnumerable<Item> ObterTodos()
        {
            using (var db = new LiteDatabase(_path))
            {
                var collection = db.GetCollection<Item>("Itens");

                return collection.FindAll().ToList();
            }
        }

        public void Adicionar(Item item)
        {
            using (var db = new LiteDatabase(_path))
            {
                var collection = db.GetCollection<Item>("Itens");

                collection.Insert(item);
            }
        }

        public void RemoverUm(Item item)
        {
            using (var db = new LiteDatabase(_path))
            {
                var collection = db.GetCollection<Item>("Itens");

                collection.Delete(item.Id);
            }
        }
    }
}
