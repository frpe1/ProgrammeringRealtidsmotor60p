using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundExample : MonoBehaviour
{
    [SerializeField]
    private AudioClip clickAudio; 

    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            _audioSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            _audioSource.Stop();
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            ShortAudioClip();
        }
    }

    private void ShortAudioClip() {
        _audioSource.PlayOneShot(clickAudio);
    }
}
