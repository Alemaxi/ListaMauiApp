using Listade_compra.Entity;
using Listade_compra.Servico.Implementacao;
using LiteDB;

namespace Listade_compra;

public partial class AppShell : Shell
{
    public AppShell()
	{
		InitializeComponent();


        var servicos = new Servicos
        {
            ItemService = new ItemService()
        };

        BindingContext = servicos;
    }
}
