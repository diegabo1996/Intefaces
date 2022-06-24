using System;
using Intefaces.Interfaces;
using Intefaces.Models;
namespace Intefaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBaseDatos respotorio = new MySQL();
            respotorio.Create("23/06/2022");
            Console.WriteLine(respotorio.Read());
            respotorio.Update("24/06/2022");
            Console.WriteLine(respotorio.Read());
            respotorio.Delete();
            Console.WriteLine(respotorio.Read());
        }
    }
}
