using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    
    [SerializeField] float distancehit = 1.0f;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        Debug.DrawRay(transform.position, transform.forward * distancehit, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hit, distancehit) && hit.transform.gameObject.tag =="Copie")
        {
            Debug.Log("Touché !");
        }
    }
}
