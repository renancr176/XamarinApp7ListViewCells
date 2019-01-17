using XamarinApp7ListViewCells.Enums;

namespace XamarinApp7ListViewCells.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public SexoEnum Sexo { get; set; }
        public string FotoPequena { get; set; }
        public string FotoGrande { get; set; }
    }
}
