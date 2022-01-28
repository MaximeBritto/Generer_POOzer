using System;
using System.Collections.Generic;
using System.Text;


public class EquipementDef : Equipement
{
		StatEquipementDef stat;
		String Nom;

		public EquipementDef(string nom)
		{
			this.stat = new StatEquipementDef(5, 5);
			this.Nom = nom;
		}
		public override String ToString()
		{

			return "C'est un " + this.Nom + " Stat : armor : " + stat.armure + " durabilité : " + stat.durabilité;
		}
}

