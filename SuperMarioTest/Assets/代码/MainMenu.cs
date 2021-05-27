using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public GameObject myObjec;
    float Scene1Volume;
    public void Start()
    {
        myObjec = gameObject;
        myObjec.SetActive(false);
        Invoke("appear", 0.6f);
    }
    public void Update()
    {   
        
    }
    public void PlayBtnDown() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitBtnDown() {
        Application.Quit();
    }
    public void appear() {
        Debug.Log("run appear");
        myObjec.SetActive(true);
    }
    public void AudioBtnDown() {
        Debug.Log("AudioBtnDOwn");
        Scene1Volume = GameObject.Find("AudioManager").GetComponent<AudioSource>().volume;
        if (Scene1Volume == 0)
            Scene1Volume = 1;
        else
            Scene1Volume = 0;
        GameObject.Find("AudioManager").GetComponent<AudioSource>().volume = Scene1Volume;
    }
}
