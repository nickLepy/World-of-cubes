using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Fourni des fonctions de génération de nombres aléatoires selon certaines lois de probabilités
/// </summary>
public class LoisStatistiques
{
    private static System.Random random = new System.Random();
    /// <summary>
    /// Renvoi un nombre aléatoire selon la distribution de probabilité exponentielle
    /// </summary>
    /// <param name="max">La borne maximale du nombre</param>
    /// <param name="alpha">Le paramètre alpha de la fonction exponentielle (plus il est grand, plus les nombres seront regroupés vers 0</param>
    /// <returns></returns>
    public static int LoiExponentielle(int max, int alpha = 1)
    {
        double u = random.NextDouble();
        double x = -Math.Log(u) / alpha;
        if (x > 4) x = 4;
        x /= 4.0;
        x *= max-1;
        
        int res = (int)x;

        if (res < 0) res = 0;
        return res;
    }
}
