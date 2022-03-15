using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public static AudioClip background;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        background = Son.Load<AudioClip>("bgSound");
        audioSrc = GetComponent<AudioSource>;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
