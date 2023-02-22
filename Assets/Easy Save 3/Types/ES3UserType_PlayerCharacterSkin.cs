using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("_headType", "_armsType", "_bodyType", "_legsType")]
	public class ES3UserType_PlayerCharacterSkin : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_PlayerCharacterSkin() : base(typeof(BlueStellar.Cor.PlayerCharacterSkin)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (BlueStellar.Cor.PlayerCharacterSkin)obj;
			
			writer.WritePrivateField("_headType", instance);
			writer.WritePrivateField("_armsType", instance);
			writer.WritePrivateField("_bodyType", instance);
			writer.WritePrivateField("_legsType", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (BlueStellar.Cor.PlayerCharacterSkin)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "_headType":
					instance = (BlueStellar.Cor.PlayerCharacterSkin)reader.SetPrivateField("_headType", reader.Read<BlueStellar.Cor.CharacterMonsterType>(), instance);
					break;
					case "_armsType":
					instance = (BlueStellar.Cor.PlayerCharacterSkin)reader.SetPrivateField("_armsType", reader.Read<BlueStellar.Cor.CharacterMonsterType>(), instance);
					break;
					case "_bodyType":
					instance = (BlueStellar.Cor.PlayerCharacterSkin)reader.SetPrivateField("_bodyType", reader.Read<BlueStellar.Cor.CharacterMonsterType>(), instance);
					break;
					case "_legsType":
					instance = (BlueStellar.Cor.PlayerCharacterSkin)reader.SetPrivateField("_legsType", reader.Read<BlueStellar.Cor.CharacterMonsterType>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_PlayerCharacterSkinArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_PlayerCharacterSkinArray() : base(typeof(BlueStellar.Cor.PlayerCharacterSkin[]), ES3UserType_PlayerCharacterSkin.Instance)
		{
			Instance = this;
		}
	}
}