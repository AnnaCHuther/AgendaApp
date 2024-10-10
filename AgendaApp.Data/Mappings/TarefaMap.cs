using AgendaApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade 'Tarefa'
    /// </summary>
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            //nome da tabela
            builder.ToTable("TAREFA");

            //definindo o campo 'chave primária'
            builder.HasKey(t => t.Id);

            //mapeamento do campo 'id'
            builder.Property(t => t.Id)
                .HasColumnName("ID"); //nome da coluna

            //mapeamento do campo 'Nome'
            builder.Property(t => t.Nome)
                .HasColumnName("NOME")    //nome da coluna
                .HasMaxLength(150)        //máximo de caracteres
                .IsRequired();            //not null (required)

            //mapeamento do campo 'Data'
            builder.Property(t => t.Data)
                .HasColumnName("DATA")   //nome da coluna
                .HasColumnType("date")   //tipo do campo
                .IsRequired();           //not null (required)

            //mapeamento do campo 'Hora'
            builder.Property(t => t.Hora)
                .HasColumnName("HORA")   //nome da coluna
                .HasColumnType("time")   //tipo do campo
                .IsRequired();           //not null (required)

            //mapeamento do campo 'Prioridade'
            builder.Property(t => t.Prioridade)
                .HasColumnName("PRIORIDADE")   //nome da coluna
                .IsRequired();                 //not null (required)

            //mapeamento do campo 'CategoriaId'
            builder.Property(t => t.CategoriaId)
                .HasColumnName("CATEGORIAID")   //nome da coluna
                .IsRequired();                  //not null (required)

            //mapeamento do relacionamento
            builder.HasOne(t => t.Categoria)         //tarefa tem 1 categoria
                .WithMany(c => c.Tarefas)            //categoria tem muitas tarefas
                .HasForeignKey(t => t.CategoriaId);  //chave estrangeira da 
                 
        }
    }
}
