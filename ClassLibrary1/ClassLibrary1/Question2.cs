using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
	public class Question2Set
	{
		private Dictionary<int, int> valuesIndex;
		private List<int> values;

		public Question2Set ()
		{
			valuesIndex = new Dictionary<int, int> ();
			values = new List<int> ();
		}

		public void Insert(int value)
		{
			int newIndex = values.Count;
			values.Add (value);
			valuesIndex.Add (value, newIndex);
		}

		public void Remove(int value)
		{
			int index;
			if (valuesIndex.TryGetValue (value, out index)) {
				values.RemoveAt (index);
                valuesIndex.Remove(value);
			}

		}

		public int GetRandom()
		{
			Random generateRandom = new Random ();
			int randomNum = generateRandom.Next (0, values.Count - 1);

			return values[randomNum];
		}
        public int Count()
        {
            return values.Count;
        }
	}
}

        