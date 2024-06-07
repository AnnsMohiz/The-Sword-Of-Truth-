using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript1 : MonoBehaviour
{
    
    public float zRange = 36.0f;
    public float zRange1 = 14.0f;
    public float xRange = 11.0f;
    public float xRange1 = -90.0f;
    private Animator anim;
    private float speed = 5.0f; 
    private float turnSpeed = 100.0f;
    
   private float horizontalInput;
    private float forwardInput;
    private AudioSource playerAudio;
    public AudioClip swordSound;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Lock Position On points Left And Right  
        if(transform.position.z >= zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,zRange);
        }
        if(transform.position.z <= zRange1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,zRange1);
        }

        //Lock Position On Points Forward And Backward 
        if (transform.position.x >= xRange)
        {
             transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        if (transform.position.x <= xRange1)
        {
             transform.position = new Vector3(xRange1,transform.position.y,transform.position.z);
        }

        //Trigger Attack Animation 
        if(Input.GetMouseButtonDown(0))
        {
             anim.SetTrigger("Attack");
             playerAudio.PlayOneShot(swordSound,1.0f);
              
        }
         
        //Movement 

         // Left & Right Movement 
        horizontalInput = Input.GetAxis("Horizontal");

        //Forward & Backward Movement 
        forwardInput = Input.GetAxis("Vertical");
       
        // Move  Forward using Vertical Input 
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        
        //transform.Translate(Vector3.right*);
        // Rotate  based on Horizontal Input 
        transform.Rotate(Vector3.up,Time.deltaTime*turnSpeed*horizontalInput);
         
        if(forwardInput == 0)
        {
             anim.SetFloat("Movement",0);
             
             
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetFloat("Movement",1);
          
        }
        else
        {
            anim.SetFloat("Movement",0.5f);
            
        }
    } 
     

        
        
   
   
    
}
