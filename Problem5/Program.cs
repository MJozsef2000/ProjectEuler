namespace Problem5{
  class Program{
    static void Main(string [] args){
      int i=1;
      while(check(i) == false)
        i++;
      Console.WriteLine("Result: " + i);
    }

    static bool check(long n){
      for (int i=1; i<21; i++){
        if (n%i != 0)
          return false;
      }
      return true;
    }
  }
}