using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicplayer : MonoBehaviour
{
    bool musicon = false;
   

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.activeSceneChanged += Changedscenes;
        if (PlayerPrefs.HasKey("music"))
        {
            if (PlayerPrefs.GetString("music") == "on")
            {
                musicon = true;
            }
            else if (PlayerPrefs.GetString("music") == "off")
            {
                musicon = false;
            }
        }
        playmusic();
    }

    // Update is called once per frame
    private void Update()
    {
       
    }
    void Changedscenes(Scene currentscene, Scene goingto)
    {

        if (goingto.name == "mainmenu")
        {
            Destroy(this.gameObject);
        }

    }





    void playmusic()  // this function will decide whether to run the music or not
    {
        if (musicon)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
    }

    public void togglemusic()
    {
        if (musicon)    // if music was running before
        {
            musicon = false;
            PlayerPrefs.SetString("music", "off");
        }
        else
        {
            musicon = true;
            PlayerPrefs.SetString("music", "on");
        }
        playmusic();
    }
}
