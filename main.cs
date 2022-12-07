using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Estruturas de Repetição");
    // \r\n insere uma quebra de Linha no texto
      Console.WriteLine("==========================\r\n Para ...");
      // para
        //i  de 0 
        //ate 10 
        //passo 1
      //faça
      // i++ == i+1
      
for (int i = 0;i<=10;i++)
      {
        int num= 2*i;
  Console.WriteLine("2 x " + i + " = " +num)
; 
}
      Console.WriteLine("==========================\r\n Enquanto ...");

      //enquanto (condiçao)
      int n = 0;
      while ( n <= 10)
      {  //n++;
        int num = 3*n;
      
        Console.WriteLine("3 x " + n + " = " +num);
        n= n+3;
      }

Console.WriteLine("==========================\r\n Faça ... Enquanto ");

  int j = 0;
      do
      {
        int num = 2*j;
      
        Console.WriteLine(  "2 x " + j + " = " +num);
        j= j+2;
      }
      while( j<=10);
      



  }
}

