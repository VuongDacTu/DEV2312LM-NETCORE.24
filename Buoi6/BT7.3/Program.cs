using BT7._3;

class InvalidMarkException : Exception
{
    public InvalidMarkException():base("Diem chi duoc nhap tu 0 - 10")
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student;
        try
        {
            Console.WriteLine("Nhap Theory: ");
            int a = Console.Read();
            Console.WriteLine("Nhap Labmark: ");
            int b = Console.Read();
            if (a<0 || b< 0 || a>10 || b>10)
            {
                throw new InvalidMarkException();
            }
            else 
                student = new Student(1,"Tu",a,b);
            Console.WriteLine(student.ToString());

        }
        catch (InvalidMarkException e)
        {
            Console.WriteLine(e.ToString());
        }

    }
}