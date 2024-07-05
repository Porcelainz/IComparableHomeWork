using System.Collections;

namespace ICompareableHomeWork;

class Program
{
    static void Main(string[] args)
    {
        var arrayList1 = new ArrayList();
        arrayList1.Add(new BeSortedObject(7, "bac"));
        arrayList1.Add(new BeSortedObject(5, "cdc"));
        arrayList1.Add(new BeSortedObject(2, "eba"));
        arrayList1.Add(new BeSortedObject(4, "bce"));
        arrayList1.Add(new BeSortedObject(3, "fga"));
       
        arrayList1.Sort(new StringValueCompare(false));
        foreach (var array in arrayList1)
        {
            Console.WriteLine(array.ToString());
        }

        arrayList1.Sort();
        Console.WriteLine("---------------");
        foreach (var array in arrayList1)
        {
            Console.WriteLine(array.ToString());
        }

        Console.WriteLine("-------BubbleSort--------");
        var stringValueCompare = new StringValueCompare(true);
        BubbleSort(arrayList1, stringValueCompare);
        foreach (var array in arrayList1)
        {
            Console.WriteLine(array.ToString());
        }

        Console.WriteLine("\n------Contravariance------");
        IComparer<Employee> employeeComparer = new EmployeeComparer();
        IComparer<Manager> managerComparer = employeeComparer;
        var ManagerList = new List<Manager>();
        ManagerList.Add(new Manager("Bob"));
        ManagerList.Add(new Manager("Alex"));
        ManagerList.Add(new Manager("Alice"));
        ManagerList.Add(new Manager("Casey"));
        ManagerList.Add(new Manager("John"));
        ManagerList.Sort(managerComparer);
        foreach (var array in ManagerList)
        {
            Console.WriteLine(array.ToString());
        }

        Console.WriteLine("\n------Generic------");
        MyGenericComparer<TestClass1> TestClass1Compare = new MyGenericComparer<TestClass1>();
        var TestClass1List = new List<TestClass1>();
        TestClass1List.Add(new TestClass1(100));
        TestClass1List.Add(new TestClass1(99));
        TestClass1List.Add(new TestClass1(20));
        TestClass1List.Add(new TestClass1(33));
        TestClass1List.Add(new TestClass1(1));
        TestClass1List.Sort(TestClass1Compare);
        Console.WriteLine("\nTestClass1 List Ascending order");
        foreach (var ele in TestClass1List)
        {
            Console.WriteLine(ele.ToString());
        }

        MyGenericComparer<TestClass2> TestClass2Compare = new MyGenericComparer<TestClass2>();
        var TestClass2List = new List<TestClass2>();
        TestClass2List.Add(new TestClass2(55));
        TestClass2List.Add(new TestClass2(73));
        TestClass2List.Add(new TestClass2(17));
        TestClass2List.Add(new TestClass2(5));
        TestClass2List.Add(new TestClass2(23));
        TestClass2List.Sort(TestClass2Compare);
        Console.WriteLine("\nTestClass2 List Ascending order");
        foreach (var ele in TestClass2List)
        {
            Console.WriteLine(ele.ToString());
        }

        MyGenericDescendingComparer<TestClass1> TestClass1DescendingCompare = new MyGenericDescendingComparer<TestClass1>();
        TestClass1List.Sort(TestClass1DescendingCompare);
        Console.WriteLine("\nTestClass1 List Descending order");
        foreach (var ele in TestClass1List)
        {
            Console.WriteLine(ele.ToString());
        }

        MyGenericDescendingComparer<TestClass2> TestClass2DescendingCompare = new MyGenericDescendingComparer<TestClass2>();
        TestClass2List.Sort(TestClass2DescendingCompare);
        Console.WriteLine("\nTestClass2 List Descending order");
        foreach (var ele in TestClass2List)
        {
            Console.WriteLine(ele.ToString());
        }



    }

    public static void BubbleSort(ArrayList list, IComparer comparer)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (comparer.Compare(list[j], list[j + 1]) > 0)
                {
                    // Swap list[j] and list[j + 1]
                    var temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }
}
