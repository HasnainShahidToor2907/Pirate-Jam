using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playbuttonscript : MonoBehaviour
{
    public string nextlevelname;

    public void startgame()
    {

        SceneManager.LoadScene(nextlevelname);
    }
}