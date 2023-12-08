using KaktuszokCLI;
using System.Text;

Random rnd = new();

List<Kaktusz> kaktuszok = new();
using StreamReader sr = new(@"..\..\..\src\kaktuszok.txt", Encoding.UTF8);
while (!sr.EndOfStream) kaktuszok.Add(new(sr.ReadLine()));

Console.WriteLine($"f1: kaktuszok szama: {kaktuszok.Count}");

var f2 = kaktuszok.MaxBy(k => k.TudomanyosNev.Length).TudomanyosNev;
Console.WriteLine($"f2: leghoszabb tudomanyos nev: {f2}");

var f3a = kaktuszok.Where(k => k.Vizigeny > 100).ToList();
Console.WriteLine($"f3: 100ml-nel nagyobb vizigenyu novenek szama: {f3a.Count} db");
var f3b = f3a[rnd.Next(f3a.Count)];
Console.WriteLine($"\tpeldaul: {f3b.KoznapiNev} ({f3b.Vizigeny} ml/het)");

var f4 = kaktuszok.GroupBy(k => k.TermesztesiNehezseg);
Console.WriteLine("f4: kaktusok szzama termesztesi nehezseg szerint:");
foreach (var g in f4) Console.WriteLine($"\t{g.Key}: {g.Count()} db");