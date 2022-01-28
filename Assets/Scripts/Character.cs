using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class Character: MonoBehaviour

	{
		protected Stat myStat;


	public Character()
    {
		this.myStat = new Stat(1,2,3);
    }

		public virtual void ToString()
		{
		Debug.Log("Je suis un Personage mes stats sont pour l'attaque :  " + this.myStat.Power + " pour la defense :" + this.myStat.Armor + " et de niveau :" + this.myStat.niveau);
		}
}

