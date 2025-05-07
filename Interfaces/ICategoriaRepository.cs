using ProjetoLivros.Models;

namespace ProjetoLivros.Interfaces
{
    public interface ICategoriaRepository
    {
        // Assincrono - Task(Tarefa)
        Task<List<Categoria>> ListarTodosAsync();

        // Sincrono
        List<Categoria> ListarTodos();
        void Cadatrar(Categoria categoria);
        Categoria? Atualizar(int id, Categoria categoria);
        Categoria? Deletar(int id);

    }
}

