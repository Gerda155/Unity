using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript : MonoBehaviour
{
    public GameObject beast;
    public GameObject babka;
    public GameObject mishka;
    public GameObject mashinka;

    public void showBeast(bool value)
    {
        beast.SetActive(value);
    }
    public void showBabka(bool value)
    {
        babka.SetActive(value);
    }
    public void showMishka(bool value)
    {
        mishka.SetActive(value);
    }
    public void showMashinka(bool value)
    {
        mashinka.SetActive(value);
    }
}
