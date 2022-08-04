using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyButton : Botao
{
    [SerializeField] TextMeshPro textMesh;
    public string value;

    public virtual void Start() {
        base.Start();
        textMesh.text = value;
    }
}
