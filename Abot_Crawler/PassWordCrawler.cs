using System;
using System.Text;

namespace Abot_Crawler
{
	public class PassWordCrawler
	{
		int passwordCount = 10;
		int passwordLimit = 0;
		public PassWordCrawler ()
		{
			passwordCount = 10;
			passwordLimit = Math.Pow(62,passwordCount);
		}

		public void Patch(System.Action OnPatchSuccessed,System.Action OnPatchFailed)
		{
			
		}

		private bool SinglePatch(string passwordToTry)
		{
			
		}
	}

	//public class CountWrapper_10_to_62
	//{
	//	private readonly static string dictionary = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
	//	int countLimit = 15;
	//	StringBuilder wrappedResultSB = null;
	//	public CountWrapper_10_to_62(int countlimit)
	//	{
	//		countLimit = countlimit;
	//		wrappedResultSB = new StringBuilder("",countLimit);
	//	}

	//	public string Wrap_10_to_62(uint dexNum)
	//	{
	//		wrappedResultSB.Clear ();
	//		int dividingResult = dexNum / 62;
	//		int remainder = dexNum % 62;

	//		wrappedResultSB.Insert (0,GetFromDict (remainder));

	//		while (dividingResult > 0) 
	//		{
	//			//update value
	//			remainder = dividingResult % 62;
	//			dividingResult /= 62;

	//			wrappedResultSB.Insert (0,GetFromDict (remainder));
	//		}

	//		return wrappedResultSB.ToString ();
	//	}

	//	private string GetFromDict(int dnum)
	//	{
	//		if(dnum < dictionary.Length)
	//			return dictionary[dnum];

	//		return "!";			
	//	}
	//}

//	public class CountWrapper_10_to_94
//	{
//		public CountWrapper_10_to_94()
//		{
//
//		}
//
//		private readonly static string dictionary = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//	}
}

