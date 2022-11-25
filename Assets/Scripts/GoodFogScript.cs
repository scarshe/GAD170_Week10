using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFogScript : MonoBehaviour
{
    
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Player")
        {
            collider.gameObject.GetComponent<PlayerStats>().healing = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.name == "Player")
        {
            collider.gameObject.GetComponent<PlayerStats>().healing = false;
        }
    }
}
