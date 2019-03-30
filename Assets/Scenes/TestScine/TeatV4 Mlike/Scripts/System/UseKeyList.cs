using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UseKeyList {
    public string ActionName;
    public string KeyCode;
    public bool UseUnityInput;
    public UseKeyList(string actionname, string keycode, bool useunityinput) {
        this.ActionName = actionname;
        this.KeyCode = keycode;
        this.UseUnityInput = useunityinput;
    }

}
