using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Automate_Habitant : Automate
{

    private Etat courant;

    private Habitant habitant;
    public Habitant Habitant { get { return habitant; } }

    private GameObject target;
    public GameObject Target { get { return target; } set { target = value; } }

    public Automate_Habitant(Habitant habitant)
    {
        this.habitant = habitant;
        target = null;
        courant = new EtatHabitantRechercheWaypoint(this);
    }

    public override void Action()
    {
        courant.Action();
        courant = courant.Suivant();
    }
}
