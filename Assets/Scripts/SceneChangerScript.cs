using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour
{
    public void button1Click()
    {
        SceneManager.LoadScene(1);
    }
    public void button2Click()
    {
        SceneManager.LoadScene(2);
    }
    public void button3Click()
    {
        SceneManager.LoadScene(3);
    }
    public void backButtonClick()
    {
        SceneManager.LoadScene(0);
    }

}
