namespace Interfaces.classes
{
    public interface ICarrinho
    {
        //CRUD
        //Create Read - Delete
        //Criar Ler Alterar Deletar

        void Listar();

        void Cadastrar(Produto produto);

        void Alterar(int _codigo, Produto produto);

        void Deletar(Produto produto);


    }
}