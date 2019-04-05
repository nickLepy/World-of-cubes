using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class AffichageObjets : MonoBehaviour
{
    
    public void SpawnJoueur()
    {
        GameObject spawner = GameObject.FindGameObjectWithTag("SpawnJoueur");
        GameObject personnage = Resources.Load("Objets/Personnages/Joueur", typeof(GameObject)) as GameObject;
        personnage = Instantiate(personnage);
        personnage.transform.position = spawner.transform.position;

        Material m = new Material(Shader.Find("Standard"));
        m.color = Color.blue;
        personnage.GetComponent<MeshRenderer>().material = m;
        personnage.tag = "Personnage";

        Camera.main.transform.parent = personnage.transform;
        Camera.main.transform.localPosition = new Vector3(0, 1, -5);
        Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);

        personnage.AddComponent<Joueur>();
    }

    
    /// <summary>
    /// Créé un effet de particule
    /// </summary>
    /// <param name="particules">Le nom de l'effet de particules</param>
    /// <param name="origine">L'origine des particules</param>
    /// <param name="detruitApres">Détruit après un certain temps en secondes</param>
    public static void Particules(string chemin, Vector3 origine, float detruitApres)
    {
        GameObject particules = Resources.Load(chemin, typeof(GameObject)) as GameObject;
        particules = Instantiate(particules);
        particules.transform.position = origine;
        Destroy(particules, detruitApres);
    }
}
