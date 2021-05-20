using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    // adjust music volume
    // adjust effects volume
    // assign the dropdown chosen music to currentMusic

    [SerializeField] AudioSource clickClip;
    [SerializeField] AudioSource hoverClip;
    [SerializeField] AudioSource unhoverClip;
    [SerializeField] AudioSource[] music;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider effectsSlider;

    public float EffectsVolSlider { get; set; }
    public float MusicVolSlider { get; set; }
    private int currentMusicIndex;

    private void Start()
    {
        EffectsVolSlider = effectsSlider.value;
        MusicVolSlider = musicSlider.value;

        AdjustMusicVolume();
        AdjustEffectsVolume();
        music[currentMusicIndex].Play();
    }

    public void AdjustMusicVolume()
    {
        music[currentMusicIndex].volume = MusicVolSlider;
    }    

    public void AdjustEffectsVolume()
    {
        clickClip.volume = EffectsVolSlider;
        hoverClip.volume = EffectsVolSlider;
        unhoverClip.volume = EffectsVolSlider;
    }

    public void PlayClick()
    {
        if (clickClip)
            clickClip.Play();
    }

    public void PlayHover()
    {
        if (hoverClip)
            hoverClip.Play();
    }

    public void PlayUnhover()
    {
        if (unhoverClip)
            unhoverClip.Play();
    }

    public void ChangeMusic(int newMusicIndex) // learn dropdown using
    {
        music[currentMusicIndex].Stop();
        currentMusicIndex = newMusicIndex;

        music[currentMusicIndex].Play();
        AdjustMusicVolume();
    }

    //private static readonly string FirstPlay = "FirstPlay";
    //private static readonly string MusicVolume = "MusicVolume";
    //private static readonly string EffectsVolume = "EffectsVolume";
    //private int firstPlayInt;

    //[SerializeField] Slider musicSlider, effectsSlider;

    //void Start()
    //{
    //    firstPlayInt = PlayerPrefs.GetInt(FirstPlay); // by default is equal to zero


    //    if (firstPlayInt == 0) // load default values at first start
    //    {
    //        defaultMusicVolume = MusicVolSlider;
    //        defaultEffectsVolume = EffectsVolSlider;

    //        PlayerPrefs.SetFloat(MusicVolume, defaultMusicVolume);
    //        PlayerPrefs.SetFloat(EffectsVolume, defaultEffectsVolume);
    //        PlayerPrefs.SetInt(FirstPlay, -1);

    //    }
    //    else // and saved - from second
    //    {
    //        defaultMusicVolume = PlayerPrefs.GetFloat(MusicVolume);
    //        musicSlider.value = defaultMusicVolume;

    //        defaultEffectsVolume = PlayerPrefs.GetFloat(EffectsVolume);
    //        effectsSlider.value = defaultEffectsVolume;
    //    }
    //}

    //public void SaveSoundSettings()
    //{
    //    PlayerPrefs.SetFloat(MusicVolume, musicSlider.value);
    //    PlayerPrefs.SetFloat(EffectsVolume, effectsSlider.value);
    //}

    //void OnApplicationFocus(bool inFocus)
    //{
    //    if (!inFocus)
    //    {
    //        SaveSoundSettings();
    //    }
    //}


}
