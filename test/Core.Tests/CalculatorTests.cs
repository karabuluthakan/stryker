using System;
using Xunit;

namespace Core.Tests;

public class CalculatorTests
{
    private readonly Calculator _sut;

    /// <summary>
    /// 
    /// </summary>
    public CalculatorTests()
    {
        _sut = new Calculator();
    }

    [Theory]
    [InlineData(5, 5, 10)]
    public void calculator_addition_tests(int first, int second, int expected)
    {
        var result = _sut.Addition(first, second);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(12, 7, 5)]
    public void calculator_subtraction_tests(int first, int second, int expected)
    {
        var result = _sut.Subtraction(first, second);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    public void calculator_multiplication_tests(int first, int second, int expected)
    {
        var result = _sut.Multiplication(first, second);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 1, 0)]
    public void calculator_division_tests(int first, int second, int expected, int undivided)
    {
        var (_divided, _undivided) = _sut.Division(first, second);
        Assert.Equal(expected, _divided);
        Assert.Equal(undivided, _undivided);
    }

    [Fact]
    public void calculator_division_when_by_zero_exception()
    {
        Assert.Throws<DivideByZeroException>(() => _sut.Division(1, 0));
    }

    [Fact]
    public void calculator_division_when_arithmetic_exception()
    {
        var exception = Assert.Throws<ArithmeticException>(() => _sut.Division(0, 0));
        Assert.Equal("Zero divided by zero is an indefinite operation.", exception.Message);
    }
}