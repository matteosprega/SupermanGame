using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class beamattack : MonoBehaviour
{

    public Transform burst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
        if((other.name == "kryptonite(Clone)") && (herocontrol.eyebeamsactive == "y")){
            
            Instantiate(burst, other.transform.position, burst.rotation);

            Destroy (other.gameObject);
    }
    
    }
}
