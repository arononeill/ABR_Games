using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource LevelMusic;
    public playerMov movement;

    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        movement.enabled = false;
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        movement.enabled = true;
        CountDown.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        movement.enabled = true;
    }


}

