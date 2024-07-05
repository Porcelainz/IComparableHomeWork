public class Employee
{
    public string Name { get; set; }
    public Employee(string name = "")
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}

public class Manager : Employee
{
    public Manager(string name) : base(name)
    {

    }
}

public class EmployeeComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        if (x == null && y == null) throw new ArgumentNullException();
        else
        {
            if (x.Name.ToCharArray()[1] > y.Name.ToCharArray()[1])
            {
                return 1;
            }
            else if (x.Name.ToCharArray()[1] < y.Name.ToCharArray()[1])
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}