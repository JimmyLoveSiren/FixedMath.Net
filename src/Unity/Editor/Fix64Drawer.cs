#if UNITY_5_3_OR_NEWER
namespace FixMath.NET
{
	using System;
	using UnityEditor;
	using UnityEngine;

	[CustomPropertyDrawer(typeof(Fix64))]
	public sealed class Fix64Drawer : PropertyDrawer
	{
		const double Max = 2147483647.99999;
		const double Scale = 1e5;

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			label = EditorGUI.BeginProperty(position, label, property);
			property = property.FindPropertyRelative("m_rawValue");
			double value = (double) Fix64.FromRaw(property.longValue);
			bool changed = false;
			if (value > Max)
			{
				value = Max;
				changed = true;
			}

			value = Math.Round(value * Scale) / Scale;
			EditorGUI.BeginChangeCheck();
			value = EditorGUI.DoubleField(position, label, value);
			if (EditorGUI.EndChangeCheck()) changed = true;
			if (value > Max)
			{
				value = Max;
				changed = true;
			}

			if (changed) property.longValue = ((Fix64) value).RawValue;
			EditorGUI.EndProperty();
		}
	}
}
#endif