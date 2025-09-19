using System;
using System.Timers;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class PlayerControler : MonoBehaviour
{
    
   
    
    
    public SpriteRenderer SR;
    public Rigidbody2D RB;
    public float Speed = 30;
    public Bat BatPrefab;
    private Transform Orgin;
    public float AttackTime = 0;
    public float Max = 3;
    public float Lifetime = 1;
    public bool RKey = false;
    public bool BKey = false;
    public bool GKey = false;

    private void Awake()
    {
        God.Ness = this;


    }


    void Start()
    {
        
        SR = GetComponent<SpriteRenderer>();
        RB = GetComponent<Rigidbody2D>();
    }

    
    
    void Update()
    {
     Vector2 vel = new Vector2(0,0);
     
     if (Input.GetKey(KeyCode.W))
     {
         vel.y += Speed;
     }

     if (Input.GetKey(KeyCode.S))
     {
         vel.y -= Speed;
     }

     if (Input.GetKey(KeyCode.A))
     {
         vel.x -= Speed;
     }

     if (Input.GetKey(KeyCode.D))
     {
         vel.x += Speed;
     }
     
     RB.linearVelocity = vel;

     AttackTime -= Time.deltaTime;
    
     



     //transform.RotateAround(transform.position,Vector3.forward, Rowta * Time.deltaTime);

    }

        

    



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Evil"))
        {
            transform.position = new Vector3(-22, 164, 0);
            Destroy(other.gameObject);
        }
        

        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Lava"))
        {
            transform.position = new Vector3(-40, 50, 0);
           
        }
        
        if (other.gameObject.CompareTag("RedKey"))
        {
            var b = RKey == true;
            Destroy(other.gameObject);
        }
        
        if (other.gameObject.CompareTag("BlueKey"))
        {
            var b = BKey == true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("GreenKey"))
        {
            var b = GKey == true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("You Win");
        }
        
    }

 

}
