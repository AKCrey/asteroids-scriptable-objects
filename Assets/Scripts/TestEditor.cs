using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEngine;
using UnityEngine.Serialization;

public class TestEditor : EditorWindow
{
    [SerializeField] private GameSettings gameSettings;
    [SerializeField] private Variables.FloatVariable floatVariable;
    [SerializeField] private VisualTreeAsset uxmlFile;
    [MenuItem("Tools/Settings")]
    public static void ShowMyEditor()
    {
        EditorWindow window = GetWindow<TestEditor>();
        window.titleContent = new GUIContent("Settings");
    }

    private void CreateGUI()
    {
        uxmlFile.CloneTree(rootVisualElement);
        Bind();
    }

    private void Bind()
    {
        //rootVisualElement.Bind(new SerializedObject(variables));
        var root = rootVisualElement.Q<VisualElement>("Root");
        root.Bind(new SerializedObject(gameSettings));
        var secondroot = rootVisualElement.Q<VisualElement>("SecondRoot");
        secondroot.Bind(new SerializedObject(floatVariable));
        var filipsKnapp = rootVisualElement.Q<Button>("FilipsKnapp");
        filipsKnapp.clicked += TestPrintFunction;
    }

    void TestPrintFunction()
    {
        Debug.Log("Hey Fillip");
    }
}
