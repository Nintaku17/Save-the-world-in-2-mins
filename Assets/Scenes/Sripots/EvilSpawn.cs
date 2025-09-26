using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EvilSpawn : MonoBehaviour
{
    public Evil evilPrefab;

    public Vector3 EvilSpawnPos;
    public float EvilspawnTimer = 0;
    public float eTimerReset = 3;





    void Update()
    {

        /*

                EvilspawnTimer -= Time.deltaTime;

                if (EvilspawnTimer <= 0)
                {
                    EvilspawnTimer = eTimerReset;
                    Instantiate(evilPrefab, EvilSpawnPos, Quaternion.identity);

                }




            }
        */
    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Ness"))
        {

            EvilspawnTimer -= Time.deltaTime;

            if (EvilspawnTimer <= 0)
            {
                EvilspawnTimer = eTimerReset;
                Instantiate(evilPrefab, EvilSpawnPos, Quaternion.identity);

            }
        }
     }






}


    
    
   
    

