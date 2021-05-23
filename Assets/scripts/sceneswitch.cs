using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneswitch : MonoBehaviour
{
    public string nextlevelname;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mainship"))
        {
            SceneManager.LoadScene(nextlevelname);
        }

    }

    public void buttonaction()

    {

        


    }
}