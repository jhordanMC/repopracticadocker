using mi_proyecto;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Producto_AhorroLacteos_MenorOIgual45()
    {
        var p = new Producto("Leche Blanca", TipoMarca.SegundaGeneracion,
                             "Lácteos", 1.80m, 1.05m);
        Assert.True(p.PorcentajeAhorro <= 45m);
    }

    [Fact]
    public void Producto_AhorroPostres_Es50()
    {
        var p = new Producto("Postre Blanco", TipoMarca.SegundaGeneracion,
                             "Postres", 2.00m, 1.00m);
        Assert.Equal(50m, p.PorcentajeAhorro);
    }

    [Fact]
    public void Producto_PrecioTradicionalCero_AhorroEsCero()
    {
        var p = new Producto("Sin precio", TipoMarca.Tradicional,
                             "Bebidas", 0m, 0m);
        Assert.Equal(0m, p.PorcentajeAhorro);
    }

    [Fact]
    public void Producto_TipoPrivada_AsignaCorrectamente()
    {
        var p = new Producto("First Line TV", TipoMarca.Privada,
                             "Electrónica", 350m, 210m);
        Assert.Equal(TipoMarca.Privada, p.Tipo);
    }

    [Fact]
    public void Estadistica_CuotaActual_Es22()
    {
        var e = new EstadisticaMercado();
        Assert.Equal(22m, e.CuotaActual);
    }

    [Fact]
    public void Estadistica_CuotaProyectada_Es45()
    {
        var e = new EstadisticaMercado();
        Assert.Equal(45m, e.CuotaProyectada);
    }

    [Fact]
    public void Estadistica_AniosProyeccion_Es3()
    {
        var e = new EstadisticaMercado();
        Assert.Equal(3, e.AniosProyeccion);
    }
}