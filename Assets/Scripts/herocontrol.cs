using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herocontrol : MonoBehaviour
{

    public KeyCode flyup;
    public KeyCode flydown;
    public KeyCode attack1;

    public float totaltime = 0;
    public static string eyebeamsactive = "n";
    public Transform eyebeams;

    public static string GO = "n";

    public GameObject gameOverText, restartButton;




    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(flyup))
           GetComponent<Rigidbody2D>().velocity = new Vector3(0,4,0);

        if(Input.GetKeyDown(flydown))
           GetComponent<Rigidbody2D>().velocity = new Vector3(0,-4,0);

        if((!Input.GetKey(flydown)) && (!Input.GetKey(flyup)))
           GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);

           if(Input.GetKeyDown(attack1)){

           herocontrol.eyebeamsactive = "y";
           eyebeams.GetComponent<SpriteRenderer>().color = new Color (1,1,1,1);

        }

      if(herocontrol.eyebeamsactive == "y")
      totaltime += Time.deltaTime;

      if(totaltime > .15){
         totaltime =0;
         herocontrol.eyebeamsactive = "n";
         eyebeams.GetComponent<SpriteRenderer>().color = new Color (1,1,1,0);
      }

        
    }

    void OnCollisionEnter2D(Collision2D col){
      if(col.gameObject.tag.Equals("Enemy")){
         gameOverText.SetActive(true);
         restartButton.SetActive(true);
         gameObject.SetActive(false);
         GO = "y";
      }

    }
}
