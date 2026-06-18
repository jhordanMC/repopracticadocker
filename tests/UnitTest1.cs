using mi_proyecto;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void EstadoPedido_DebeRetornarEnCamino()
    {
        var pedido = new Pedido();
        var resultado = pedido.ObtenerEstado();
        Assert.Equal("EN CAMINO", resultado);
    }

    [Fact]
    public void MensajePedido_DebeContenerEnCamino()
    {
        var pedido = new Pedido();
        var mensaje = pedido.ObtenerMensaje();
        Assert.Contains("EN CAMINO", mensaje);
    }
}