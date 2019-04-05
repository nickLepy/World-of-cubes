using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Styles
{

    private static float multiplicateurSize = 1;
    private static string fontName = "Atarian";

    public static Font FontStandard()
    {
        return Resources.Load("Font/" + fontName, typeof(Font)) as Font;
    }

    private static GUIStyle MettreFontStandard(GUIStyle style)
    {
        style.font = FontStandard();
        return style;
    }

    public static GUIStyle Box_Gros(int fontSize = 80)
    {
        GUIStyle style = new GUIStyle(GUI.skin.box);
        style = MettreFontStandard(style);
        style.fontSize = (int)(fontSize * multiplicateurSize);
        
        return style;
    }

    public static GUIStyle Label_Gros(Color color, int fontSize = 80, TextAnchor alignement = TextAnchor.MiddleLeft)
    {
        
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style = MettreFontStandard(style);
        style.fontSize = (int)(fontSize * multiplicateurSize);
        style.alignment = alignement;
        style.normal.textColor = color;
        return style;
    }

    public static GUIStyle Bouton_Gros(int fontSize = 60)
    {
        GUIStyle style = new GUIStyle(GUI.skin.button);
        style = MettreFontStandard(style);
        style.fontSize = (int)(fontSize * multiplicateurSize);
        return style;
    }

    public static GUIStyle Toggle_Gros(int fontSize = 60)
    {
        GUIStyle style = new GUIStyle(GUI.skin.toggle);
        style = MettreFontStandard(style);
        style.fontSize = (int)(fontSize * multiplicateurSize);
        return style;
    }

    public static GUIStyle TextField_Gros(int fontSize = 60)
    {
        GUIStyle style = new GUIStyle(GUI.skin.textField);
        style = MettreFontStandard(style);
        style.fontSize = (int)(fontSize * multiplicateurSize);
        return style;
    }
}
