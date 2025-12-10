using System;
using TMPro;
using UnityEngine;

public class KeyQuest : MonoBehaviour
{
    public Sprite spget;
    public GameObject Player;
    public SpriteRenderer SR;
    public GameObject[] spawn;
    
    void Start()
    {
        
        SR = GetComponent<SpriteRenderer>();
        
    }
    
    public void Keydone()
    {
        SR.sprite = spget;
            
        spawn[0].SetActive(true);
    } 


    private void Awake()
    {
        God.KeyQuest = this;


    }
}