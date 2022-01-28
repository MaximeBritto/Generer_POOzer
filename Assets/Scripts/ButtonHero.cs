using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHero : MonoBehaviour
{
    public Sprite[] _mSprite;
    public Image[] images;
    public int nbImage = 0;
    public Invocable[] Inventaire ;
    public Text[] text;
    public void generatehero()
    {
        Ptitreset();
        System.Random rnd = new System.Random();
        int aupif = rnd.Next(0, 11);
        Character temp;
        if (aupif < 5) { 
        
            temp = new Hero();
            
        }
        else
        {
            temp = new Vilain();
        }
        System.Random rnd2 = new System.Random();
        int aupif2 = rnd.Next(0, 6);
        temp._mSprite = _mSprite[aupif2];
        Inventaire[nbImage] = temp;
        images[nbImage].sprite = temp._mSprite;
        images[nbImage].enabled = true;
        text[nbImage].text = temp.ToString();
        nbImage++;
    }
   
    public void generateEquipement()
    {
        Ptitreset();
        System.Random rnd = new System.Random();
        int aupif = rnd.Next(0, 5);
        Equipement temp = null;
        switch (aupif)
        {
            case 1:
                temp = new EquipementOff("Epée");
                temp._mSprite = _mSprite[0];
                break;
            case 2:
                temp = new EquipementOff("Hache");
                temp._mSprite = _mSprite[1];
                break;
            case 3:
                temp = new EquipementOff("Kama");
                temp._mSprite = _mSprite[2];
                break;
            case 4:
                temp = new EquipementDef("Bouclier");
                temp._mSprite = _mSprite[3];
                break;

        }
        Inventaire[nbImage] = temp;
        images[nbImage].sprite = temp._mSprite;
        images[nbImage].enabled = true;
        text[nbImage].text = temp.ToString();
        nbImage++;
    }

    public void Ptitreset()
    {
        if (nbImage > 5)
        {
            for (int i = 0; i <= 5; i++)
            {
                images[i].enabled = false;
                text[i].text = "";

            }
            nbImage = 0;
        }
    }
}

