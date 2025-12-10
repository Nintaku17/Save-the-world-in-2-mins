using UnityEngine;

public class Mario : MonoBehaviour
{
    
    public Sprite Pog;
    public SpriteRenderer SR;
    private void Awake()
    {
        God.Mario = this;


    }
    void Start()
    {
        
        SR = GetComponent<SpriteRenderer>();
        
    }
    
    public void Keydone()
    {
        SR.sprite = Pog;
    }
    
    
    void Update()
    {
        
    }
}