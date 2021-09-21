using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public static int scoreValue = 0;
    Text scores;

    // Start is called before the first frame update
    void Start()
    {
        scores = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scores.text = "Score: " + scoreValue;
    }
}
