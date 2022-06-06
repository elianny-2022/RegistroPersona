using System.ComponentModel.DataAnnotations;

public class Personas
{
     [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
        public String? Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Apellido")]
        public String? Apellido { get; set; }  
        
        [Required(ErrorMessage = "Es obligatorio introducir la Cedula")]
        [MinLength(10, ErrorMessage = "La Cedula debe tener al menos {1} caractéres.")]
        [MaxLength(20, ErrorMessage = "La Cedula no debe pasar de {1} caractéres.")]
        public String? Cedula { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Direccion")]
        [MinLength(3, ErrorMessage = "La Direccion debe tener al menos {1} caractéres.")]
        [MaxLength(50, ErrorMessage = "La Direccion no debe pasar de {1} caractéres.")]
        public String? Direccion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Telefono")]
        [MinLength(10, ErrorMessage = "El telefono debe tener al menos {1} caractéres.")]
        [MaxLength(15, ErrorMessage = "El telefono no debe pasar de {1} caractéres.")]
        [Phone]
        public String? Telefono { get; set; }

        [Required(ErrorMessage = "Es obligaorio poner F(femenino) o M(masculino)")]
        
        public String? Sexo { get; set; }

        [Required(ErrorMessage = "Es obligatorio poner el estado civil")]
      
        public String? EstadoCivil { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }


}