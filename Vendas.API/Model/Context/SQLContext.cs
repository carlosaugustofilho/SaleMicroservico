using Microsoft.EntityFrameworkCore;

namespace Vendas.API.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext() { }
        public SQLContext(DbContextOptions<SQLContext> options)
        : base(options)
        {
        }
        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 2,
                Nome = "Camiseta No Internet",
                ValorUnitario = new decimal(69.9),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true",
                //CategoryNome = "T-shirt"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 3,
                Nome = "Capacete Darth Vader Star Wars Black Series",
                ValorUnitario = new decimal(999.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true",
                //CategoryNome = "Action Figure"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 4,
                Nome = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                ValorUnitario = new decimal(189.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true",
                //CategoryNome = "Action Figure"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 5,
                Nome = "Camiseta Gamer",
                ValorUnitario = new decimal(69.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true",
                //CategoryNome = "T-shirt"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 6,
                Nome = "Camiseta SpaceX",
                ValorUnitario = new decimal(49.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true",
                //CategoryNome = "T-shirt"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 7,
                Nome = "Camiseta Feminina Coffee Benefits",
                ValorUnitario = new decimal(69.9),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                //CategoryNome = "T-shirt"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 8,
                Nome = "Moletom Com Capuz Cobra Kai",
                ValorUnitario = new decimal(159.9),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                //CategoryNome = "Sweatshirt"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 9,
                Nome = "Livro Star Talk – Neil DeGrasse Tyson",
                ValorUnitario = new decimal(49.9),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                // ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true",
                //CategoryNome = "Book"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 10,
                Nome = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                ValorUnitario = new decimal(359.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                //CategoryNome = "Action Figure"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 11,
                Nome = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                ValorUnitario = new decimal(59.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true",
                //CategoryNome = "T-shirt"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 12,
                Nome = "Camiseta GNU Linux Programador Masculina",
                ValorUnitario = new decimal(59.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true",
                //CategoryNome = "T-shirt"
            });
            modelBuilder.Entity<ItemPedido>().HasData(new ItemPedido
            {
                Id = 13,
                Nome = "Camiseta Goku Fases",
                ValorUnitario = new decimal(59.99),
                //Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                //ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                //CategoryNome = "T-shirt"
            });
        }
    }
}
