


class program
{
    public static void Main(string[] args)
    {


        Console.WriteLine(sizeof(int));

        string str = "Vijay";
        Console.WriteLine(str.Length);

        FunctionParametersDemo functionParametersDemo = new FunctionParametersDemo();
        int addition, substration, multiplication, division;


        int result = functionParametersDemo.Arithemtic(10, 5);
        functionParametersDemo.ArithemticWithOutput(10, 5, out addition, out substration,
                                                     out multiplication, out division);




        //Reference parameters
        int Age = 40;
        functionParametersDemo.FindRemainingYearsOfService(ref Age);

        Console.ReadLine();

    }
}

public class FunctionParametersDemo
{


   public void FindRemainingYearsOfService(ref int Age)
    {
        Age = 60 - Age;
    }







    public int Arithemtic(int num1, int num2)
    {
        int addition = num1 + num2;
        return addition;
    }


    public void ArithemticWithOutput(int num1, int num2, out int addition, out int substration,
                                                    out int multiplication, out int division)
    {
        
        addition = num1 + num2;
        substration = num1 - num2;
        multiplication = num1 * num2;
        division = num1 / num2;

    }
}