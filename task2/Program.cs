bool BL(string name, bool f) {
    System.Console.WriteLine(name);
    return f;
}

if (BL("1", false) && BL ("2", true)) System.Console.WriteLine("3");