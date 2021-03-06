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

namespace VimeoSharp.Simple {

	[XmlElement (ElementName="group")]
	public class Group {

		public Group ()
		{
		}

		[XmlElement (ElementName="id", 
		             ConversionType=ConversionType.Integer)]
		public int Id {
			get;
			set;
		}

		[XmlElement (ElementName="name")]
		public string Name {
			get;
			set;
		}

		[XmlElement (ElementName="description")]
		public string Description {
			get;
			set;
		}

		[XmlElement (ElementName="url")]
		public string Url {
			get;
			set;
		}

		[XmlElement (ElementName="logo")]
		public string Logo {
			get;
			set;
		}

		[XmlElement (ElementName="thumbnail")]
		public string Thumbnail {
			get;
			set;
		}

		// FIXME: Use DateTime
		[XmlElement (ElementName="created_on")]
		public string CreatedOn {
			get;
			set;
		}

		[XmlElement (ElementName="creator_id", 
		             ConversionType=ConversionType.Integer)]
		public int CreatorId {
			get;
			set;
		}

		[XmlElement (ElementName="creator_display_name")]
		public string CreatorDisplayName {
			get;
			set;
		}
		
		[XmlElement (ElementName="creator_url")]
		public string CreatorUrl {
			get;
			set;
		}

		[XmlElement (ElementName="is_mod", 
		             ConversionType=ConversionType.LiteralBoolean)]
		public bool IsMod {
			get;
			set;
		}

		[XmlElement (ElementName="is_creator", 
		             ConversionType=ConversionType.LiteralBoolean)]
		public bool IsCreator {
			get;
			set;
		}
		
		[XmlElement (ElementName="total_members",
		             ConversionType=ConversionType.Integer)]
		public int TotalMembers {
			get;
			set;
		}

		[XmlElement (ElementName="total_videos",
		             ConversionType=ConversionType.Integer)]
		public int TotalVideos {
			get;
			set;
		}

		[XmlElement (ElementName="total_files", 
		             ConversionType=ConversionType.Integer)]
		public int TotalFiles {
			get;
			set;
		}

		[XmlElement (ElementName="total_forum_topics",
		             ConversionType=ConversionType.Integer)]
		public int TotalForumTopics {
			get;
			set;
		}

		[XmlElement (ElementName="total_events",
		             ConversionType=ConversionType.Integer)]
		public int TotalEvents {
			get;
			set;
		}

		[XmlElement (ElementName="total_upcoming_events",
		             ConversionType=ConversionType.Integer)]
		public int TotalUpcomingEvents {
			get;
			set;
		}
	}
}
