using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_List_Example
{
    interface IList
    {
		int Add(object value);      // methods
		
		bool Contains(object value);
		
		bool IsReadOnly { get; }		// property
		
		object this[int index] { get; set; }    // indexer

	}
}
