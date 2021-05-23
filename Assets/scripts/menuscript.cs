using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public string nextscenename = "level1";
    
    public void startgame()
    {
        SceneManager.LoadScene(nextscenename);
    }
    
}
