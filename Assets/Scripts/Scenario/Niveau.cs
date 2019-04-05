using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Niveau
{
    private string _musique;
    public string Musique { get { return _musique; } }

    private string _nom;
    public string Nom { get { return _nom; } }

    public Niveau(string nom, string musique)
    {
        _nom = nom;
        _musique = musique;
    }
}