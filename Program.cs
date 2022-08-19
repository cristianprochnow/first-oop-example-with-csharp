Cidade cidade = new Cidade("Joinville", 347000, 1131.32, "SC");

Console.Clear();

Console.WriteLine();
Console.WriteLine( cidade.buscarDados() );

Console.WriteLine();
Console.WriteLine( cidade.buscarDados("T") );

Console.WriteLine();
Console.WriteLine( cidade.buscarDados("D") );

Console.WriteLine();
Console.WriteLine( cidade.buscarDados("A") );

Console.WriteLine();
Console.WriteLine( cidade.buscarDados("H") );