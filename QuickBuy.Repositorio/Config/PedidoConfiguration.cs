using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config {
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido> {
        public void Configure(EntityTypeBuilder<Pedido> builder) {
            throw new NotImplementedException();
        }
    }
}
