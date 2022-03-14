using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    
    [SerializeField] float distancehit = 1.0f;
    [SerializeField] Animator animporteD360;
    [SerializeField] Animator animporteD361;
    [SerializeField] Animator animporteD350;
    [SerializeField] Animator animporteD352;
    [SerializeField] Animator animporteSalleDesPROF;
    [SerializeField] Animator secporte1;
    [SerializeField] Animator secporte2;
    public bool hasKey=false;
    public bool securityKey=false;
    void Update()
    {
        RaycastHit hit;
        
      
        if (Physics.Raycast(transform.position, transform.forward, out hit, distancehit) || hit.transform.gameObject.tag =="Copie" || hit.transform.gameObject.tag =="Clé" || hit.transform.gameObject.tag =="Porte" )
        {
            
           
            if (hit.transform.gameObject.tag =="Clé" && Input.GetKey("e")) 
            {
                hasKey=true;
                Destroy(hit.transform.gameObject);
            }


            if (Input.GetKey("e") && hit.transform.gameObject.tag =="PorteD360" && hasKey==true )
            {
                Debug.Log("lol");
                animporteD360.SetBool("bouge",true);
                hasKey =false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "Porte361" && hasKey == true)
            {
                Debug.Log("lol");
                animporteD361.SetBool("bouge", true);
                hasKey = false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteD350" && hasKey == true)
            {
                Debug.Log("lol");
                animporteD350.SetBool("bouge", true);
                hasKey = false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteD352" && hasKey == true)
            {
                Debug.Log("lol");
                animporteD352.SetBool("bouge", true);
                hasKey = false;
            }

            if (Input.GetKey("e") && hit.transform.gameObject.tag =="PorteSecurity" && securityKey==true )
            {
                Debug.Log("lololi");
                secporte1.SetBool("bougesec",true);
                secporte2.SetBool("bougesec",true);
                securityKey=false;

                
            }
        }

    
    }
}
