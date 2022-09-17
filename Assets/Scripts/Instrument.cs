using UnityEngine;
using UnityEngine.Serialization;

public enum InstrumentType
{
    MELODY,
    DRUMS,
    BASS,
    EMPTY,
}

public enum InstrumentFamily
{
    Chill, Cute, Trance, Dance, XCX, Metal, Hyper, Palo, Chris, EmptyBass, EmptyDrums, EmptyMelody
}

[CreateAssetMenu(menuName = "Instruments")]
public class Instrument : ScriptableObject
{
    [SerializeField] private int _instrumentId = 0;
    [SerializeField] public Sprite _sprite = null;
    [SerializeField] private InstrumentType _instrumentType;
    [SerializeField] private InstrumentFamily _instrumentFamily;

    public int InstrumentId => _instrumentId;
    public InstrumentFamily InstrumentFamily => _instrumentFamily;
    public Sprite Sprite => _sprite;

    public InstrumentType InstrumentType => _instrumentType;
}