using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentButton : MonoBehaviour
{
    [SerializeField] private Instrument _instrument;
    [SerializeField] private Button _button;
    [SerializeField] public GameObject _selectedGO;

    MusicUI _musicUI;


    private void ButtonBehavior()
    {
        _selectedGO.SetActive(true);
        _musicUI.PlayInstrument(_instrument);
        SetActiveInstrumentButton();
    }

    private void SetActiveInstrumentButton()
    {
        switch (_instrument.InstrumentType)
        {
            case InstrumentType.MELODY:
                _musicUI._activeMelodyButton = this;
                break;
            case InstrumentType.DRUMS:
                _musicUI._activeDrumsButton = this;
                break;
            case InstrumentType.BASS:
                _musicUI._activeBassButton = this;
                break;
        }
    }

    private void Start()
    {
        _musicUI = FindObjectOfType<MusicUI>();
        _button.onClick.AddListener(ButtonBehavior);
    }
}
