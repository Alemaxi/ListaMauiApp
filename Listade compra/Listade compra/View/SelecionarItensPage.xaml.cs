using Listade_compra.Model;

namespace Listade_compra.View;

public partial class SelecionarItensPage : ContentPage
{
	public SelecionarItensPage()
	{
		InitializeComponent();
		BindingContext = new ListaCompraViewModel();
	}
}