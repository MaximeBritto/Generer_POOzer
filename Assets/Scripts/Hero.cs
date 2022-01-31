using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class Hero : Character
{
	public Reussite reussite;



			public Hero(String Name, Sprite spr)
			{
				this._name = Name;
				this.reussite = new Reussite();
				this._mSprite = spr;
			
			}
			public override String ToString()
			{
				return "Je suis :" + this._name + " mes stats sont pour l'attaque :  " + this.myStat.Power + " pour la defense :" + this.myStat.Armor + " et de niveau :" + this.myStat.niveau + "Et je suis gentil "+ " ma reussite c'est " + this.reussite.reu;

			}
}

