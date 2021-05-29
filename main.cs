using System;

class MainClass {
  public static int getItemsInRow(int row) {
    return 1 + (2 * (row - 1));
  }
  public static int getRowCount(int limit) {
    return Convert.ToInt32(Math.Ceiling(Math.Sqrt(limit)));
  }

  public static void Main (string[] args) {
    int limit = args.Length > 0 ? Int32.Parse(args[0]) : 49;
    int curr = 1;
    int row = 1;
    while(curr < limit) {
      int num_spaces =  49 - row;
      for (int i = 0; i < num_spaces; i++) Console.Write("   "); //Three spaces

      for(int i = 0; i < getItemsInRow(row); i++) {
        Console.Write(curr.ToString("00") + " ");
        curr++;
      }
      Console.Write("\n");
      row++;
    }
  }
}