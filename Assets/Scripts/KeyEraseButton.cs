using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyEraseButton : KeyButton
{
    public override void OnTouch()
    {
        base.OnTouch();
        AddressText.Instance.text = AddressText.Instance.text.Remove(AddressText.Instance.text.Length - 1, 1);
    }
}
