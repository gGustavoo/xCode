using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class Botao : MonoBehaviour
{
    [SerializeField] Renderer r;
    [SerializeField] Material untouched, touched;
    PokeInteractable poke;
    // Start is called before the first frame update
    public virtual void Start()
    {
        poke = GetComponent<PokeInteractable>();
        poke.WhenStateChanged += state => {
            if(state.NewState == InteractableState.Select){
                OnTouch();
            }else if(state.NewState == InteractableState.Normal){
                OnTouchLeave();
            }
        };
    }

    public virtual void OnTouch(){
        r.material = touched;
    }

    public virtual void OnTouchLeave(){
        r.material = untouched;
    }
}
