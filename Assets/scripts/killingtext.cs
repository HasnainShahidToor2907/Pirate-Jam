using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class killingtext : MonoBehaviour
{
    public float timetodestroy = 2f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = SceneManager.GetActiveScene().name;
       // Destroy(this.gameObject, timetodestroy);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, timetodestroy);
    }
}
