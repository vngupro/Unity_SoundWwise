using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    #region Variable
    public Slider sliderMaster;
    public Slider sliderMusic;
    public Slider sliderSFX;
    #endregion
    #region Volume
    //Set Volume Fonction
    public void SetVolumeMaster()
    {
        AkSoundEngine.SetRTPCValue("Volume_Master", sliderMaster.value);
    }
    public void SetVolumeMusic()
    {
        AkSoundEngine.SetRTPCValue("Volume_Music", sliderMusic.value);
    }
    public void SetVolumeSFX()
    {
        AkSoundEngine.SetRTPCValue("Volume_SFX", sliderSFX.value);
    }
    #endregion
    #region Music
    //General Music Function
    public void StopMusic()
    {
        AkSoundEngine.PostEvent("Stop_All", gameObject);
    }
    public void PlayMusic()
    {
        AkSoundEngine.PostEvent("Change_State", gameObject);
        AkSoundEngine.PostEvent("Play_Chill", gameObject);
    }
    //Change Tension
    public void PlayTension()
    {
        AkSoundEngine.PostEvent("Play_Tension", this.gameObject);
    }

    //Transition Function (Victory and Defeat)
    public void PlayWin()
    {
        AkSoundEngine.PostEvent("Play_Win", this.gameObject);
    }
    public void PlayLose()
    {
        AkSoundEngine.PostEvent("Play_Lose", this.gameObject);
    }
    #endregion
    #region SFX
    //SFX Function
    public void PlayRandom()
    {
        AkSoundEngine.PostEvent("Play_Random", gameObject);
    }
    public void PlayMonster()
    {
        AkSoundEngine.PostEvent("Play_Monster", gameObject);
    }
    public void PlayCartoon()
    {
        AkSoundEngine.PostEvent("Play_Cartoon", gameObject);
    }
    public void PlayVoice()
    {
        AkSoundEngine.PostEvent("Play_Voice", gameObject);
    }
    #endregion

    //Quit Function
    public void QuitApplication()
    {
        Application.Quit();
    }
}
