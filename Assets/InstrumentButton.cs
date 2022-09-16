using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentButton : MonoBehaviour
{
    [SerializeField] private Instrument _instrument;
    [SerializeField] private Button _button;


    private void ButtonBehavior()
    {
        Debug.Log("Instrument ID : " + _instrument.InstrumentId);
    }

    private void Start()
    {
        _button.onClick.AddListener(ButtonBehavior);
    }
}
