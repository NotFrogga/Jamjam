using UnityEngine;


public enum InstrumentType
{
    MELODY,
    DRUMS,
    BASS,
    INSTRUMENTNUMBER,
}

[CreateAssetMenu(menuName = "Instruments")]
public class Track : ScriptableObject
{
    [SerializeField] private int _trackId = 0;
    [SerializeField] private Sprite _sprite = null;
    [SerializeField] private InstrumentType _instrumentType;

    public int TrackId => _trackId;
    public Sprite Sprite => _sprite;

    public InstrumentType InstrumentType => _instrumentType;
}