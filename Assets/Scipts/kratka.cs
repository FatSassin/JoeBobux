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
    public Sprite Kolko, Krzyzyk;
    Wybrane Wybor = Wybrane.KOLKO; 
    SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        Debug.Log("Cheesus");
        sr.sprite = Krzyzyk;
        if (Wybor == Wybrane.KRZYZYK)
        {
            sr.sprite = Krzyzyk;
            Wybor = Wybrane.KOLKO;
        }
        else
        {
            sr.sprite = Kolko;
            Wybor = Wybrane.KRZYZYK;
        
        
        
        }
    
    
    
    
    
    
    
    
    
    }

    
    





}
