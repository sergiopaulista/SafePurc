using System.Collections.Generic;

namespace SafePurchase.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }
        public string SobreNome { get; set; }


        /// <summary>
        /// Usuário pode ter nenhum ou Varios pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validadate()
        {
            throw new System.NotImplementedException();
        }
    }
}
