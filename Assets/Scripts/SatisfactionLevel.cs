using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    [SerializedField] public MusicUI _musicUI;
    [SerializedField] private double[] palliers;
                                             
    private double _score;
    private double _deltaScore;
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

    
    

    public void SetInstrument(Instrument instrument)
    {
                switch (instrument.InstrumentType)
        {
            case InstrumentType.MELODY:
                _melodyTrack.SetInstrumentId(instrument.InstrumentId);
                break;
            case InstrumentType.DRUMS:
                _drumsTrack.SetInstrumentId(instrument.InstrumentId);
                break;
            case InstrumentType.BASS:
                _bassTrack.SetInstrumentId(instrument.InstrumentId);
                break;
            case InstrumentType.INSTRUMENTNUMBER:
                break;
            default:
                break;
        }
                refreshDeltaScore();
    }
    // Update is called once per frame
    void Update()
    {
        _score += _deltaScore * Time.DeltaTime;
        refreshUnlock();
    }

    private void refreshUnlock()
    {
        
    }
}
