using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
   private float speed = 1.5f;
   private float topBound = 8.0f;
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        if(transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
        
    }
}
