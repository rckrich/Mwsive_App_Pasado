using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEngine.ParticleSystem;

#region Test Entities
[System.Serializable]
public class UserExample : Instanceable
{
    public string email;
    public string password;
}


[System.Serializable]
public class InstanceableExample : Instanceable
{
    public int id;
    public string name;
    public string description;
}

#endregion

#region Test Root Classes

[System.Serializable]
public class InstanceableExampleRoot
{
    public List<InstanceableExample> examples { get; set; }
}

[System.Serializable]
public class LogInExample
{
    public UserExample user { get; set; }
}

#endregion

#region Entities

[System.Serializable]
public class Instanceable { }

[System.Serializable]
public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public DateTime email_verified_at { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}

[System.Serializable]
public class Media
{
    public int id { get; set; }
    public string type { get; set; }
    public string url { get; set; }
    public object thumbnail { get; set; }
    public string absolute_url { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}

#endregion

#region Root Classes

[System.Serializable]
public class UserRoot { public User user { get; set; } }

[System.Serializable]
public class LogInRoot {
    public string access_token { get; set; }
    public string token_type { get; set; }
    public DateTime expires_at { get; set; }
    public User user { get; set; }
}

[System.Serializable]
public class ErrorMessageRoot { public string message { get; set; } }

#endregion