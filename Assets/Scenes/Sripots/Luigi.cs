using UnityEngine;

public class Luigi : MonoBehaviour
{

    public Sprite Pogo;
    public SpriteRenderer SR;
    
    void Start()
    {
        
        SR = GetComponent<SpriteRenderer>();
        
    }
    private void Awake()
    {
        God.Luigi = this;


    }
    public void Keydone()
    {
        SR.sprite = Pogo;
        
            
    }
    void Update()
    {
        
    }
}