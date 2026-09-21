namespace UmiversoPaginas.Data
{
    public class LivroRepository 
    {
       private static List<Livro> _tabelaLivros = new ListLivro ();
       private static int proximoID = 1; // Variável auxiliar 
       public void Adicionar (Livro livro) //método: adiciona livros na lista    }
       (
         livro.Id = proximoId++;
         _tabelaLivros.Add(livro);
       )
      
       public List<Livro  ObterTodos()
       {
          return _tabelaLivros;

       }
}