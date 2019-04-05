using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class EtatHabitantRechercheWaypoint : Etat
{

    public EtatHabitantRechercheWaypoint(Automate_Habitant automate): base(automate) { }

    public override void Action()
    {
        Automate_Habitant automate = base.automate as Automate_Habitant;
        if(automate.Target != null)
        {
            automate.Habitant.NavMeshComponent.destination = automate.Target.transform.position;
            //Si l'habitant devient trop proche de la cible, alors on change de cible
            if(Vector3.Distance(automate.Target.transform.position,automate.Habitant.transform.position) < 5)
            {
                automate.Target = null;
            }
        }
        else
        {
            automate.Target = Waypoint();
        }
    }

    public override Etat Suivant()
    {
        return this;
    }

    public GameObject Waypoint()
    {

        GameObject[] res = GameObject.FindGameObjectsWithTag("Habitant_Waypoint");

        return res[UnityEngine.Random.Range(0,res.Length)];
    }
}
