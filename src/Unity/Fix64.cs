#if UNITY_5_3_OR_NEWER
namespace FixMath.NET
{
	using System;
	using UnityEngine;

	[Serializable]
	partial struct Fix64
	{
		[SerializeField] long m_rawValue;

		public override string ToString()
		{
			return ((float) this).ToString();
		}

		public string ToString(IFormatProvider provider)
		{
			return ((float) this).ToString(provider);
		}

		public string ToString(string format)
		{
			return ((float) this).ToString(format);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return ((float) this).ToString(format, provider);
		}
	}
}
#endif