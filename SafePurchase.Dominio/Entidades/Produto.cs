namespace SafePurchase.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Desricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validadate()
        {
            throw new System.NotImplementedException();
        }
    }
}
