using mi_proyecto;

var pedido = new Pedido();
Console.WriteLine(pedido.ObtenerEstado());
Console.WriteLine(pedido.ObtenerMensaje());

namespace mi_proyecto
{
    public class Pedido
    {
        public string ObtenerEstado() => "EN CAMINO";
        public string ObtenerMensaje() => "Tu pedido está EN CAMINO";
    }
}