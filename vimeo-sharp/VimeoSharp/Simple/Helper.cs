// 
// VimeoSharp. Vimeo API library.
// 
// Author:
//       Mario Carrion <mario@carrion.mx>
// 
// Copyright (c) 2010 Mario Carrion
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using System.IO;

namespace VimeoSharp.Simple {

	internal static class Helper {

		/// <summary>
		/// Accepts "yes" or "no" ONLY and convers value to bool
		/// </summary>
		/// <returns>
		/// true when value is "yes", false when value is "no"
		/// </returns>
		internal static bool LiteralValueToBoolean (string @value)
		{
			return @value == "yes" ? true : false;
		}
		
		internal static XmlDocument RequestUrl (string requestUrl)
		{
			using (WebClient client = new WebClient ()) {
				string output = string.Empty;
				using (Stream stream = client.OpenRead (requestUrl)) {
					using (StreamReader reader = new StreamReader (stream)) {
						output = reader.ReadToEnd ();
					}
				}
				XmlDocument xmlDocument = new XmlDocument ();
				xmlDocument.LoadXml (output);
				return xmlDocument;
			}
		}

		internal static XDocument ConvertToXDocument (XmlDocument doc)
		{
			return XDocument.Load (new XmlNodeReader (doc));
		}

	}
}
