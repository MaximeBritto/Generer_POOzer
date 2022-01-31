using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHero : MonoBehaviour
{
    public Sprite[] _mSprite;
    public Image[] images;
    public static int nbImage = 0;
    public Invocable[] Inventaire ;
    public Text[] text;
    public Character[] Perso;


    public void Start()
    {
        Perso[0] = new Hero("Saitama", _mSprite[4]);
        Perso[1] = new Vilain("Zemour", _mSprite[0]);
        Perso[2] = new Hero("Tatsumaki", _mSprite[5]);
        Perso[3] = new Vilain("Garou", _mSprite[1]);
        Perso[4] = new Hero("Genos", _mSprite[3]);
        Perso[5] = new Vilain("Lord Boros", _mSprite[2]);
    }
    public void generatehero()
    {
        Ptitreset();
        System.Random rnd = new System.Random();
        int aupif = rnd.Next(0, 6);
        Character temp;
        temp = Perso[aupif];
        System.Random rnd2 = new System.Random();
        int aupif2 = rnd.Next(0, 6);
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

