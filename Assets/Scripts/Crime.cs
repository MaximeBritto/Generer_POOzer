using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class Crime
{
		String Intitule;
        String[] Listecrimes = new string[] { "Vol d'un calecon sale", "A voler une pomme", "A balayer une grand mere", "N'a rien fait mais est juste tres moche" };


    public Crime()
        {
      
            System.Random rnd = new System.Random();
            int aupif = rnd.Next(0, 6);

            this.Intitule = Listecrimes[aupif];
    }
}

