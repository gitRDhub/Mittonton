using UnityEngine;
using System.Collections;

public class SetVolumes : MonoBehaviour
{

    [SerializeField]
    UnityEngine.Audio.AudioMixer mixer;

    public float BGMVolume
    {
        set { mixer.SetFloat("BGM", value); }
    }
    public float SEVolume
    {
        set { mixer.SetFloat("SE", value); }
    }
}