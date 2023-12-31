using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Interactor : MonoBehaviour
{
    protected string _query;
    protected string[] parameters;
   
    protected Presenter presenter;

    public virtual void Initialize<TP>(TP _presenter) where TP : Presenter{
        this.presenter = _presenter;
    }
    public virtual void PerformSearch(params object[] _list) { }
    protected string getCompleteRequestURL(string _uri, string[] _parameters = null)
    {
        string url = _uri;
        if (_parameters != null)
        {

            for (int i = 0; i < _parameters.Length; i++)
            {
                _uri = url;
                url = "";
                url = _uri + _parameters[i] + "/";
            }

        }
        return url;
    }

    protected void tryCatchServerError(long _responseCode)
    {
        try
        {
            if (_responseCode == 429)
                throw new Exception("Response code: " + _responseCode + " . Many calls to the server.");

            if (_responseCode == 401)
                throw new Exception("Response code: " + _responseCode + " . Unauthorized.");
        }
        catch (Exception)
        {
            throw new Exception("Response code: " + _responseCode);
        }
    }
}
