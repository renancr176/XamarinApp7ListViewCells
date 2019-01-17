using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp7ListViewCells.Repositories;

namespace XamarinApp7ListViewCells.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewCellPage : ContentPage
	{
        private FuncionarioRepository _funcionarioRepository;

        public ViewCellPage ()
		{
			InitializeComponent ();

            _funcionarioRepository = new FuncionarioRepository();

            ListViewFuncionarios.ItemsSource = _funcionarioRepository.Funcionarios;
        }
	}
}