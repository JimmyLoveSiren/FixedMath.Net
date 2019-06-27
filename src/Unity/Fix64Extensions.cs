#if UNITY_5_3_OR_NEWER
using FixMath.NET;

public static class Fix64Extensions
{
	public static float ToFloat(this Fix64 value)
	{
		return (float)value;
	}

	public static Fix64 ToFix64(this float value)
	{
		return (Fix64)value;
	}
}
#endif
