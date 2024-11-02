using Microsoft.Xna.Framework;
using Nez.Splines;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nez.Math
{
	public class FourPointBezier : BezierSpline
	{

		public Vector2 P0 => _points[0];
		public Vector2 P1 => _points[1];
		public Vector2 P2 => _points[2];
		public Vector2 P3 => _points[3];

		public FourPointBezier(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) : base()
		{
			_points.Add(p0);
			_points.Add(p1);
			_points.Add(p2);
			_points.Add(p3);
		}


	}
}
