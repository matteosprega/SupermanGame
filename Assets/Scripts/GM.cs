using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    public Transform ground;
    public Transform kryptonite;

    public float eventtimer = 0;

    public float totaltime = 0;

    public string bossspawn = "n";
    public Transform boss;

    public int randYcoor;
    public string spawnDelay = "n";


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ground,new Vector3(-4,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(4,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(12,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(20,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(28,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(36,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(44,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(52,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(60,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(68,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(76,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(84,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(92,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(100,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(108,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(116,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(124,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(132,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(140,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(148,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(156,-4,0), ground.rotation);
        Instantiate(ground,new Vector3(164,-4,0), ground.rotation);


        
    }

    // Update is called once per frame
    void Update()
    {
        eventtimer += Time.deltaTime;

        if((spawnDelay == "n")&& (totaltime<18)&&(herocontrol.GO != "y")){
        randYcoor = Random.Range(-4,5);
        Instantiate(kryptonite, new Vector3(10, randYcoor, 0), kryptonite.rotation);
        spawnDelay ="y";
        StartCoroutine (resetSpawnTimer());
       }


        totaltime += Time.deltaTime;

        /*eventtimer += Time.deltaTime;
        if((eventtimer >2) && (totaltime<18)){
            Instantiate(kryptonite,new Vector3(5,6,0), kryptonite.rotation);
            Instantiate(kryptonite,new Vector3(9,7,0), kryptonite.rotation);
            Instantiate(kryptonite,new Vector3(13,8,0), kryptonite.rotation);
            eventtimer = 0;
        }*/

        if((totaltime > 20) && (bossspawn == "n")&&(herocontrol.GO != "y")){
            bossspawn = "y";
            Instantiate(boss, new Vector3(10f,0,0),boss.rotation);

        }
        
    }

    IEnumerator resetSpawnTimer(){
        yield return new WaitForSeconds(1);
        spawnDelay = "n";
        //herocontrol.GO = "n";
    }
}
