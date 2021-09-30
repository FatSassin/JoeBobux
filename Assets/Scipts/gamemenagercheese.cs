using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemenagercheese : MonoBehaviour
{

    public Wybrane wybranygracz;
    void zmiengracza()
    {
        if (wybranygracz == Wybrane.KRZYZYK)
        {
            wybranygracz = Wybrane.KOLKO;
        }
        else 
        {
            wybranygracz = Wybrane.KRZYZYK;
        }

    }



}
 