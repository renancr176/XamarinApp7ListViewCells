using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp7ListViewCells.Models;
using XamarinApp7ListViewCells.Repositories;

namespace XamarinApp7ListViewCells.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
    {
        private FuncionarioRepository _funcionarioRepository;

        public ListViewPage ()
		{
			InitializeComponent ();

            _funcionarioRepository = new FuncionarioRepository();

            ListaFuncionarios.ItemsSource = _funcionarioRepository.Funcionarios;
            ListaFuncionarios2.ItemsSource = _funcionarioRepository.Funcionarios;
        }

        private void ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var funcionario = (FuncionarioModel) args.SelectedItem;
            Navigation.PushAsync(new FuncionarioDetalhePage(funcionario.Id));
        }

        private void FeriasAction(object sender, EventArgs args)
        {
            var menuItem = (MenuItem) sender;
            var funcionario = (FuncionarioModel) menuItem.CommandParameter;
            DisplayAlert("Alerta", String.Format("O {0} está de férias.", funcionario.Nome), "OK");
        }

        private void AbonoAction(object sender, EventArgs args)
        {
            var menuItem = (MenuItem)sender;
            var funcionario = (FuncionarioModel)menuItem.CommandParameter;
            DisplayAlert("Alerta", String.Format("O {0} está de abono.", funcionario.Nome), "OK");
        }
    }
}