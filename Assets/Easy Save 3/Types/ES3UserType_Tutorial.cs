using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("isCompletedTutorial")]
	public class ES3UserType_Tutorial : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_Tutorial() : base(typeof(Core.Tutorial)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Core.Tutorial)obj;
			
			writer.WritePrivateField("isCompletedTutorial", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Core.Tutorial)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "isCompletedTutorial":
					instance = (Core.Tutorial)reader.SetPrivateField("isCompletedTutorial", reader.Read<System.Boolean>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_TutorialArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_TutorialArray() : base(typeof(Core.Tutorial[]), ES3UserType_Tutorial.Instance)
		{
			Instance = this;
		}
	}
}