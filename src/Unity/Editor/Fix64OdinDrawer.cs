#if UNITY_5_3_OR_NEWER && ODIN_INSPECTOR
namespace FixMath.NET
{
	using Sirenix.OdinInspector.Editor;
	using System;
	using UnityEditor;
	using UnityEngine;

	public sealed class Fix64OdinDrawer : OdinValueDrawer<Fix64>
	{
		const double Max = 2147483647.99999;
		const double Scale = 1e5;

		protected override void DrawPropertyLayout(GUIContent label)
		{
			double value = (double) ValueEntry.SmartValue;
			bool changed = false;
			if (value > Max)
			{
				value = Max;
				changed = true;
			}

			value = Math.Round(value * Scale) / Scale;
			EditorGUI.BeginChangeCheck();
			if (label == null) value = EditorGUILayout.DoubleField(value);
			else value = EditorGUILayout.DoubleField(label, value);
			if (EditorGUI.EndChangeCheck()) changed = true;
			if (value > Max)
			{
				value = Max;
				changed = true;
			}

			if (changed) ValueEntry.SmartValue = (Fix64) value;
		}
	}
}
#endif