using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SampleWindow : EditorWindow {

    public string[] StrArray = { "One", "Two", "Three", "Four" };
    public int SelectChoice = 0;
    public string s1 = "";
    public float f1, f2, f3, f4;
    public bool myBool = false;

    public Texture mytexture;
    public GUISkin mySkin;

    [MenuItem("Custom Tools/Sample Window")]
    static void DisplayWindow()
    {
        GetWindow<SampleWindow>(true);
    }

    void OnEnable()
    {
        mytexture = (Texture) EditorGUIUtility.Load("Blur.jpg");
        mySkin = (GUISkin)EditorGUIUtility.Load("Skin 1.guiskin");
    }

    void OnGUI()
    {
        //draws the texture background
        GUI.skin = mySkin;
        GUI.DrawTexture(new Rect(0, 0, position.width, position.height), mytexture);

        //draws a label
        GUILayout.Space(10);
        GUILayout.Label(s1);
        GUILayout.Space(10);
        //fills in the label
        s1 = GUILayout.TextField(s1);
        GUILayout.Space(10);
        //slider for the choice
        SelectChoice = EditorGUILayout.IntSlider(SelectChoice, 0, 10);
        GUILayout.Space(10);
        f1 = EditorGUILayout.FloatField(f1, mySkin.GetStyle("textfield"));
        GUILayout.Space(10);
        if(GUILayout.Button("Button"))
        {
            myBool = !myBool;
        }
        GUILayout.Space(10);
        myBool = EditorGUILayout.Toggle(myBool, mySkin.GetStyle("checkbox"));
    }
}
