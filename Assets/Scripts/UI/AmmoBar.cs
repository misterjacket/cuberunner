using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoBar : MonoBehaviour
{
    public Slider slider;
    public Text ammoText;

    public void SetAmmoText()
    {
        ammoText.text = string.Concat(slider.value, "/", slider.maxValue);
    }

    public void SetMaxAmmo(int ammo)
    {
        slider.maxValue = ammo;
        slider.value = ammo;
        
    }

    public void SetAmmo(int ammo)
    {
        slider.value = ammo;
    }
}
