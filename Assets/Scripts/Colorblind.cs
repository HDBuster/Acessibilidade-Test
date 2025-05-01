using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Colorblind : MonoBehaviour
{
    [SerializeField] GameObject protanopia;
    [SerializeField] GameObject deuteranopia;
    [SerializeField] GameObject tritanopia;


    public void Protanopia()
    {
        protanopia.SetActive(true);
        deuteranopia.SetActive(false);
        tritanopia.SetActive(false);
    }

    public void Deuteranopia()
    {
        protanopia.SetActive(false);
        deuteranopia.SetActive(true);
        tritanopia.SetActive(false);
    }

    public void Tritanopia()
    {
        protanopia.SetActive(false);
        deuteranopia.SetActive(false);
        tritanopia.SetActive(true);
    }
}
