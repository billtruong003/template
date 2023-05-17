using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControll : MonoBehaviour
{
    public void LoadPic(string SceneName){
        switch (SceneName){
            case "pic1":
                singletonScript.picnum = 0;
                break;
            case "pic2":
                singletonScript.picnum = 1;
                break;
            case "pic3":
                singletonScript.picnum = 2;
                break;
        }
        SceneManager.LoadScene(SceneName);
    }
}
