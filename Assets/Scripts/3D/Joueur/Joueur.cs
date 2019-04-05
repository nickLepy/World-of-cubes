using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour {

    private float vitesse;
    /// <summary>
    /// Vitesse du joueur
    /// </summary>
    public float Vitesse { get { return vitesse; } set { vitesse = value; } }

    // Use this for initialization
    void Start () {
        Rigidbody rg = GetComponent<Rigidbody>();
        if(rg != null)
            rg.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
	}

    private void Awake()
    {
        vitesse = 20;
    }

	// Update is called once per frame
	void Update () {
        

        if (Input.GetButton("Avancer"))
        {
            this.transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * vitesse;
        }
        if (Input.GetButton("Reculer"))
        {
            this.transform.position += transform.TransformDirection(Vector3.forward) * -1 * Time.deltaTime * vitesse;
        }
        if (Input.GetButton("Gauche"))
        {
            this.transform.position += transform.TransformDirection(Vector3.right) * -1 * Time.deltaTime * vitesse;
        }
        if (Input.GetButton("Droite"))
        {
            this.transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * vitesse;
        }
        if (Input.GetButton("Rotation Droite"))
        {
            gameObject.transform.Rotate(Time.deltaTime * new Vector3(0, 1, 0) * 90);
        }
        if (Input.GetButton("Rotation Gauche"))
        {
            gameObject.transform.Rotate(Time.deltaTime * new Vector3(0, -1, 0) * 90);
        }
        if(Input.GetKey(KeyCode.A))
        {
            Camera.main.gameObject.transform.position = new Vector3(193.18f, 31.28f, 80);
        }

        //Plus de facilite : freeze la rotation X et Z du joueur
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        

        //Si le joueur est mort (ou est en chute libre , éventuellement à modifier)
        if (transform.position.y <= -30)
        {
            Mort();   
        }
        
    }

    private void Mort()
    {

        //On détache la caméra du joueur pour ne pas la détruire
        GameObject.Find("Main Camera").transform.parent = null;
        Destroy(this.gameObject);
    }

    /// <summary>
    /// Fait apparaître des particules autour du joueur
    /// </summary>
    private void Particules(String path)
    {
        GameObject impact = Resources.Load(path, typeof(GameObject)) as GameObject;
        impact = Instantiate(impact);
        impact.transform.position = transform.position;
        impact.transform.position += new Vector3(0, 1, 0);
        Destroy(impact, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Esprit"))
        {
            
        }
    }

    private bool dejaMort = false;

    private void OnGUI()
    {
        Affichage_Joueur.GUIJoueur(this);

    }

    public void SonPickup()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(Resources.Load("Sound/pickup", typeof(AudioClip)) as AudioClip);
    }
}