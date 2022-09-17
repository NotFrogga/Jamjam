using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    [SerializedField] public MusicUI _musicUI;
                                             
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

    void Update()
    {
        score += deltaScore * Time.DeltaTime;
    }
}
