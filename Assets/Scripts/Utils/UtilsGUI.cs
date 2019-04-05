using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class UtilsGUI
{

    ////////////// ICONES //////////////


    public static void DessineIcone(EnumIcone icone, float width = 40, float height = 40)
    {
        GUILayout.Label(Convertion.Icone2Texture(icone),GUILayout.Width(width), GUILayout.Height(height));
    }

    /// <summary>
    /// Affiche une notation en 5 étoiles (0 à 5)
    /// </summary>
    /// <param name="star">Le nombre d'étoile à afficher</param>
    public static void DessineEtoiles(int star, float width = 40, float height = 40)
    {
        if (star < 0) star = 0;
        if (star > 5) star = 5;

        GUILayout.BeginHorizontal();
        for(int i = 0; i<star; i++)
        {
            DessineIcone(EnumIcone.ETOILE, width, height);
        }
        GUILayout.EndHorizontal();
    }

    ////////////// SONS //////////////

    public static void JouerSon(EnumSons son)
    {
        string filename = "";
        switch (son)
        {
            case EnumSons.SON_BOUTON:
                filename = "Sound/button";
                break;
            case EnumSons.SON_DEPLACEMENT:
                filename = "Sound/deplacement";
                break;
        }
        GameObject.Find("Main Camera").GetComponent<AudioSource>().PlayOneShot(Resources.Load(filename, typeof(AudioClip)) as AudioClip);
    }

    ////////////// GRAPHIQUES //////////////

    /// <summary>
    /// Dessine un graphique dans le GUI
    /// </summary>
    /// <param name="barre">Couleur de la barre d'avancement</param>
    /// <param name="fond">Couleur de fond de la barre</param>
    /// <param name="tailleH">Entre 0 et 1</param>
    /// <param name="tailleV">Entre 0 et 1</param>
    /// <param name="pourcentage">Pourcentage d'avancement de la barre (entre 0 et 1)</param>
    public static void DessinerGraphique(Color barre, Color fond, float tailleH, float tailleV, float pourcentage)
    {
        Texture2D texture = new Texture2D(1, 1);

        texture.SetPixel(0, 0, barre);
        texture.Apply();
        GUI.skin.box.normal.background = texture;
        GUILayout.BeginHorizontal();
        GUILayout.Box(GUIContent.none, GUILayout.Width(Screen.width * tailleH * pourcentage), GUILayout.Height(Screen.height * tailleV));
        texture.SetPixel(0, 0, fond);
        texture.Apply();
        GUI.skin.box.normal.background = texture;

        GUILayout.Box(GUIContent.none, GUILayout.Width(1 + (Screen.width * tailleH * (1 - pourcentage))), GUILayout.Height(Screen.height * tailleV));

        GUI.skin.box.normal.background = null;
        GUILayout.EndHorizontal();

    }

    /// <summary>
    /// Créé une texture d'une couleur unie
    /// </summary>
    /// <param name="width">Largeur de la texture</param>
    /// <param name="height">Hauteur de la texture</param>
    /// <param name="col">Couleur</param>
    /// <returns></returns>
    public static Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; ++i)
        {
            pix[i] = col;
        }
        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();
        return result;
    }

    public static void FondEcranGris()
    {
        GUIStyle currentStyle = new GUIStyle(GUI.skin.box);
        currentStyle.normal.background = MakeTex(2, 2, new Color(0f, 0f, 0f, 0.8f));
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "", currentStyle);
    }
}