﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polimer.Data.Models;

[Table("recipe")]
public record RecipeEntity : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    [Required]
    public int Id { get; init; }

    [Column("id_mixture")]
    [Required]
    public int IdMixture { get; init; }
    [ForeignKey("IdMixture")]
    public virtual MixtureEntity Mixture { get; init; }

    [Column("id_additive")]
    [Required]
    public int IdAdditive { get; init; }
    [ForeignKey("IdAdditive")]
    public virtual AdditiveEntity Additive { get; init; }
    public virtual ICollection<CompositionRecipeEntity>? CompositionRecipes { get; init; }
}