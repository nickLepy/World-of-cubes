using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Affichage_Joueur
{
    public static void GUIJoueur(Joueur j)
    {
        
        GUILayout.BeginArea(new Rect(0, Screen.height * 0.8f, Screen.width * 0.4f, Screen.height * 0.2f));

        GUILayout.BeginVertical();
        
        GUILayout.EndVertical();

        GUILayout.EndArea();

    }
    
}