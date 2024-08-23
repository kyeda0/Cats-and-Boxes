using UnityEngine;

public class Music : MonoBehaviour
{
    private  AudioSource _audio;
    private  float _musicVol = 0.5f;
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        _audio.volume = _musicVol;   
    }

    public void SetVol(float vol)
    {
        _musicVol = vol;
    }
}
