using System.Globalization;


Cliente miCliente = new Cliente("Julian",318817,"cr4b#23b27","julii@gmail.com",'s');
Console.WriteLine("Nombre: " + miCliente.Nombre);
Console.WriteLine("Telefono: " + miCliente.Telefono);
Console.WriteLine("Direccion: " + miCliente.Direccion);
Console.WriteLine("Email: " + miCliente.Email);
Console.WriteLine("Nuevo Cliente: " + miCliente.NuevoCliente);

Console.WriteLine(miCliente);
public struct Cliente 
{
    public Cliente(String nombre, int telefono, String direccion, String email, char nueCliente)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NuevoCliente = nueCliente;
    }

    public String Nombre { get; set; }
    public int Telefono { get; set; }
    public String Direccion { get; set; }
    public String Email { get; set; }
    public char NuevoCliente { get; set; }


    public override string ToString() => $"({Nombre}, {Telefono}, {Direccion}, {Email}, {NuevoCliente})";
    
}