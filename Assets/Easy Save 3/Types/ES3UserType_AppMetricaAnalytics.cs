using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("_levelNumber", "_levelName", "_levelCount", "_levelLoop", "_loopAttempt")]
	public class ES3UserType_AppMetricaAnalytics : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_AppMetricaAnalytics() : base(typeof(Core.SDK.AppMetricaAnalytics)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Core.SDK.AppMetricaAnalytics)obj;
			
			writer.WritePrivateField("_levelNumber", instance);
			writer.WritePrivateField("_levelName", instance);
			writer.WritePrivateField("_levelCount", instance);
			writer.WritePrivateField("_levelLoop", instance);
			writer.WritePrivateField("_loopAttempt", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Core.SDK.AppMetricaAnalytics)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "_levelNumber":
					instance = (Core.SDK.AppMetricaAnalytics)reader.SetPrivateField("_levelNumber", reader.Read<System.Int32>(), instance);
					break;
					case "_levelName":
					instance = (Core.SDK.AppMetricaAnalytics)reader.SetPrivateField("_levelName", reader.Read<System.Int32>(), instance);
					break;
					case "_levelCount":
					instance = (Core.SDK.AppMetricaAnalytics)reader.SetPrivateField("_levelCount", reader.Read<System.Int32>(), instance);
					break;
					case "_levelLoop":
					instance = (Core.SDK.AppMetricaAnalytics)reader.SetPrivateField("_levelLoop", reader.Read<System.Int32>(), instance);
					break;
					case "_loopAttempt":
					instance = (Core.SDK.AppMetricaAnalytics)reader.SetPrivateField("_loopAttempt", reader.Read<System.Int32>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_AppMetricaAnalyticsArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_AppMetricaAnalyticsArray() : base(typeof(Core.SDK.AppMetricaAnalytics[]), ES3UserType_AppMetricaAnalytics.Instance)
		{
			Instance = this;
		}
	}
}