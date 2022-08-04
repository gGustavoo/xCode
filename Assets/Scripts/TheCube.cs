using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TheCube : Botao
{
    public override void OnTouch()
    {
        base.OnTouch();
        StartCoroutine(SendData("true"));
    }

    public override void OnTouchLeave()
    {
        base.OnTouchLeave();
        StartCoroutine(SendData("false"));
    }

    [ContextMenu("send test")]
    void Test(){
        AddressText.Instance.text = "192.168.1.104";
        StartCoroutine(SendData("true"));
    }

    IEnumerator SendData(string value){
        WWWForm form = new WWWForm();
        form.AddField("value", value);
        UnityWebRequest www = new UnityWebRequest();
        www.url = $"http://{AddressText.Instance.text}:4455/toque"; // PostUri is a string containing the url
        www.method = "POST";
        www.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes($"{{\"value\":\"{value}\"}}")); // postData is Json file as a string
        www.downloadHandler = new DownloadHandlerBuffer();
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();
    }
}
