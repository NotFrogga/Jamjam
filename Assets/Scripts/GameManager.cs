using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager: MonoBehaviour
{
    [SerializeField] public MusicUI _musicUI;
    [SerializeField] private List<double> _palliers;
    [SerializeField] private int _pallierMax;
    [SerializeField] private int _pallierIndex;
    [SerializeField] double _score;
    [SerializeField] private Appreciation _appreciation;
    
    public float bofBonus = 1;
    public float okBonus = 3;
    public float genialBonus = 10;

    [SerializeField] Instrument emptyMelody;
    [SerializeField] Instrument emptyBass;
    [SerializeField] Instrument emptyDrums;

    private Instrument currentMelody;
    private Instrument currentDrum;
    private Instrument currentBass;

    

    public enum Appreciation
    {
        DEFAULT,
        Bof,
        Ok,
        Genial
    }

    
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _appreciation = Appreciation.DEFAULT;
        _pallierIndex = 0;
        currentMelody = emptyMelody;
        currentDrum = emptyDrums;
        currentBass = emptyBass;
    }

    
    

    public void SetInstrument(Instrument instrument)
    {
        switch (instrument.InstrumentType)
        {
            case InstrumentType.MELODY:
                _musicUI._melodyTrack.SetInstrumentId(instrument.InstrumentId);
                currentMelody = instrument;
                break;
            case InstrumentType.DRUMS:
                _musicUI._drumsTrack.SetInstrumentId(instrument.InstrumentId);
                currentDrum = instrument;
                break;
            case InstrumentType.BASS:
                _musicUI._bassTrack.SetInstrumentId(instrument.InstrumentId);
                currentBass = instrument;
                break;
            default:
                break;
        }
        RefreshDeltaScore();
    }

    private void RefreshDeltaScore()
    {
        List<InstrumentFamily> instrumentFamilies = new List<InstrumentFamily>();
        
        instrumentFamilies.Add(currentBass.InstrumentFamily);
        instrumentFamilies.Add(currentDrum.InstrumentFamily);
        instrumentFamilies.Add(currentMelody.InstrumentFamily);
        var combo = instrumentFamilies.Distinct().ToList().Count;
        switch (combo)
        {
            case 3 :
                _appreciation = Appreciation.Bof;
                break;
            case 2 :
                _appreciation = Appreciation.Ok;
                break;
            case 1 :
                _appreciation = Appreciation.Genial;
                break;
            default:
                Debug.Log("NOT SUPPOSED TO HAPPEN");
                break;
        }
    }
    
    void Update()
    {
        _score += BonusPoint() * 1 * Time.deltaTime;
        RefreshUnlock();
    }

    private float BonusPoint()
    {
        switch (_appreciation)
        {
            case Appreciation.DEFAULT:
                return 0;
                break;
            case Appreciation.Bof:
                return bofBonus;
                break;
            case Appreciation.Ok:
                return okBonus;
                break;
            case Appreciation.Genial:
                return genialBonus;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void RefreshUnlock()
    {
        if ((_score > _palliers[_pallierIndex]) && (_pallierIndex < _pallierMax))
        {
            _musicUI.unlockInstrument(_pallierIndex);
            _pallierIndex++;
        }
    }
}
