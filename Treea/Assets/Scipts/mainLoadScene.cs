using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class mainLoadScene : MonoBehaviour
{
    public Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void mainButton()
    {
        if(MainCamera.transform.position.x < -30){
            SceneManager.LoadScene("Scene1");
        }else if(MainCamera.transform.position.x > 30){
            SceneManager.LoadScene("Scene2");
        }else{
            SceneManager.LoadScene("Scene3");
        }
        
    }
}
