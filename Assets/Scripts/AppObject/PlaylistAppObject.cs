using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaylistAppObject : AppObject
{
    // Start is called before the first frame update
    public bool enabled;
    
    public void OnSelectedPlaylistClick()
    {
        InvokeEvent<OnSelectedPlaylistClick>(new OnSelectedPlaylistClick(enabled));
        
    }
}
