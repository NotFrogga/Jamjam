using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicUI : MonoBehaviour
{
    [SerializeField] public AudioTrack _melodyTrack;
    [SerializeField] public AudioTrack _drumsTrack;
    [SerializeField] public AudioTrack _bassTrack;

    public InstrumentButton _activeMelodyButton;
    public InstrumentButton _activeDrumsButton;
    public InstrumentButton _activeBassButton;

    public GameObject _activeMelodyVinylImage = null;
    public GameObject _activeDrumsVinylImage = null;
    public GameObject _activeBassVinylImage = null;

    [SerializeField] private GameManager _gameManager;

    public void PlayInstrument(Instrument instrument)
    {
        switch (instrument.InstrumentType)
        {
            case InstrumentType.MELODY:
                if (_activeMelodyButton != null)
                    _activeMelodyButton._selectedGO.SetActive(false);
                _activeMelodyVinylImage.GetComponent<Image>().sprite = instrument._sprite;
                //_melodyTrack.SetInstrumentId(instrument.InstrumentId);
                break;
            case InstrumentType.DRUMS:
                if (_activeDrumsButton != null)
                    _activeDrumsButton._selectedGO.SetActive(false);
                _activeDrumsVinylImage.GetComponent<Image>().sprite = instrument._sprite;
                //_drumsTrack.SetInstrumentId(instrument.InstrumentId);
                break;
            case InstrumentType.BASS:
                if (_activeBassButton != null)
                    _activeBassButton._selectedGO.SetActive(false);
                _activeBassVinylImage.GetComponent<Image>().sprite = instrument._sprite;
                //_bassTrack.SetInstrumentId(instrument.InstrumentId);
                break;
            default:
                break;
        }
        _gameManager.SetInstrument(instrument);
    }
    public void unlockInstrument(int pallier)
    {

    }
}
