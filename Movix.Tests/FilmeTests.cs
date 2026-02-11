using Movix.Domain.Entities;
using Xunit;

namespace Movix.Tests;

public class FilmeTests
{
    [Fact]
    public void NewFilme_ShouldHaveDefaultCreatedAt()
    {
        // Arrange & Act
        var filme = new Filme();

        // Assert
        Assert.NotEqual(default(DateTime), filme.CreatedAt);
        Assert.True(filme.CreatedAt > DateTime.MinValue);
    }

    [Fact]
    public void Filme_ShouldSetPropertiesCorrectly()
    {
        // Arrange
        var titulo = "O Poderoso Chefão";
        var ano = 1972;

        // Act
        var filme = new Filme
        {
            Titulo = titulo,
            Ano = ano
        };

        // Assert
        Assert.Equal(titulo, filme.Titulo);
        Assert.Equal(ano, filme.Ano);
    }
}
