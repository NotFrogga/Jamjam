using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatisfactionLevel : MonoBehaviour
{
    private double _jauge;
    private double _speed;
    private double _pallier;
    private int _timer;

    // Start is called before the first frame update
    void Start()
    {
        _jauge = 0;
        _speed = 0;
        _pallier = 0;
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _jauge += _speed;
        if (_jauge > _pallier + 1)
            _pallier += 1;
        _timer++;
    }
}
