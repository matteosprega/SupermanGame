using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kryptonite : MonoBehaviour
{

    public Transform burst;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-3,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
        if((other.gameObject.name == "eyebeam") && (herocontrol.eyebeamsactive == "y"))
        {
           Instantiate(burst, gameObject.transform.position, burst.rotation);    
           Destroy(gameObject);
           score.scoreValue += 1;
        }
    }
}
