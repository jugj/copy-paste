using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lebensanzeige : MonoBehaviour
{
public Slider slider;

public void SetzeMaxLeben(int Leben){
    slider.maxValue = Leben;
    slider.value = Leben;
}
  public void setzeLeben(int Leben){
    
    slider.value = Leben;}

}
