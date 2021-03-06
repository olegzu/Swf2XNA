/* Copyright (C) 2008 Robin Debreuil -- Released under the BSD License */

using System;
using System.Collections.Generic;
using System.Text;

namespace DDW.Vex
{
	public abstract class StrokeStyle : IVexObject, IComparable
	{
		public abstract int CompareTo(Object o);
	}
}
