using mi_proyecto;

Console.WriteLine("=== SISTEMA DE MARCAS BLANCAS ===");
Console.WriteLine("Calidad y Bajos Precios\n");

var productos = new List<Producto>
{
    new("Carrefour Leche",  TipoMarca.SegundaGeneracion, "Lácteos",     1.80m, 1.05m),
    new("First Line TV",    TipoMarca.Privada,           "Electrónica", 350m,  210m),
    new("Hacendado Postre", TipoMarca.SegundaGeneracion, "Postres",     2.00m, 1.00m),
    new("DIA Refresco",     TipoMarca.Tradicional,       "Bebidas",     1.50m, 0.85m),
};

Console.WriteLine($"{"Producto",-22} {"Tipo",-20} {"Categoría",-12} {"Ahorro"}");
Console.WriteLine(new string('-', 65));

foreach (var p in productos)
    Console.WriteLine($"{p.Nombre,-22} {p.Tipo,-20} {p.Categoria,-12} {p.PorcentajeAhorro,5:F1}%");

Console.WriteLine("\n--- Estadísticas de Mercado (España) ---");
var stats = new EstadisticaMercado();
Console.WriteLine($"Cuota actual   : {stats.CuotaActual}%");
Console.WriteLine($"Proyección     : {stats.CuotaProyectada}% en {stats.AniosProyeccion} años");

namespace mi_proyecto
{
    public enum TipoMarca { Tradicional, SegundaGeneracion, Privada }

    public class Producto
    {
        public string Nombre { get; }
        public TipoMarca Tipo { get; }
        public string Categoria { get; }
        public decimal PrecioTradicional { get; }
        public decimal PrecioBlanca { get; }

        public Producto(string nombre, TipoMarca tipo, string categoria,
                        decimal precioTradicional, decimal precioBlanca)
        {
            Nombre            = nombre;
            Tipo              = tipo;
            Categoria         = categoria;
            PrecioTradicional = precioTradicional;
            PrecioBlanca      = precioBlanca;
        }

        public decimal PorcentajeAhorro =>
            PrecioTradicional > 0
                ? Math.Round((1 - PrecioBlanca / PrecioTradicional) * 100, 1)
                : 0;
    }

    public class EstadisticaMercado
    {
        public decimal CuotaActual     { get; set; } = 22m;
        public decimal CuotaProyectada { get; set; } = 45m;
        public int     AniosProyeccion { get; set; } = 3;
    }
}