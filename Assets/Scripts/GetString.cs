using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GetString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loop());
    }

    IEnumerator Loop(){
        yield return new WaitForSeconds(1f);
        StartCoroutine(GetValue());
        StartCoroutine(Loop());
    }
    
    IEnumerator GetValue(){
        using (UnityWebRequest www = UnityWebRequest.Get($"http://192.168.182.213:4455/heart"))
        {

            yield return www.SendWebRequest();
            Debug.Log("entrou");
            Debug.Log(www.downloadHandler.text);


            HeartText.Instance.text = www.downloadHandler.text;
        }
    }

}
