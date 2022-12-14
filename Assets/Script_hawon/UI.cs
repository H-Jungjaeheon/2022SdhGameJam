using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject Setting_Button;
    public GameObject Setting_Window;
    public GameObject Credit_Window;

    public AudioMixer Effectmixer;      // 오디오 변수 설정
    public AudioMixer BackGroundmixer;
    public Slider Effectslider;
    public Slider BackGroundslider;

    //public AudioClip clip;

    void Start()
    {
        Screen.SetResolution(1600, 900, true);
    }

    void Update()
    {
        //SoundManager.instance.SFXPlay("",clip);
        _start();
    }

    private void _start()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void First() // 설정 초기화
    {
        Effectmixer.SetFloat("MusicVol", 5);
        BackGroundmixer.SetFloat("MusicVol", 3);
        Screen.SetResolution(1600, 900, true);
    }

    public void EffectSetLevel(float silderValue1)  // 환경음 설정
    {
        Effectmixer.SetFloat("MusicVol", Mathf.Log10(silderValue1) * 10);
    }

    public void BackGroundSetLevel(float silderValue2)  // 배경음 설정
    {
        BackGroundmixer.SetFloat("MusicVol", Mathf.Log10(silderValue2) * 10);
    }

    public void Setting()   // 설정 창 활성화
    {
        Setting_Button.gameObject.SetActive(false);
        Setting_Window.gameObject.SetActive(true);
    }

    public void Setting_Window_OK() // 메인 화면 활성화
    {
        Setting_Window.gameObject.SetActive(false);
        Setting_Button.gameObject.SetActive(true);
    }

    public void CreditOpen()    // 크레딧
    {
        Setting_Window.gameObject.SetActive(false);
        Credit_Window.gameObject.SetActive(true);
    }

    public void CreditClose()
    {
        Setting_Window.gameObject.SetActive(true);
        Credit_Window.gameObject.SetActive(false);
    }
}
