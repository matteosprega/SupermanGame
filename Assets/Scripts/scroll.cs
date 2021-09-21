using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float leveltimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-3,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
     leveltimer +=  Time.deltaTime;

     if(herocontrol.GO == "y")
     GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);

     if((leveltimer >10) && (leveltimer < 12)&&(herocontrol.GO != "y"))
     GetComponent<Rigidbody2D>().velocity = new Vector3(-2.5f,0,0);

     if((leveltimer >12) && (leveltimer < 14)&&(herocontrol.GO != "y"))
     GetComponent<Rigidbody2D>().velocity = new Vector3(-2,0,0);

     if((leveltimer >14) && (leveltimer < 16)&&(herocontrol.GO != "y"))
     GetComponent<Rigidbody2D>().velocity = new Vector3(-1.5f,0,0);

     if((leveltimer >16) && (leveltimer < 18)&&(herocontrol.GO != "y"))
     GetComponent<Rigidbody2D>().velocity = new Vector3(-1,0,0);


     if((leveltimer >18) && (leveltimer < 20)&&(herocontrol.GO != "y"))
     GetComponent<Rigidbody2D>().velocity = new Vector3(-0.5f,0,0);


     if(leveltimer >20)
     GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);


    }
}
