using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades {
    public class Usuario: Entidade {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha  { get; set; }
        public int  Nome { get; set; }
        public string Sobrenome { get; set; }


        /// <summary>
        /// Um usuario pode ter nenhum ou muitos pedidos 
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate() {
            throw new System.NotImplementedException();
        }
    }
}
