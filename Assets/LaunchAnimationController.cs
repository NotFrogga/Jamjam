using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchAnimationController : MonoBehaviour
{
    public AudioTrack _audioTrack1;
    public AudioTrack _audioTrack2;
    public AudioTrack _audioTrack3;
    Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_audioTrack1 != null && _audioTrack2 != null && _audioTrack3 != null)
        {
            if (_audioTrack1.ID + _audioTrack2.ID + _audioTrack3.ID == 0)
            {
                _animator.speed = 0;
            }
            else
            {
                _animator.speed = 1;
            }
        }

    }


}
