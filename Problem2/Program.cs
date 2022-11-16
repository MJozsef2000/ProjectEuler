namespace Problem2{
    class Program{
        static void Main(string[] args){
          int i = 0;
          int fib = fibonacci(0);
          int sum = 0;
          while(fib < 4000000){
            if (fib % 2 == 0){
              sum += fib;
            }
            i++;
            fib = fibonacci(i);
          }
          Console.WriteLine("Sum of even valued terms: " + sum);
        }

        static int fibonacci(int n){
          if (n == 0)
            return 0;
          if (n == 1)
            return 1;
          return fibonacci(n-1) + fibonacci(n-2);
        }
    }
}