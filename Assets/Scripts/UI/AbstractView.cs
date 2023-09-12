using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractView : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;

    public abstract void Init();
    protected virtual void OnEnable() { }
    protected virtual void OnDisable() { }
}

