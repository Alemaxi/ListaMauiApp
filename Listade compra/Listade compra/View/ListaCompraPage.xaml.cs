using Listade_compra.Entity;
using Listade_compra.Model;
using Listade_compra.Servico.Implementacao;
using Listade_compra.Servico.Interface;
using Listade_compra.View;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace Listade_compra;

public partial class ListaCompra : ContentPage
{
    int count = 0;
    IItemService _itemService;
    ListaCompraViewModel view = new ListaCompraViewModel();

    public ListaCompra()
    {
        InitializeComponent();

        var servicos = AppShell.Current.BindingContext as Servicos;
        _itemService = servicos.ItemService;
        view.Itens = _itemService.ObterTodos();
        BindingContext = this;

        var adicionarButton = new ToolbarItem
        {
            IconImageSource = "add.svg",
            Text = "Add",
        };

        adicionarButton.Clicked += OnClickAdd;

        ToolbarItems.Add(adicionarButton);
        itemView.ItemsSource = view.Itens;

    }


    public async void OnClickItem(Object sender, EventArgs e)
    {
        var item = (StackLayout)sender;
        var result = item.BindingContext as Item;

        var resposta = await DisplayAlert("Remover atividade", $"Tem certeza que deseja remover {result.Nome}?", "Sim", "Não");

        if (resposta)
        {
            _itemService.RemoverUm(result);
            itemView.ItemsSource = _itemService.ObterTodos();
        }

        ClickEfeito(item);
    }

    public void OnClickAdd(Object sender, EventArgs e)
    {
        var pagina = new CadastrarItem();
        pagina.Title = "Cadastrar Item";

        Navigation.PushAsync(pagina);
        pagina.NavigatedFrom += (sender, e) =>
        {
            itemView.ItemsSource = _itemService.ObterTodos();
        };
    }

    async Task ClickEfeito(StackLayout layout)
    {
        layout.BackgroundColor = Colors.LightGray;

        await Task.Delay(50);

        layout.BackgroundColor = null;


        return;
    }
}


