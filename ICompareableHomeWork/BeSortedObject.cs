using System.Collections;

class BeSortedObject : IComparable
{
    public int value { get; set; }
    public string stringValue { get; set; }
    public BeSortedObject(int value, string stringValue)
    {
        this.value = value;
        this.stringValue = stringValue;
    }

    public int CompareTo(object? obj) //default
    {
        BeSortedObject? beSortedObject = obj as BeSortedObject;
        if (value > beSortedObject.value)
        {
            return 1;
        }
        else if (value < beSortedObject.value)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return $"value {this.value}, {this.stringValue}";
    }
}

class StringValueCompare : IComparer
{
    bool Ascending { get; set; }
    public StringValueCompare(bool ascending)
    {
        Ascending = ascending;
    }
    public int Compare(object? x, object? y)
    {
        BeSortedObject? beSortedObject1 = x as BeSortedObject;
        BeSortedObject? beSortedObject2 = y as BeSortedObject;
        return MystringCompare(beSortedObject1.stringValue, beSortedObject2.stringValue, Ascending);

    }

    int MystringCompare(string x, string y, bool ascending) // compare by 2nd char
    {
        var xSecondChar = x.Substring(1, 1).ToCharArray();
        var ySecondChar = y.Substring(1, 1).ToCharArray();
        if (ascending) return AscendingOrder();
        return DescendingOrder();

        int AscendingOrder()
        {
            if (xSecondChar[0] > ySecondChar[0])
            {
                return 1;
            }
            else if (xSecondChar[0] < ySecondChar[0])
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        int DescendingOrder()
        {
            if (xSecondChar[0] > ySecondChar[0])
            {
                return -1;
            }
            else if (xSecondChar[0] < ySecondChar[0])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

}