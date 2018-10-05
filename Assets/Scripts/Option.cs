using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Option : MonoBehaviour
{
    public void LoadSetting()
    {
        GameObject.Find("Canvas").transform.Find("Option Panel").gameObject.SetActive(true);
    }

    public void Cancel()
    {
        GameObject.Find("Option Panel").SetActive(false);
    }

}