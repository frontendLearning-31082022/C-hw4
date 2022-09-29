
using System.Text.RegularExpressions;
class Task29
{

    public Task29()
    {
      int[] array=genArray8();
      printResult(array);
    }

    int[] genArray8(){
        int[] array=new int[8];

        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
             int rndNum  = rnd.Next(); 
             array[i]=rndNum;
        }
       return array;
    }

    void printResult(int[] array){
        string msg="";
       Array.ForEach(array, x=> msg=msg+x+",");
       msg=Regex.Replace(msg,",$","");
       msg="["+msg+"]";
        Console.WriteLine(msg);
    }
}