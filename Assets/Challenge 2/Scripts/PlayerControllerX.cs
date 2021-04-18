using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    public float clonerate = 0.1f;
    public float nextClone = 0;
    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextClone)
        {
            nextClone = Time.time + clonerate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Debug.Log("next sapce bar available in :" + nextClone );
            
        }
        
    }
}
