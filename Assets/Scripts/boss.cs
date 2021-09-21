using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{

    public GameObject blood;
   
    public float totaltime=0;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector3(-1,0,0);
        gameObject.name = "Lex";
       
        
    }

    // Update is called once per frame
    void Update()
    {

        totaltime += Time.deltaTime;

        if((totaltime>2.5) && (totaltime<3)){
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,1,0);
                    
        }
        if((totaltime>3) && (GetComponent<Transform>().position.y>2.5f)){
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,-1,0);
                    
        }
        if((totaltime>3) && (GetComponent<Transform>().position.y<-2.5f)){
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,1,0);
                    
        }
        
        
    }

     void OnTriggerStay2D(Collider2D other){
        if((other.gameObject.name == "eyebeam") && (herocontrol.eyebeamsactive == "y"))
        {
       
           Instantiate(blood, gameObject.transform.position, Quaternion.identity);    
           Destroy(gameObject);
           
           
          
    }
}
     
}
