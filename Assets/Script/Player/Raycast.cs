using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    
    [SerializeField] float distancehit = 1.0f;
    [SerializeField] Animator anim;
    public bool hasKey=false;
    void Update()
    {
        RaycastHit hit;
        
      
        if (Physics.Raycast(transform.position, transform.forward, out hit, distancehit) && hit.collider.gameObject.tag =="Copie" || hit.collider.gameObject.tag =="Clé" || hit.collider.gameObject.tag =="Porte" )
        {
            
           
            if (hit.collider.gameObject.tag =="Clé" && Input.GetKey("e")) 
            {
                hasKey=true;
                Destroy(hit.collider.gameObject);
            }
            if (Input.GetKey("e") && hit.collider.gameObject.tag =="Porte" && hasKey==true )
            {
                Debug.Log("lol");
                anim.SetBool("bouge",true);
                hasKey=false;

                
            }
        }
    }
}
