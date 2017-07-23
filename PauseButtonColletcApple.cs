using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonColletcApple : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("CollectAppels");
    }
    public void BackOnMainMenuPlease()
    {
        SceneManager.LoadScene("Menu");
    }
}