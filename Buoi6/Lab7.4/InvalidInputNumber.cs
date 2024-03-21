// định nghĩa lớp custom ngoại lệ chỉ cho nhập số nguyên dương
public class InvalidInputNumber:Exception
{
    public InvalidInputNumber() : base("Hay nhap 1 so > 0")
    { 
        
    }
}
class Program
{
    static void Main(string[] args)
    {
        int intCnt;
        int intNum = 0;
        Console.WriteLine("Nhap 1 so: ");
        // nhập và tung ngoại lệ
        try
        {
            intNum = Convert.ToInt32(Console.ReadLine());
            if(intNum <= 0)
            {
                throw new InvalidInputNumber();
            }
        }
        catch ( InvalidInputNumber objInvalidInput)
        {
            Console.WriteLine(objInvalidInput.Message);
        }
        catch(System.FormatException objFormatException)
        {
            Console.WriteLine(objFormatException.Message);
        }
        finally
        {
            if(intNum > 0)
            {
                //in ra dãy số *100
                for(intCnt = 0; intCnt < 11; intCnt++) 
                {
                    Console.WriteLine(intCnt * intNum);
                }
            }
        }
    }
}