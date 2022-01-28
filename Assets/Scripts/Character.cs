using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;



public class Character : Invocable

{
		protected String _name;
		protected Stat myStat;
		public Sprite _mSprite;

		private String[] _listeNom = new string[] { "Jean-Eude", "Jean-Michel", "Jean Nemar", "Geplu didé","Os Cours","Ale Led" };
	


	public Character()
    {
        System.Random rnd = new System.Random();
		int aupif = rnd.Next(0, 6);

		this._name = _listeNom[aupif];
		this.myStat = new Stat(1,2,3);
    }

		public virtual String ToString()
		{
		return "Je suis :" + this._name + " mes stats sont pour l'attaque :  " + this.myStat.Power + " pour la defense :" + this.myStat.Armor + " et de niveau :" + this.myStat.niveau;
		}
}

