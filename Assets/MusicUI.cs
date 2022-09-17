using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicUI : MonoBehaviour
{
    [SerializeField] public AudioTrack _melodyTrack;
    [SerializeField] public AudioTrack _drumsTrack;
    [SerializeField] public AudioTrack _bassTrack;

    [SerializeField] public Button _tabMelodyButton;
    [SerializeField] public Button _tabBatteryButton;
    [SerializeField] public Button _tabBassButton;

    [SerializeField] public static GameObject _selectedTabGO;

    [SerializeField] private GameObject _tabMelodyGO;
    [SerializeField] private GameObject _tabBatteryGO;
    [SerializeField] private GameObject _tabBassGO;

    [SerializeField] private GameManager _gameManager;

    private void Awake()
    {
        _tabMelodyGO.SetActive(true);
        _tabBatteryGO.SetActive(false);
        _tabBassGO.SetActive(false);

        _selectedTabGO = _tabMelodyGO;
    }
    // Start is called before the first frame update
    void Start()
    {
        _tabMelodyButton.onClick.AddListener(SetTabActiveMelody);
        _tabBatteryButton.onClick.AddListener(SetTabActiveBattery);
        _tabBassButton.onClick.AddListener(SetTabActiveBass);
    }

    private void SetTabActiveMelody()
    {
        _selectedTabGO.gameObject.SetActive(false);
        _tabMelodyGO.SetActive(true);
        _selectedTabGO = _tabMelodyGO;
    }

    private void SetTabActiveBattery()
    {
        _selectedTabGO.gameObject.SetActive(false);
        _tabBatteryGO.SetActive(true);
        _selectedTabGO = _tabBatteryGO;
    }

    private void SetTabActiveBass()
    {
        _selectedTabGO.gameObject.SetActive(false);
        _tabBassGO.SetActive(true);
        _selectedTabGO = _tabBassGO;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayInstrument(Instrument instrument)
    {
        _gameManager.SetInstrument(instrument);
    }

    public void unlockInstrument(int pallier)
    {
        
    }
}
