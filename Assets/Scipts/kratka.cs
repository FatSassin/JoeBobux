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
    
    
    public gamemenagercheese gamemenager
    public Sprite Kolko, Krzyzyk;
    Wybrane Wybor = Wybrane.KOLKO; 
    SpriteRenderer sr;
    private void Start()
    {
        FindObjectOfType<gamemenagercheese>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        Debug.Log("Cheesus");
        sr.sprite = Krzyzyk;
     





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
