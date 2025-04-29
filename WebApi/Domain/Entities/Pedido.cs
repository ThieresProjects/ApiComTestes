namespace Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public List<ItemPedido> Itens { get; set; }
    }

}
