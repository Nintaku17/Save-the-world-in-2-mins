using UnityEngine;

public class Evil : MonoBehaviour
{
    public float speed = 6;
    public Rigidbody2D RB;
    public SpriteRenderer SR;
    public PlayerControler Target;

    private void Awake()
    {
        God.Evil = this;


    }
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        RB = GetComponent<Rigidbody2D>();
        
        if(Target == null) Target = God.Ness;
        
        //GameMan.AllEnemies.Add(this);

    }

    void Update()
    {
        if (Target == null) return;
        
        Vector3 offset = Target.transform.position - transform.position;
        
        RB.linearVelocity = offset.normalized * speed;
    }
    
   
    
    private void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.gameObject.CompareTag("Bat"))
        {
         
            Destroy(gameObject);
            
        }
        
       
        
    }

   
    
    
}
