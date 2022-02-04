using System;

namespace jogo_RPG_OO_csharp {
  class Program {
    static void Main(string[] args) {
      Knight arus = new Knight("Arus", 23, "Knight");
      Ninja wedge = new Ninja("Wedge", 42, "Ninja");
      Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
      BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard");

      Console.WriteLine(arus.Attack());
      Console.WriteLine(wedge.Attack());
      Console.WriteLine(jennica.Attack());
      Console.WriteLine(topapa.Attack());
    }
  }
}
