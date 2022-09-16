using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentButton : MonoBehaviour
{
    [SerializeField] private Track _track;
    [SerializeField] private Button _button;


    private void ButtonBehavior()
    {
        Debug.Log("Track ID : " + _track.TrackId);
    }

    private void Start()
    {
        _button.onClick.AddListener(ButtonBehavior);
    }
}
