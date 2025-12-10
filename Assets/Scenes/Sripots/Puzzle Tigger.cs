using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleTigger : MonoBehaviour
{


    public AudioClip clip;
    public AudioSource AS;
    
    
    
    
    void Start()
    {
        AS.PlayOneShot(clip);
    }

    
    
    
    
    
}