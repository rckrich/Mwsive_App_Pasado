using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MwsiveControllerButtons : MonoBehaviour
{
    public SurfManager Surf;
    public float AnimationDuration;
    public void OnClickOlaButton(){
        
        GameObject Instance = Surf.GetCurrentPrefab();
        Instance.GetComponentInChildren<MwsiveButton>().OnClickOlaButton(AnimationDuration);
        Debug.Log(Instance);
    }
    public void OnClickAñadirButton(){
        GameObject Instance = Surf.GetCurrentPrefab();
        Instance.GetComponentInChildren<MwsiveButton>().OnClickAñadirButton(AnimationDuration);
    }
    public void OnClickCompartirButton(){
        GameObject Instance = Surf.GetCurrentPrefab();
        Instance.GetComponentInChildren<MwsiveButton>().OnClickCompartirButton(AnimationDuration);
    }
}
