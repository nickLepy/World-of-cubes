using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public class Habitant : MonoBehaviour
{

    private Automate_Habitant automate;

    private NavMeshAgent navMeshComponent;
    public NavMeshAgent NavMeshComponent { get { return navMeshComponent; } }

    public void GenererCouleurAleatoire()
    {
        Color[] colors = new Color[] { Color.black, Color.blue, Color.gray, Color.cyan, Color.green, Color.magenta, Color.red, Color.white, Color.yellow };
        GetComponent<MeshRenderer>().material.color = colors[UnityEngine.Random.Range(0, colors.Length)];
    }


    private void Start()
    {
        automate = new Automate_Habitant(this);
        navMeshComponent = GetComponent<NavMeshAgent>();
        GenererCouleurAleatoire();
    }

    private void Update()
    {
        automate.Action();
    }


}
