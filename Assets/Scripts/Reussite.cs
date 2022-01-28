using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Reussite
{
		String reu;
        String[] Listehautfait = new string[] { "sauve un chaton", "sauve un enfant des flammes ", "sauve une  grand mere", "N'a rien fait mais est juste tres beau" };
        
        public Reussite()
        {
            System.Random rnd = new System.Random();
            int aupif = rnd.Next(0, 6);

            this.reu = Listehautfait[aupif];
    }
}   

