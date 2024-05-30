using Inditas.Data;
using Inditas.Models;
using System;
using System.IO;
using System.Linq;

var _context = new DataContext();

if (!_context.Datas.Any())
{
    var lines = File.ReadAllLines(@"C:\Users\cinti\Downloads\5.csv").Skip(1);
    foreach (var line in lines)
    {
        _context.Datas.Add(new Inditas.Models.Persones(line));
    }
    _context.SaveChanges();
    Console.WriteLine("Sikeres feltoltes!");
}

foreach (var item in _context.Datas)
{
    Console.WriteLine(item);
    Console.WriteLine();
}
