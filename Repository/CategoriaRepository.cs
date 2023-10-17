using ApiPeliculas.Data;
using ApiPeliculas.Modelos;
using ApiPeliculas.Repository.IRepository;

namespace ApiPeliculas.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {

        //definir el servicio de la base de datos
        private readonly ApplicationDbContext _db;

        // inyeccion de dependencia
        public CategoriaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool ActualizarCategoria(Categoria categoria)
        {
            _db.Categoria.Update(categoria);
            return Guardar();
        }

        public bool CrearCategoria(Categoria categoria)
        {
            _db.Categoria.Add(categoria);
            return Guardar();
        }

        public bool Eliminarcategoria(Categoria categoria)
        {
            _db.Categoria.Remove(categoria);
            return Guardar();
        }

        public bool ExisteCategoria(string nombre)
        {
            return _db.Categoria.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim());
        }

        public bool ExisteCategoria(int idCategoria)
        {
            return (_db.Categoria.Any(c =>c.Id == idCategoria));
        }

        public Categoria GetCategoria(int idCategoria)
        {
            return _db.Categoria.FirstOrDefault(c => c.Id == idCategoria);
        }

        public ICollection<Categoria> GetCategorias()
        {
            return _db.Categoria.OrderBy(c => c.Id).ToList();
        }

        public bool Guardar()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
