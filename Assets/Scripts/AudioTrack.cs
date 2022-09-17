using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrack : MonoBehaviour
{

    public FMODUnity.EventReference audioTrackEvent;
    public FMOD.Studio.EventInstance audioTrackInstance;
    public FMOD.Studio.PARAMETER_ID ID_Fmod;
    public int ID, old_ID;


    // Start is called before the first frame update
    void Start()
    {
        old_ID = 0;
        Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        audioTrackInstance = FMODUnity.RuntimeManager.CreateInstance(audioTrackEvent);
        audioTrackInstance.start();

        FMOD.Studio.EventDescription audioTrackEventDescription;
        audioTrackInstance.getDescription(out audioTrackEventDescription);
        FMOD.Studio.PARAMETER_DESCRIPTION audioTrackParameterDescription;
        audioTrackEventDescription.getParameterDescriptionByName("ID", out audioTrackParameterDescription);
        ID_Fmod = audioTrackParameterDescription.id;
    }

    public void Stop()
    {
        audioTrackInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    
    public void MuteUnMute()
    {
        Debug.Log("TRUSDIGHSKG");
        if(ID != 0){
            old_ID = ID;
            SetInstrumentId(ID);
        }
        else{
            SetInstrumentId(old_ID);
            old_ID = 0;
        }
    }

    public void SetInstrumentId(int id)
    { 
        if (ID == id)
        {
            ID = 0;
            audioTrackInstance.setParameterByID(ID_Fmod, ID);
            return;
        }

        ID = id;
        audioTrackInstance.setParameterByID(ID_Fmod, ID);
    }


}
