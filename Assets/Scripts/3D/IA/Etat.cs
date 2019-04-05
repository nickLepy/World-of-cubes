using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Représente un état
/// </summary>
[Serializable]
public abstract class Etat
{
    /// <summary>
    /// L'automate qui possède cet état
    /// On peut y récupérer pas mal d'info comme la cible en cours, l'objet associé à cet automate, le récepteur d'évenements
    /// </summary>
    [SerializeField]
    protected Automate automate;

    /// <summary>
    /// Créé un état
    /// </summary>
    /// <param name="automate">Automate qui possèdera cet état</param>
    public Etat(Automate automate)
    {
        this.automate = automate;
    }

    /// <summary>
    /// Etat suivant l'état actuel (peut évidemment être le même que l'état actuel si aucun évenement particulier est arrivé
    /// Appelée toutes les frames du jeu
    /// </summary>
    /// <returns>Le nouvel état</returns>
    public abstract Etat Suivant();

    /// <summary>
    /// Réalise l'action liée à cet état du jeu (tirer sur l'ennemi, suivre un objet, ...)
    /// Appelée toutes les frames du jeu
    /// </summary>
    public abstract void Action();
}