namespace Problem3{
  class Program{
    static void Main(string [] args){
      long num = 600851475143;
      long div = 2;
      while (isPrime(num) == false){
        if (isPrime(div)){
          if (num % div == 0){
            num = num / div;
            Console.Write(div + " * ");
          } else {
            div++;
          }
        } else {
          div++;
        }
      }
      Console.WriteLine(num);
    }

    static bool isPrime(long n){
      bool flag = true;
      for(int i=2; i<n; i++){
        if (n%i == 0){
          flag = false;
          break;
        }
      }
      return flag;
    }
  }
}