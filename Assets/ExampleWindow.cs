using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class ExampleWindow : EditorWindow {

    public string[] StrArray = { "One", "Two", "Three", "Four" };
    public int SelectChoice = 0;
    public string s1 = "";
    public float f1, f2, f3, f4;

    [MenuItem("Custom Tools/Example Window")]
    static void DisplayWindow()
    {
        GetWindow<ExampleWindow>();
    }

    void OnGUI()
    {
        //the position and rect of the window
        float colSize = position.width / 10;

        //top
        GUILayout.Label("Example Window");
        s1 = GUILayout.TextField(s1);

        GUILayout.Space(10);

        //sliders
        GUILayout.Label("Sliders");
        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("f1", GUILayout.MaxWidth(colSize/2f));
            f1 = GUILayout.HorizontalSlider(f1, 0, 10);
            f1 = EditorGUILayout.FloatField(f1, GUILayout.MaxWidth(colSize));
            GUILayout.Label("f3", GUILayout.MaxWidth(colSize/2f));
            f3 = GUILayout.HorizontalSlider(f3, 0, 10);
            f3 = EditorGUILayout.FloatField(f3, GUILayout.MaxWidth(colSize));
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("f2", GUILayout.MaxWidth(colSize / 2f));
            f2 = GUILayout.HorizontalSlider(f2, 0, 10);
            f2 = EditorGUILayout.FloatField(f2, GUILayout.MaxWidth(colSize));
            GUILayout.Label("f4", GUILayout.MaxWidth(colSize / 2f));
            f4 = GUILayout.HorizontalSlider(f4, 0, 10);
            f4 = EditorGUILayout.FloatField(f4, GUILayout.MaxWidth(colSize));
        }
        GUILayout.EndHorizontal();

        //selection grid across
        SelectChoice = GUILayout.SelectionGrid(SelectChoice, StrArray, 4);

        GUILayout.Space(50);
    }
}
