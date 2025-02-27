﻿// <auto-generated />
using System;
using GeradorTestes.Infra.Orm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeradorTestes.Infra.Orm.Migrations
{
    [DbContext(typeof(GeradorTestesDbContext))]
    partial class GeradorTestesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloDisciplina.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBDisciplina", (string)null);
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Serie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("TBMateria", (string)null);
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloQuestao.Alternativa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Correta")
                        .HasColumnType("bit");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("QuestaoId")
                        .HasColumnType("int");

                    b.Property<string>("Resposta")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("QuestaoId");

                    b.ToTable("TBAlternativa", (string)null);
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloQuestao.Questao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Enunciado")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("JaUtilizada")
                        .HasColumnType("bit");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("TBQuestao", (string)null);
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloTeste.Teste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataGeracao")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.Property<bool>("Provao")
                        .HasColumnType("bit");

                    b.Property<int>("QuantidadeQuestoes")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("TBTeste", (string)null);
                });

            modelBuilder.Entity("QuestaoTeste", b =>
                {
                    b.Property<int>("QuestoesId")
                        .HasColumnType("int");

                    b.Property<int>("TesteId")
                        .HasColumnType("int");

                    b.HasKey("QuestoesId", "TesteId");

                    b.HasIndex("TesteId");

                    b.ToTable("TBTeste_TBQuestao", (string)null);
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.HasOne("GeradorTestes.Dominio.ModuloDisciplina.Disciplina", "Disciplina")
                        .WithMany("Materias")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBMateria_TBDisciplina");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloQuestao.Alternativa", b =>
                {
                    b.HasOne("GeradorTestes.Dominio.ModuloQuestao.Questao", "Questao")
                        .WithMany("Alternativas")
                        .HasForeignKey("QuestaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TBAlternativa_TBQuestao");

                    b.Navigation("Questao");
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloQuestao.Questao", b =>
                {
                    b.HasOne("GeradorTestes.Dominio.ModuloMateria.Materia", "Materia")
                        .WithMany("Questoes")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBQuestao_TBMateria");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloTeste.Teste", b =>
                {
                    b.HasOne("GeradorTestes.Dominio.ModuloDisciplina.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBTeste_TBDisciplina");

                    b.HasOne("GeradorTestes.Dominio.ModuloMateria.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("FK_TBTeste_TBMateria");

                    b.Navigation("Disciplina");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("QuestaoTeste", b =>
                {
                    b.HasOne("GeradorTestes.Dominio.ModuloQuestao.Questao", null)
                        .WithMany()
                        .HasForeignKey("QuestoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeradorTestes.Dominio.ModuloTeste.Teste", null)
                        .WithMany()
                        .HasForeignKey("TesteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloDisciplina.Disciplina", b =>
                {
                    b.Navigation("Materias");
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.Navigation("Questoes");
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloQuestao.Questao", b =>
                {
                    b.Navigation("Alternativas");
                });
#pragma warning restore 612, 618
        }
    }
}
