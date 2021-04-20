public static int[] ReverseSeq(int n)
  {
    var result = new List<int>();
    while(n > 0){
      result.Add(n);
      n--;
    }
    return result.ToArray();
  }
