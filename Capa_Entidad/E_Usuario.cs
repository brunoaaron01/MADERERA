namespace Capa_Entidad
{
    public class E_Usuario
    {
        public int IdUsuario { get; set; }
        public string Dni { get; set; }
        public string NombreCompleto { get; set; }  
        public string Correo { get; set; }
        public string Clave { get; set; }

        public E_Rol Rid  { get; set; }
        public string Estado { get; set; }
        public string FechaRegistro { get; set; }

    }
}
