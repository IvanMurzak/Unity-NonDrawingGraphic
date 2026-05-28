using UnityEngine;
using UnityEditor;
using UnityEditor.UI;

namespace Extensions.Unity
{
    // Original reference: https://answers.unity.com/questions/1091618/ui-panel-without-image-component-as-raycast-target.html
    [CanEditMultipleObjects, CustomEditor(typeof(NonDrawingGraphic), false)]
    public class NonDrawingGraphicEditor : GraphicEditor
    {
        public override void OnInspectorGUI()
        {
            base.serializedObject.Update();
            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(base.m_Script, new GUILayoutOption[0]);
            EditorGUI.EndDisabledGroup();
            // skipping AppearanceControlsGUI
            base.RaycastControlsGUI();
            base.serializedObject.ApplyModifiedProperties();
        }
    }
}