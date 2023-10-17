﻿using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CategoriaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        public DateTime FechaCrecion { get; set; }
    }
}
