#if UNITY_5_3_OR_NEWER
namespace FixMath.NET
{
	using System;
	using UnityEngine;

	[Serializable]
	partial struct Fix64
	{
		public const string FieldName = nameof(m_rawValue);

		[SerializeField] long m_rawValue;
	}
}
#endif
