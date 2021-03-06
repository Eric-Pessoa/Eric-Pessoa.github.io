// <auto-generated />
using System;
using Global_Impact.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Global_Impact.Migrations
{
    [DbContext(typeof(WefeedContext))]
    partial class WefeedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Global_Impact.Models.Doacao", b =>
                {
                    b.Property<int>("DoacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoEstab")
                        .HasColumnType("int");

                    b.Property<int>("CodigoOng")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDoacao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EstabelecimentoId")
                        .HasColumnType("int");

                    b.HasKey("DoacaoId");

                    b.HasIndex("EstabelecimentoId");

                    b.ToTable("Tb_Doacao");
                });

            modelBuilder.Entity("Global_Impact.Models.DoacaoItem", b =>
                {
                    b.Property<int>("DoacaoId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("int");

                    b.HasKey("DoacaoId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("Tb_DoacaoAlimento");
                });

            modelBuilder.Entity("Global_Impact.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Tb_Endereco");
                });

            modelBuilder.Entity("Global_Impact.Models.Estabelecimento", b =>
                {
                    b.Property<int>("EstabelecimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstabelecimentoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Tb_Estabelecimento");
                });

            modelBuilder.Entity("Global_Impact.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ItemId");

                    b.ToTable("Tb_Item");
                });

            modelBuilder.Entity("Global_Impact.Models.Ong", b =>
                {
                    b.Property<int>("OngId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OngId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Tb_Ong");
                });

            modelBuilder.Entity("Global_Impact.Models.Doacao", b =>
                {
                    b.HasOne("Global_Impact.Models.Estabelecimento", null)
                        .WithMany("Doacoes")
                        .HasForeignKey("EstabelecimentoId");
                });

            modelBuilder.Entity("Global_Impact.Models.DoacaoItem", b =>
                {
                    b.HasOne("Global_Impact.Models.Doacao", "Doacao")
                        .WithMany("DoacoesAlimentos")
                        .HasForeignKey("DoacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Global_Impact.Models.Item", "Item")
                        .WithMany("DoacoesItens")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Global_Impact.Models.Estabelecimento", b =>
                {
                    b.HasOne("Global_Impact.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Global_Impact.Models.Ong", b =>
                {
                    b.HasOne("Global_Impact.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
