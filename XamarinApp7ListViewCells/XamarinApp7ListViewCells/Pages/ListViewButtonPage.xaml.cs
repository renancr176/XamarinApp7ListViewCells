using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp7ListViewCells.Enums;
using XamarinApp7ListViewCells.Models;
using XamarinApp7ListViewCells.Repositories;

namespace XamarinApp7ListViewCells.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewButtonPage : ContentPage
	{
        private FuncionarioRepository _funcionarioRepository;

        public ListViewButtonPage ()
		{
			InitializeComponent ();

            _funcionarioRepository = new FuncionarioRepository();

            ListaFuncionario.ItemsSource = _funcionarioRepository.Funcionarios;
        }

        private void BtnClickedAction(object sender, EventArgs args)
        {
            var btn = (Button) sender;
            var funcionario = (FuncionarioModel) btn.CommandParameter;

            DisplayAlert("Férias", String.Format("{0} {1} {2} de férias", ((funcionario.Sexo == SexoEnum.Feminino)? "A":"O"), funcionario.Nome, "saiu"), "Ok");
        }
    }
}