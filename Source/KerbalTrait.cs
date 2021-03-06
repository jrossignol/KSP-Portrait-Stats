﻿#region license
/*The MIT License (MIT)
Kerbal Trait - Store info on Kerbal traits and experience level

Copyright (c) 2015 DMagic

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

using Experience;
using UnityEngine;

namespace PortraitStats
{
	public class KerbalTrait
	{
		private Rect levelPos;
		private Rect traitPos;
		private Color iconColor;

		public KerbalTrait(Kerbal k)
		{
			traitPos = crewType(k.protoCrewMember.experienceTrait);
			levelPos = levelRect(k.protoCrewMember.experienceLevel);
		}

		public Rect LevelPos
		{
			get { return levelPos; }
		}

		public Rect TraitPos
		{
			get { return traitPos; }
		}

		public Color IconColor
		{
			get { return iconColor; }
		}

		private Rect crewType(ExperienceTrait t)
		{
			switch (t.Title)
			{
				case "Pilot":
					iconColor = XKCDColors.PastelRed;
					return new Rect(0, 0.796875f, 0.1875f, 0.1875f);
				case "Engineer":
					iconColor = XKCDColors.SapGreen;
					return new Rect(0.203125f, 0.796875f, 0.1875f, 0.1875f);
				case "Scientist":
					iconColor = XKCDColors.DirtyBlue;
					return new Rect(0.40625f, 0.796875f, 0.1875f, 0.1875f);
				case "Tourist":
					iconColor = XKCDColors.OrangePink;
					return new Rect(0.609375f, 0.796875f, 0.1875f, 0.1875f);
				default:
					iconColor = XKCDColors.White;
					return new Rect(0.8125f, 0.8125f, 0.1875f, 0.1875f);
			}
		}

		private Rect levelRect(int i)
		{
			return new Rect(i * 0.171875f, 0, 0.140625f, 0.75f);
		}
	}
}
