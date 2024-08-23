using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DemoMono_ButtonPush))]
public class DemoEditorMono_ButtonPush : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DemoMono_ButtonPush buttonPush = (DemoMono_ButtonPush)target;

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Down"))
        {
            buttonPush.PushAsButtonDown();
        }

        if (GUILayout.Button("Up"))
        {
            buttonPush.PushAsButtonUp();
        }

        if (GUILayout.Button("Click"))
        {
            buttonPush.PushAsClick();
        }
        GUILayout.EndHorizontal();
    }
}
