using Listade_compra.Entity;
using Listade_compra.Servico.Interface;
using System;

namespace Listade_compra.View;

public partial class CadastrarItem : ContentPage
{
	string nomeItem;

	IItemService _itemService;

	public CadastrarItem()
	{
		InitializeComponent();

		var services = AppShell.Current.BindingContext as Servicos;

		_itemService = services.ItemService;
	}

    public void NomeChanged(object sender, EventArgs e)
    {
        var result = (Entry)sender;
        nomeItem= result.Text;
    }

	public void CadastrarClicked(object sender, EventArgs e)
	{
		_itemService.Adicionar(new Item
		{
			Nome = nomeItem,
		});

		Navigation.PopAsync();
	}
}