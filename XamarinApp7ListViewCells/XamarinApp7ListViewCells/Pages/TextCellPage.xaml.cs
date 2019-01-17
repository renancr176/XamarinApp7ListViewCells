using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp7ListViewCells.Repositories;

namespace XamarinApp7ListViewCells.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextCellPage : ContentPage
	{
        private FuncionarioRepository _funcionarioRepository;

        public TextCellPage ()
		{
			InitializeComponent ();

            _funcionarioRepository = new FuncionarioRepository();

            ListaFuncionarios.ItemsSource = _funcionarioRepository.Funcionarios;
        }
    }
}