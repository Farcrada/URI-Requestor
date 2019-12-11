using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace URIRequestor
{
	class URIItem
	{
		private Uri uri;
		internal Uri URI
		{
			get => uri;
			set => uri = value;
		}

		internal URIItem(Uri URI)
		{
			this.URI = URI;
		}
	}
}
