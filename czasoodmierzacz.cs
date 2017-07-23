using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Threading;

public class czasoodmierzacz : MonoBehaviour {

    public int timeLeft = 60;
    public Text countdownText;
    float time = 3;
    public GameObject Wynik;
   

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }
    
  
    
    

        // Update is called once per frame
        void Update()
    {
        countdownText.text = ("" + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
            Time.timeScale = 0;
            Wynik.transform.position = new Vector3(-120, -80, 0);
        }
    }

        IEnumerator LoseTime()
        {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
      
    }
 

}