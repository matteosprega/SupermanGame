using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        herocontrol.GO = "n";
        score.scoreValue = 0;
    }
}
