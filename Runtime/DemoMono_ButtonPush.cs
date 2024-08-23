using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DemoMono_ButtonPush : MonoBehaviour
{

    public UnityEvent<bool> m_onButtonPush;

    [ContextMenu("Push As Button Down")]
    public void PushAsButtonDown() {
        m_onButtonPush.Invoke(true);
    }

    [ContextMenu("Push As Button Up")]
    public void PushAsButtonUp() { 
        m_onButtonPush.Invoke(false);
    }

    [ContextMenu("Push As Click")]
    public void PushAsClick() {

        PushAsButtonDown();
        PushAsButtonUp();
    }
}
