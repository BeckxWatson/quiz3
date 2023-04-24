class Program {
    static void Main (string[] args) {
        int numberitem = int.Parse(Console.ReadLine());
        int[] num = new int[numberitem];
        for(int i = 0; i < numberitem; i++) {
            num [i] = int.Parse(Console.ReadLine());
        }
        int nameitem = int.Parse(Console.ReadLine());
        int typeitem = int.Parse(Console.ReadLine());
    }
}