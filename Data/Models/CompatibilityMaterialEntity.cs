﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polimer.Data.Models;

[Table("compatibility")]
public record CompatibilityMaterialEntity : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    [Required]
    public int Id { get; init; }

    [Column("id_material1")]
    [Required]
    public int IdFirstMaterial { get; init; }
    [ForeignKey("IdFirstMaterial")]
    public MaterialEntity FirstMaterial { get; init; }

    [Column("id_material2")]
    [Required]
    public int IdSecondMaterial { get; init; }
    [ForeignKey("IdSecondMaterial")]
    public MaterialEntity SecondMaterial { get; init; }

}