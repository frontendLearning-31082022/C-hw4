class Task27
{

    public Task27()
    {

        int digit = MainClass.readInteger("Введите число");
        
        int result=sumNumbersOfInteger(digit);

        Console.WriteLine("Сумма цифр числа - "+result);

    }

    int sumNumbersOfInteger(int digitValue){
          String digString = digitValue.ToString();
        char[] splitted= digString.ToCharArray();

        int result=0;
        for (int i = 0; i < splitted.Length; i++)
        {
            int parseInt=splitted[i]-'0';
            result=result+parseInt;
        }

        return result;
    }
}