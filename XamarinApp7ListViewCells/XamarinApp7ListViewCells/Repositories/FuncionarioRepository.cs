using System.Collections.Generic;
using XamarinApp7ListViewCells.Enums;
using XamarinApp7ListViewCells.Models;

namespace XamarinApp7ListViewCells.Repositories
{
    public class FuncionarioRepository
    {
        public List<FuncionarioModel> Funcionarios { get; private set; }

        public FuncionarioRepository()
        {
            Funcionarios = new List<FuncionarioModel>();

            Funcionarios.Add(new FuncionarioModel() { Id = 1, Nome = "José", Cargo = "CEO", Sexo = SexoEnum.Masculino, FotoGrande = "https://www.iconfinder.com/icons/2754582/download/png/128", FotoPequena = "https://www.iconfinder.com/icons/2754582/download/png/32" });
            Funcionarios.Add(new FuncionarioModel() { Id = 2, Nome = "Maria", Cargo = "CFO", Sexo = SexoEnum.Feminino, FotoGrande = "https://www.iconfinder.com/icons/2754576/download/png/128", FotoPequena = "https://www.iconfinder.com/icons/2754576/download/png/32" });
            Funcionarios.Add(new FuncionarioModel() { Id = 3, Nome = "Ricardo", Cargo = "CIO", Sexo = SexoEnum.Masculino, FotoGrande = "https://www.iconfinder.com/icons/2754579/download/png/128", FotoPequena = "https://www.iconfinder.com/icons/2754579/download/png/32" });
            Funcionarios.Add(new FuncionarioModel() { Id = 4, Nome = "Eduardo", Cargo = "CMO", Sexo = SexoEnum.Masculino, FotoGrande = "https://www.iconfinder.com/icons/2754583/download/png/128", FotoPequena = "https://www.iconfinder.com/icons/2754583/download/png/32" });
            Funcionarios.Add(new FuncionarioModel() { Id = 5, Nome = "Omar", Cargo = "COO", Sexo = SexoEnum.Masculino, FotoGrande = "https://www.iconfinder.com/icons/2754578/download/png/128", FotoPequena = "https://www.iconfinder.com/icons/2754578/download/png/32" });
            Funcionarios.Add(new FuncionarioModel() { Id = 6, Nome = "Matheus", Cargo = "CTO", Sexo = SexoEnum.Masculino, FotoGrande = "https://www.iconfinder.com/icons/2754575/download/png/128", FotoPequena = "https://www.iconfinder.com/icons/2754575/download/png/32" });
        }
    }
}
