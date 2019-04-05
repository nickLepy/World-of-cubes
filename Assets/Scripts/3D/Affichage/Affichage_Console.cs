using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Gère l'affichage de la console
/// (notamment les eliminations)
/// </summary>
public class Affichage_Console
{
    private List<string> messages;
    private List<float> times;

    private string messageCentral;
    private float timeMessage;

    public Affichage_Console()
    {
        messages = new List<string>();
        times = new List<float>();
        messageCentral = "";
    }

    /// <summary>
    /// Ajoute un message a afficher dans la console
    /// </summary>
    /// <param name="message">Le message à afficher</param>
    public void AjouterMessage(string message)
    {
        messages.Add(message);
        times.Add(Time.time + 5);
    }

    /// <summary>
    /// Met à jour les messages
    /// </summary>
    public void MiseAJourMessages()
    {
        int count = messages.Count;
        for(int i = 0; i<count; i++)
        {
            if(times[i] < Time.time)
            {
                messages.RemoveAt(i);
                times.RemoveAt(i);
                count--;
                i--;
            }
        }

        if (timeMessage < Time.time)
            messageCentral = "";
    }

    public List<string> ListerMessages()
    {
        return messages;
    }

    public string MessageCentral()
    {
        return messageCentral;
    }

    public void MessageCentral(string message, float temps = 1.25f)
    {
        messageCentral = message;
        timeMessage = Time.time + temps;
    }

    public void ToutEffacer()
    {
        messages.Clear();
        times.Clear();
    }
}