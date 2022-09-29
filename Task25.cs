class Task25
{

    public Task25()
    {

        int digitA = MainClass.readInteger("Введите число A");
        int digitB = MainClass.readInteger("Введите число B");


        int result=power(digitA,digitB);

        Console.WriteLine("Число А возведено в степень B, результат - "+result);

    }

    int power(int digitValue,int pow){
        int digInitial=digitValue;
            for (int i = 1; i < pow; i++)
            {
                digitValue=digitValue*digInitial;
                  Console.WriteLine(digitValue);
            }

            return digitValue;
    }
}