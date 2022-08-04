using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class KeyInputButton : KeyButton
{
    public override void OnTouch()
    {
        base.OnTouch();
        AddressText.Instance.text += value;
    }
}
