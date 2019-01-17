using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp7ListViewCells.Repositories;

namespace XamarinApp7ListViewCells.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FuncionarioDetalhePage : ContentPage
	{
        private FuncionarioRepository _funcionarioRepository;

        public FuncionarioDetalhePage (int idFuncionario)
		{
			InitializeComponent ();

            _funcionarioRepository = new FuncionarioRepository();

            var funcionario = _funcionarioRepository.Funcionarios.FirstOrDefault(f => f.Id == idFuncionario);

            ImageAvatar.Source = funcionario.FotoGrande;
            LabelNome.Text = funcionario.Nome;
            LabelCargo.Text = funcionario.Cargo;
        }
	}
}