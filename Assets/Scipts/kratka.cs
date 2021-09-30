using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Wybrane
{
    KRZYZYK,
    KOLKO

}
public class kratka : MonoBehaviour
{


    public gamemenagercheese gamemenager;
    public Sprite Kolko, Krzyzyk;
    Wybrane Wybor = Wybrane.KOLKO; 
    SpriteRenderer sr;
    private void Start()
    {
        gamemenager = FindObjectOfType<gamemenagercheese>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        Debug.Log("Cheesus" + gamemenager.wybranygracz);

        gamemenager.zmiengracza();
        if (gamemenager.wybranygracz == Wybrane.KRZYZYK)
        {
            sr.sprite = Krzyzyk;

        }
        else 
        {
            sr.sprite = Kolko;

        }
    
    
    
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //gameObject.SetActive(false);
            sr.sprite = null;
        }

    }

}
