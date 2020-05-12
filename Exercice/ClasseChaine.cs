using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
  public class ClasseChaine
  {
    public string RetourneInitiales(string prenomNom)
    {
      if (string.IsNullOrEmpty(prenomNom))
        return string.Empty;

      var tab = prenomNom.Split(' ');
      if (tab.Count() != 2)
        return string.Empty;

      return string.Format("{0}.{1}.", tab[0].ElementAt(0), tab[1].ElementAt(0));
    }
  }
}
