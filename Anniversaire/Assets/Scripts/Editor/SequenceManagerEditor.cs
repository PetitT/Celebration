using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SequenceManager))]
public class SequenceManagerEditor : Editor
{
    SequenceManager sequenceManager;
    public override void OnInspectorGUI()
    {
        sequenceManager = (SequenceManager)target;
        base.OnInspectorGUI();

        //if (GUILayout.Button("Write"))
        //{
        // //   sequenceManager.Write();
        //}
    }
}
