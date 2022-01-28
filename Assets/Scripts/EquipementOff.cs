using System;
using System.Collections.Generic;
using System.Text;


public class EquipementOff : Equipement
{
		StatEquipementOff stat;
		String Nom;
		public EquipementOff(string nom)
		{
			this.stat =  new  StatEquipementOff(5,5);
			this.Nom = nom;
		}
		public override String ToString()
			{
				return "C'est un " + this.Nom + " Stat : armor : " + stat.Degat + " durabilité : " + stat.Durabilité;
			}
}

