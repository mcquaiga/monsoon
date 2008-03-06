//
// ByteConverter.cs
//
// Author:
//   Jared Hendry (buchan@gmail.com)
//
// Copyright (C) 2007 Jared Hendry
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace Monsoon
{

	public static class ByteConverter
	{
		public static string Convert(double size)
		{
			return Convert(size, "{0:0.00}");
		}
		
		public static string Convert (double size, string formatting)
		{
			if(size < (1ul << 10))
				return string.Format (formatting, size) + " kB";
			if(size < (1ul << 20))
				return string.Format (formatting, (size / (double)(1ul << 10))) + " MB";
			if(size < (1ul << 30))
				return string.Format (formatting, (size / (double)(1ul << 20))) + " GB";
			return string.Format (formatting, (size / (double)(1ul << 30))) + " TB";
		}
	}
}
