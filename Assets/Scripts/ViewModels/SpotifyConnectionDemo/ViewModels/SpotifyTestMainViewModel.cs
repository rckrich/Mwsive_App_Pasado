using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class SpotifyDemoViews
{
    public string demoViewID;
    public GameObject demoViewGameObject;
}

public class SpotifyTestMainViewModel : MonoBehaviour
{
    [Header("Token Text")]
    public TextMeshProUGUI tokenText;

    [Header("Demo Views")]
    public List<SpotifyDemoViews> demoViews = new List<SpotifyDemoViews>();

    private void Start()
    {
        SpotifyConnectionManager.instance.StartConnection(FillTokenText);
    }

    public void FillTokenText(object[] _value)
    {
        tokenText.text = (string)_value[0];
    }

    public void OnClick_ClipboardButton()
    {
        GUIUtility.systemCopyBuffer = tokenText.text;
    }

    public void OnClick_OpenSpotifyDemoViewModel(string _id)
    {
        SearchForSpotifyDemoView(_id).SetActive(true);
    }

    private GameObject SearchForSpotifyDemoView(string _id)
    {
        foreach(SpotifyDemoViews demoView in demoViews)
        {
            if (_id == demoView.demoViewID)
                return demoView.demoViewGameObject;
        }

        return null;
    }
}