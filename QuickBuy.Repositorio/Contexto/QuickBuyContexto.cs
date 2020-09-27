using Castle.DynamicProxy.Contributors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        // de acordo com as classes no dominio

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            
            //carga inicial do forma de pagamento
            modelBuilder.Entity<FormaPagamento>()
                .HasData(
                new FormaPagamento() { Id = 1, Descricao = "Forma de pagamento em boleto", Nome = "Boleto" },
                new FormaPagamento() { Id = 2, Descricao = "Forma de pagamento em Cartão de credito", Nome = "Cartão de Crédito" },
                new FormaPagamento() { Id = 3, Descricao = "Forma de pagamento em Deposito", Nome = "Deposito" }
                );


            base.OnModelCreating(modelBuilder);
            
        }
    }
}
