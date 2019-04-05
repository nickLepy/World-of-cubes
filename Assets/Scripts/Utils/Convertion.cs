using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Convertion
{
    public static Color Couleur2Color(EnumCouleurs couleur)
    {
        Color c;
        switch (couleur)
        {
            case EnumCouleurs.ROUGE: c = Color.red;
                break;
            case EnumCouleurs.BLEU: c = Color.blue;
                break;
            case EnumCouleurs.VERT: c = Color.green;
                break;
            case EnumCouleurs.JAUNE: c = Color.yellow;
                break;
            default: c = Color.black;
                break;
        }
        return c;
    }

    public static Material Couleur2Material(EnumCouleurs color)
    {
        Material m = new Material(Shader.Find("Standard"));
        m.color = Convertion.Couleur2Color(color);
        return m;
    }


    /// <summary>
    /// Trie un dictionnaire dans l'ordre décroissant
    /// </summary>
    /// <typeparam name="TKey">Type clé</typeparam>
    /// <typeparam name="TValue">Type valeur</typeparam>
    /// <param name="dictionnaire">Le dictionnaire à trier</param>
    /// <returns>Le dictionnaire trié</returns>
    public static Dictionary<TKey,TValue> TrierDictionnaire<TKey, TValue>(Dictionary<TKey, TValue> dictionnaire)
    {
        //Trie du dictionnaire en fonction de la valeur, grâce à Linq
        IEnumerable<KeyValuePair<TKey, TValue>> sorted = from entry in dictionnaire orderby entry.Value descending select entry;
        Dictionary<TKey, TValue> trie = sorted.ToDictionary(pair => pair.Key, pair => pair.Value);
        return trie;
    }
    
    public static Texture2D Icone2Texture(EnumIcone icone)
    {
        
        Texture2D res = null;
        switch (icone)
        {
            case EnumIcone.GARNISON: res = Resources.Load("Images/garnison",typeof(Texture2D)) as Texture2D;
                break;
            case EnumIcone.ETOILE:
                res = Resources.Load("Images/star", typeof(Texture2D)) as Texture2D;
                break;
        }
        

        return res;
    }

   
}
