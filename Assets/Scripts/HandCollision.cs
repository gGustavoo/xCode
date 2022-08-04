using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    [SerializeField] GameObject hand;

    private void Update() {
        transform.position = hand.transform.position;
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Button")){
            Botao button = other.GetComponent<Botao>();
            button.OnTouch();
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Button")){
            Botao button = other.GetComponent<Botao>();
            button.OnTouchLeave();
        }
    }
}
