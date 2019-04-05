using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    private Niveau _niveau;
    private AffichageObjets _afficheur;

    private void ChargerMusique()
    {
        AudioClip music = Resources.Load("Musique/" + _niveau.Musique, typeof(AudioClip)) as AudioClip;
        transform.GetComponent<AudioSource>().clip = music;
        transform.GetComponent<AudioSource>().Play();
    }

    public void Start()
    {
        _afficheur = new AffichageObjets();
        _niveau = new Niveau("Sentier", "Theme");

        ChargerMusique();
        _afficheur.SpawnJoueur();
    }
  

    public void Update()
    {
        
    }

    private void OnGUI()
    {
        
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginVertical();
        GUILayout.Label("World of Cubes", Styles.Label_Gros(Color.white, 80,TextAnchor.MiddleCenter));
        GUILayout.Label("Adventure", Styles.Label_Gros(Color.cyan, 40, TextAnchor.MiddleCenter));

        GUILayout.EndVertical();

        GUILayout.EndArea();
    }
}