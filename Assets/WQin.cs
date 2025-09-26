using UnityEngine;

public class WQin : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource AS;
    
    
    
    
    void Start()
    {
        AS.PlayOneShot(clip);
    }

 
    void Update()
    {
        
    }
}
