using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Wybrane
{
    KRZYZYK,
    KOLKO

}
public class kratka : MonoBehaviour
{
    public Sprite kolko, krzyzyk;
    Wybrane Wybor = Wybrane.KOLKO; 
    SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        Debug.Log("Cheesus");
        sr.sprite = krzyzyk;
        if (Wybor == Wybrane.KRZYZYK)
        {
            sr.sprite = kolko;
            
        }
        else
        {
            sr.sprite = krzyzyk;
        }
    }

    
    





}
