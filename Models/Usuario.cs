namespace Front.Models{

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }="";
    public string Correo { get; set; }="";

}

public class UsuarioDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }="";
    public string Correo { get; set; }="";
    public string Contraseña { get; set; }="";
}
}