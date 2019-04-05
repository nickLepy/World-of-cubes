using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Colonne_Battu : MonoBehaviour
{

    private float initializationTime;
    
    // Use this for initialization
    void Start()
    {
        initializationTime = DateTime.Now.Second;
    }

    // Update is called once per frame
    void Update()
    {

        float TimeSince = DateTime.Now.Second - initializationTime;
        if (TimeSince > 1)
            Destroy(this.gameObject);
    }
}