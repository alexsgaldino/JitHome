﻿// <auto-generated />
using System;
using JitHome.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JitHome.API.Data.Migrations
{
    [DbContext(typeof(JitHomeContext))]
    [Migration("20211123133421_review-Initial")]
    partial class reviewInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("JitResidencial.Domain.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Grupo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PrimeiroNome")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("SobreMim")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataSaldo")
                        .HasColumnType("TEXT");

                    b.Property<int>("EstoqueDisponivel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstoqueFinal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QauntidadeMovimentada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaldoInicial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UserId");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJ")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.ListaPreco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataLista")
                        .HasColumnType("TEXT");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrecoUnitario")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("ListaPreco");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.MovimentacaoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataMovimento")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantidadeEntrada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantidadeSaida")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("MovimentacaoProduto");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Categoria")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataInclusao")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataValidade")
                        .HasColumnType("TEXT");

                    b.Property<int>("EstoqueId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("ListaPrecoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ListaPrecoId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MovimentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("TEXT");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Volume")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("ListaPrecoId1");

                    b.HasIndex("UserId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.Estoque", b =>
                {
                    b.HasOne("JitResidencial.Domain.Models.Produto", "Produto")
                        .WithMany("Estoque")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JitResidencial.Domain.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.ListaPreco", b =>
                {
                    b.HasOne("JitResidencial.Domain.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.MovimentacaoProduto", b =>
                {
                    b.HasOne("JitResidencial.Domain.Models.Produto", "Produto")
                        .WithMany("MovimentacaoProduto")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.Produto", b =>
                {
                    b.HasOne("JitResidencial.Domain.Models.Fornecedor", null)
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("JitResidencial.Domain.Models.ListaPreco", "ListaPreco")
                        .WithMany()
                        .HasForeignKey("ListaPrecoId1");

                    b.HasOne("JitResidencial.Domain.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListaPreco");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("JitResidencial.Domain.Models.Produto", b =>
                {
                    b.Navigation("Estoque");

                    b.Navigation("MovimentacaoProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
