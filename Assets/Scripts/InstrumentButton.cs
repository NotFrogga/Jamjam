using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentButton : MonoBehaviour
{
    [SerializeField] private Instrument _instrument;
    [SerializeField] private Button _button;
    [SerializeField] public GameObject _selectedGO;
    
    [SerializeField] public bool _unlocked = true;

    [SerializeField] public Image _instrumentImage;
    MusicUI _musicUI;

    private void ButtonBehavior()
    {
        muteUnmute(true);
        _musicUI.PlayInstrument(_instrument);
        SetActiveInstrumentButton();
    }

    public void muteUnmute(bool active){
        _selectedGO.SetActive(active);
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

    private void instrumentUnlockedCheck()
    {
        this._button.GetComponent<Button>().interactable = _unlocked;
        if (_unlocked)
        {
        
        }
        
    }

    private void Start()
    {
        _musicUI = FindObjectOfType<MusicUI>();
        _button.onClick.AddListener(ButtonBehavior);
        _button.GetComponent<Image>().sprite = _instrument._sprite;
        instrumentUnlockedCheck();
    }

    private void Update(){

        instrumentUnlockedCheck();
    }

}
