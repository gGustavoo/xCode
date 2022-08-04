using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddressText : MonoBehaviour
{
    public static AddressText Instance;
    public string text;
    [SerializeField] TextMeshPro textMesh;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    private void Update() {
        textMesh.text = text;
    }

}
