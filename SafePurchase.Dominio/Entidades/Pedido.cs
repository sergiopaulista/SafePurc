using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SafePurchase.Dominio.ObjetoDeValor;

namespace SafePurchase.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagementoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }




        /// <summary>
        /// Pedido deve ter pelo menos um item pedido
        /// ou muitos itens pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validadate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica -Pedido não pode ficar sem item de pedido");
                

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("Crítica - Cep deve estar preenchido");
        }
    }
}
