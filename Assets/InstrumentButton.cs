using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentButton : MonoBehaviour
{
    [SerializeField] private Instrument _instrument;
    [SerializeField] private Button _button;

    MusicUI _musicUI;


    private void ButtonBehavior()
    {
        _musicUI.PlayInstrument(_instrument);
    }

    private void Start()
    {
        _musicUI = FindObjectOfType<MusicUI>();
        _button.onClick.AddListener(ButtonBehavior);
    }
}
