using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(20 / 20);
    maths();
     
    
  }
  public static void maths (){
    Console.WriteLine("Enter a number");
    int num = Convert.ToInt32 (Console.ReadLine());

    if (num < 4){
      Console.WriteLine("No");
    }
    Console.WriteLine (num);
    int div = (num % 20);
    if (div == 0){
      int divide = (num / 20);
      Console.WriteLine ("Number of boxes " + divide);
     
    }
    div = 0;
    divide = 0;
    div = (num % 9);
    Console.WriteLine(div);
    if (div == 0){
      divide = (num / 9);
      console.WriteLine ("Number of boxes" + divide)
    }
    div = 0;
    divide = 0;
    div = (num % 6);
    Console.WriteLine(div);
    if (div == 0){
      divide = (num / 6);
      console.WriteLine ("Number of boxes" + divide)
    }
    div = 0;
    divide = 0;
    div = (num % 6);
    Console.WriteLine(div);
    if (div == 0){
      divide = (num / 6);
      console.WriteLine ("Number of boxes" + divide)
    }

  }
}
