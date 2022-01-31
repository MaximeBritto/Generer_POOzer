using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Vilain : Character
{
		
		public Crime cri;

		public Vilain(String nom, Sprite spr)
		{
			this._name = nom;
			this.cri = new Crime();
			this._mSprite = spr;

		}
		public override String ToString()
		{
			return "Je suis :" + this._name + " mes stats sont pour l'attaque :  " + this.myStat.Power + " pour la defense :" + this.myStat.Armor + " et de niveau :" + this.myStat.niveau + " Et je suis MECHANT AGROUGROU" + " mon crime est :" + this.cri.Intitule;

		}
}

