using DataStructuresAndAlgorithms.InsertionSort;
using FluentAssertions;

namespace DataStructuresAndAlgorithmsTests;

[TestFixture]
public class InsertionSortTests
{
    [Test]
    public void DescendingList_ReversesList()
    {
        var expected = Enumerable.Range(1, 5)
                                 .ToList();
        var array = new List<int>
        {
            5,
            4,
            3,
            2,
            1
        };

        var sut = new InsertionSort();

        var result = sut.Sort(array);

        result.Should()
              .BeEquivalentTo(expected);
    }

    [Test]
    public void AscendingList_DoesNothing()
    {
        var expected = Enumerable.Range(1, 5)
                                 .ToList();
        var array = Enumerable.Range(1, 5)
                              .ToList();

        var sut = new InsertionSort();

        var result = sut.Sort(array);

        result.Should()
              .BeEquivalentTo(expected);
    }
    
    [Test]
    public void AlternatingList_SortsCorrectly()
    {
        var expected = Enumerable.Range(1, 5)
                                 .ToList();
        var array = new List<int>
        {
            1,
            4,
            3,
            2,
            5
        };

        var sut = new InsertionSort();

        var result = sut.Sort(array);

        result.Should()
              .BeEquivalentTo(expected);
    }
}