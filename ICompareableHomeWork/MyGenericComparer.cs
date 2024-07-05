public interface IDescendingComparable
{
    int DescendingCompareTo(object? obj);
}

class MyGenericComparer<T> : IComparer<T> where T : IComparable
{
    public int Compare(T? x, T? y)
    {
        return x.CompareTo(y);
        //return y.CompareTo(x);
    }
}

class MyGenericDescendingComparer<T> : IComparer<T> where T : IDescendingComparable
{


    public int Compare(T? x, T? y)
    {
        return x.DescendingCompareTo(y);
    }
}

public class TestClass1 : IComparable, IDescendingComparable
{
    public int Value1 { get; set; }
    public TestClass1(int value)
    {
        Value1 = value;
    }
    public int CompareTo(object? obj)
    {
        TestClass1 testClass1 = (TestClass1)obj;
        if (this.Value1 > testClass1.Value1)
        {
            return 1;
        }
        else if (this.Value1 < testClass1.Value1)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
    public int DescendingCompareTo(object? obj)
    {
        TestClass1 testClass1 = (TestClass1)obj;
        if (this.Value1 > testClass1.Value1)
        {
            return -1;
        }
        else if (this.Value1 < testClass1.Value1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public override string ToString()
    {
        return $"{nameof(Value1)}: {Value1}";
    }


}

public class TestClass2 : IComparable, IDescendingComparable
{
    public double Value2 { get; set; }
    public TestClass2(double value)
    {
        Value2 = value;
    }

    public int CompareTo(object? obj)
    {
        TestClass2 testClass2 = (TestClass2)obj;
        //return this.Value2.CompareTo(testClass2.Value2);
        if (this.Value2 > testClass2.Value2)
        {
            return 1;
        }
        else if (this.Value2 < testClass2.Value2)
        {
            return -1;
        }
        else
        {
            return 0;
        }

    }
    public int DescendingCompareTo(object? obj)
    {
        TestClass2 testClass2 = (TestClass2)obj;

        if (Value2 > testClass2.Value2)
        {
            return -1;
        }
        else if (Value2 < testClass2.Value2)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return $"{nameof(Value2)}: {Value2}";
    }
}