using Microsoft.Xna.Framework;
using Nez.Splines;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nez.Splines
{
	public class FourPointBezier : BezierSpline
	{
		public Vector2 P0 => _points[0];
		public Vector2 P1 => _points[1];
		public Vector2 P2 => _points[2];
		public Vector2 P3 => _points[3];

		public FourPointBezier(List<Vector2> points) : this(points[0], points[1], points[2], points[3]) { }
		public FourPointBezier(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) : base()
		{
			AddCurve(p0, p1, p2, p3);
		}
		public void SetPoints(FourPointBezier fourPointBezier)
		{
			SetPoints(fourPointBezier.P0, fourPointBezier.P1, fourPointBezier.P2, fourPointBezier.P3);
		}
		public void SetPoints(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			SetControlPoint(0, p0);
			SetControlPoint(1, p1);
			SetControlPoint(2, p2);
			SetControlPoint(3, p3);
		}

	}
}
