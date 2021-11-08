using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
  class Program
  {
    public static void Main(string[] args)
    {
      var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variáveis e Constantes - Fundamnetos", VariaveisEConstantes.Executar}
            });

      central.SelecionarEExecutar();
    }
  }
}