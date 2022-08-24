namespace Library;
public class Class1
{
    public static int Calculator(int x, int y, string operation)
    {
        int output = 0;
        switch (operation)
        {
            case "+":
                output = x + y;
                break;
            case "-":
                output = x - y;
                break;
            case "*":
                output = x * y;
                break;
            case "/":
                output = x / y;
                break;
        }
        return output;
    }
}
