using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SDF_gen))]
public class SDF_gen_Editor_v2 : Editor
{
    
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SDF_gen sdfGen = (SDF_gen) target;
        if (GUILayout.Button(("Generate SDF")))
        {
            sdfGen.Generate();
        }
    }
}