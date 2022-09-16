using UnityEngine;


public enum InstrumentType
{
    MELODY,
    DRUMS,
    BASS,
    INSTRUMENTNUMBER,
}

[CreateAssetMenu(menuName = "Instruments")]
public class Instrument : ScriptableObject
{
    [SerializeField] private int _instrumentId = 0;
    [SerializeField] private Sprite _sprite = null;
    [SerializeField] private InstrumentType _instrumentType;

    public int InstrumentId => _instrumentId;
    public Sprite Sprite => _sprite;

    public InstrumentType InstrumentType => _instrumentType;
}