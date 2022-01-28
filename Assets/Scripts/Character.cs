using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class Character: MonoBehaviour

	{
		protected String _name;
		protected Stat myStat;
		private  String[] _listeNom = new string[] { "Jean-Eude", "Jean-Michel", "Jean Nemar", "Ge pludidé","Os Cours","Ale Led" };
	


	public Character()
    {
        System.Random rnd = new System.Random();
		int aupif = rnd.Next(0, 6);

		this._name = _listeNom[aupif];
		this.myStat = new Stat(1,2,3);
    }

		public virtual void ToString()
		{
		Debug.Log("Je suis :" + this._name + " mes stats sont pour l'attaque :  " + this.myStat.Power + " pour la defense :" + this.myStat.Armor + " et de niveau :" + this.myStat.niveau);
		}
}

