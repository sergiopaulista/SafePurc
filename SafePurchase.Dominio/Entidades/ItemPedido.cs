using System.Collections;
using System.Collections.Generic;

namespace SafePurchase.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public override void Validadate()
        {
            throw new System.NotImplementedException();
        }
    }
}