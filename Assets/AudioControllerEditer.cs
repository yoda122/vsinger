using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AudioControllerEditer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



[CustomEditor(typeof(AudioController))]
public class AudioControllerEditor : Editor {

    public override void OnInspectorGUI()
    {
        var audioController = target as AudioController;
        // -- 再生時間 --
        EditorGUILayout.LabelField( "再生時間(最小/現在時間/最大)" );
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.FloatField(0, GUILayout.Width(48) );
        audioController.audioSource.time = EditorGUILayout.Slider(audioController.audioSource.time, 0f, audioController.AudioFullLength);
        EditorGUILayout.FloatField(audioController.AudioFullLength, GUILayout.Width(48) );
        EditorGUILayout.EndHorizontal();
        // --   一時停止 --
        EditorGUILayout.LabelField( "一時停止" );
        audioController.Stop = EditorGUILayout.Toggle(audioController.Stop);
    }
}