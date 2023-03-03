using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter your password (6 digits)");
        int p = int.Parse(Console.ReadLine());
        int _100K = p / 100000, _10K = p / 10000 % 10, _1K = p / 1000 % 10, _100 = p / 100 % 10, _10 = p / 10 % 10, _1 = p % 10;
        Console.WriteLine("Enter your agency name (FBI, CIA, NSA)");
        string agency = Console.ReadLine().ToUpper();
        bool c = false;
        if (agency == "CIA" && _1 % 3 == 0 && _10 != 1 && _10 != 3 && _10 != 5 && _1K >= 6 && _1K != 8) {
        c = true;
        } else if (agency == "FBI" && _100K >= 4 && _100K <= 7 && _100 % 2 == 0 && _100 != 6 && _10K % 2 != 0) {
        c = true;
        } else if (agency == "NSA" && 30 % _1 == 0 && _100 % 3 == 0 && _100 % 2 != 0 && (_10 == 7 || _1K == 7 || _10K == 7 || _100K == 7)) {
        c = true;
        }
        Console.WriteLine(c ? "True" : "False");
    }
}