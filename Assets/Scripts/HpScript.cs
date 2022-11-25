using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpScript : MonoBehaviour
{
    public Slider hpSlider;
    
    public void SetValue(float hpValue)
    {
        hpSlider.value = hpValue;
    }
}
