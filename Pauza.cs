using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauza : MonoBehaviour
{
    public bool paused;
    public GameObject Dechy;
    
    // Use this for initialization
    void Start()
    {
        paused = false;
    }


    // Update is called once per frame
    void Update()
    {
    
    }
    public void Pause()
    {

        paused = !paused;

        if (paused)
        {
            Time.timeScale = 0;
            Dechy.transform.position = new Vector3(-120, -80, 0);

        }
        else if (!paused)
        {
            Time.timeScale = 1;
            Dechy.transform.position = new Vector3(-1800, -150, 0);
        }
    }
}