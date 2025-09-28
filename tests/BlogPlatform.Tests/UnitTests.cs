using Xunit;

namespace BlogPlatform.Tests;

public class UnitTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var expected = true;
        
        // Act
        var actual = true;
        
        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void TestWithParameters(int value)
    {
        // Arrange & Act
        var result = value > 0;
        
        // Assert
        Assert.True(result);
    }
}
