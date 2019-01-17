using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp7ListViewCells.Repositories;

namespace XamarinApp7ListViewCells.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageCellPage : ContentPage
	{
        private FuncionarioRepository _funcionarioRepository;

        public ImageCellPage ()
		{
			InitializeComponent ();

            _funcionarioRepository = new FuncionarioRepository();

            ListaFuncionarios.ItemsSource = _funcionarioRepository.Funcionarios;
        }
	}
}