using ApiPeliculas.Modelos;

namespace ApiPeliculas.Repository.IRepository
{
    public interface ICategoriaRepository
    {
        // obtener todas las categorias
        ICollection<Categoria> GetCategorias();

        //metodo para obtener una categoria
        Categoria GetCategoria(int idCategoria);

        // metodo para validar la existencia de la categoria por nombre y id
        bool ExisteCategoria (string nombre);
        bool ExisteCategoria (int idCategoria);

        //metodo para crear una categoria
        bool CrearCategoria (Categoria categoria);

        //metodo para actualizar una categoria
        bool ActualizarCategoria(Categoria categoria);

        // metodo para eliminar una categoria
        bool Eliminarcategoria(Categoria categoria);

        // metodo validar al momento de guardar
        bool Guardar();

    }
}
