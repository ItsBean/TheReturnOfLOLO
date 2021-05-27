using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1AudioManager : MonoBehaviour
{
    public AudioClip BGM;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        BGMPlay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BGMPlay() {
        audioSource.clip = BGM;
        audioSource.Play();
    }

}
