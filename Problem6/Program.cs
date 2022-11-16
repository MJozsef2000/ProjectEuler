namespace Problem6{
  class Program{
    static void Main(string [] args){
      double sum1 = 0;
      double sum2 = 0;
      for(int i=1; i<101; i++){
        sum1 += Math.Pow(Convert.ToDouble(i),2.0);
        sum2 += i;
      }
      sum2 = Math.Pow(Convert.ToDouble(sum2),2.0);
      Console.WriteLine(sum2-sum1);
    }
  }
}