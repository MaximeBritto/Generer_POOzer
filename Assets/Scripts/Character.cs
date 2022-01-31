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

	


	public Character()
    {
		this.myStat = new Stat(1,2,3);
    }

		public virtual String ToString()
		{
		return "Je suis :" + this._name + " mes stats sont pour l'attaque :  " + this.myStat.Power + " pour la defense :" + this.myStat.Armor + " et de niveau :" + this.myStat.niveau;
		}
}

