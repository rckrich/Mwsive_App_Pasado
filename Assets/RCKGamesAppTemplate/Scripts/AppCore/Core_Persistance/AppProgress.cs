using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserDataPersistance
{
    [SerializeField] public bool userTokenSetted = false;
    [SerializeField] public string access_token = "";
    [SerializeField] public string token_type = "";
    [SerializeField] public DateTime expires_at = new DateTime(1990, 01, 01);


    public UserDataPersistance(bool _userTokenSetted, string _userToken, string _token_type, DateTime _dateTime)
    {
        this.userTokenSetted = _userTokenSetted;
        this.access_token = _userToken;
        this.token_type = _token_type;
        expires_at = _dateTime;
    }
}

[System.Serializable]
public class AppProgress
{
    [SerializeField] public UserDataPersistance userDataPersistance;
}