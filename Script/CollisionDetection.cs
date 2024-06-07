using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
   public PlayerScript1 ps;
   public GameObject HitParticle;
    


   private  void OnTriggerEnter(Collider other)
   {
     
        if(other.tag == "copzombie")
        {
            Destroy(other.gameObject);
        }
        else if(other.tag == "girlscout")
        {
            Destroy(other.gameObject);
        }
        else if(other.tag == "zombiegirl")
        {
            Destroy(other.gameObject);
        }
   }

}
