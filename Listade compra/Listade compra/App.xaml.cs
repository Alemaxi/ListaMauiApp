using Listade_compra.Entity;
using Listade_compra.Servico.Interface;

namespace Listade_compra;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell(); 
	}
}
