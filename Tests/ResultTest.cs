using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var grades = new List<int>(){84, 29, 57};
        var expected = new List<int>(){85, 29, 57};

        var actual = Result.gradingStudents(grades);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var grades = new List<int>(){73, 67, 38, 33};
        var expected = new List<int>(){75, 67, 40, 33};

        var actual = Result.gradingStudents(grades);

        Assert.Equal(expected, actual);
    }
}