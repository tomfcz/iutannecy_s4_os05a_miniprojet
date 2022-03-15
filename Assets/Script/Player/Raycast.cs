using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    
    [SerializeField] float distancehit = 1.0f;
    public Animator[] animporte;
    public bool hasKey=false;
    public int copie=0;
    void Update()
    {
        RaycastHit hit;
        
      
        if (Physics.Raycast(transform.position, transform.forward, out hit, distancehit))
        {

            //Gestion des clés

            if (Input.GetKey("e") && hit.collider.gameObject.tag == "Cle") 
            {
                Debug.Log("lol");
                hasKey=true;
                Destroy(hit.transform.gameObject);
            }
            

            if (Input.GetKey("e") && hit.transform.gameObject.tag =="PorteD360" && hasKey==true )
            {
                Debug.Log("lol");
                animporte[0].SetBool("bouge",true);
                hasKey =false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteD361" && hasKey == true)
            {
                Debug.Log("lol");
                animporte[1].SetBool("bouge", true);
                hasKey = false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteD350" && hasKey == true)
            {
                Debug.Log("lol");
                animporte[2].SetBool("bouge", true);
                hasKey = false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteD352" && hasKey == true)
            {
                Debug.Log("lol");
                animporte[3].SetBool("bouge", true);
                hasKey = false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteD353" && hasKey == true)
            {
                Debug.Log("lol");
                animporte[4].SetBool("bouge", true);
                hasKey = false;
            }
            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteSecretaire" && hasKey == true)
            {   
                Debug.Log("lol");
                animporte[5].SetBool("bouge", true);
                hasKey = false;
            }

            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteChef" && hasKey == true)
            {
                Debug.Log("lol");
                animporte[6].SetBool("bouge", true);
                hasKey = false;
            }

            if (Input.GetKey("e") && hit.transform.gameObject.tag == "PorteSecurity" && hasKey == true)
            {
                Debug.Log("lol");
                animporte[7].SetBool("bouge", true);
                hasKey = false;
            }




            //Gestion des copies

            if (Input.GetKey("e") && hit.transform.gameObject.tag == "Copie")
            {
                Debug.Log("sfggdhdfjfhdfhgs");
                copie++;

                TMP_Text truccopie = GameObject.Find("NbCopie").GetComponent<TMP_Text>();
                if ( truccopie != null)
                {
                    truccopie.text = copie.ToString();
                }
                Destroy(hit.transform.gameObject);
            }
        }

    
    }
}
