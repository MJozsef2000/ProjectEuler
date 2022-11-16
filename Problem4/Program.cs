namespace Problem4{
  class Program{
    static void Main(string [] args){
      List<long> ps = new List<long>();
      for (int i=100; i<1000; i++){
        for (int j=100; j<1000; j++){
          if(palindrome(i*j)){
            Console.WriteLine(i + " * " + j + " = " + i*j);
            ps.Add(i*j);
          }
        }
      }
      ps.Sort();
      Console.WriteLine(ps.Last());
    }
    static bool palindrome(long n){
      string comp1 = n.ToString();
      string comp2 = Reverse(n.ToString());
      return String.Equals(comp1, comp2);
    }
    public static string Reverse(string s){
      char[] charArray = s.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
  }
}