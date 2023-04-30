namespace Fauna;

public abstract class Comparable
{
	public abstract int CompareTo(object obj);
}

public static class MyTools
{
	public static void Sort(object[] array)
	{
		object temp;

		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length - (1 + i); j++)
			{
				if ((array[j] as Comparable).CompareTo(array[j + 1]) > 0)
				{
					temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;
				}
			}
		}
	}
}
