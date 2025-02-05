﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.Data.Models;

public partial class Livro
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Required]
    [Column("autor")]
    [StringLength(50)]
    [Unicode(false)]
    public string Autor { get; set; }

    [Required]
    [Column("editora")]
    [StringLength(50)]
    [Unicode(false)]
    public string Editora { get; set; }

    [InverseProperty("IdLivrosNavigation")]
    public virtual ICollection<LivrosCliente> LivrosClientes { get; set; } = new List<LivrosCliente>();
}