using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VinylAnimationHandler : MonoBehaviour
{
    public AudioTrack _audioTrack;
    Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_audioTrack != null && _audioTrack.ID == 0)
        {
            _animator.speed = 0;
        }
        else
        {
            _animator.speed = 1;
        }

    }


}
