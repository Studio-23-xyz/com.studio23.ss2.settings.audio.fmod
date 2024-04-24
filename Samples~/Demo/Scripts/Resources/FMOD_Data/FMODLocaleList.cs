using Studio23.SS2.AudioSystem.fmod.Data;
using System.Collections.Generic;

namespace com.studio23.ss2.settings.audio.fmod.Sample
{
	public enum Language
	{
		BN,
		CN,
		EN,
		JP,
	}

	public static class FMODLocaleList
	{
		public static Dictionary<Language, string> LanguageList = new Dictionary<Language, string>
		{
			{Language.BN, "Assets/Samples/Audio System for FMOD/0.1.7/Audio System for FMOD Example/Sample_FMOD_Project/Build/Desktop/DialogueTable_LOCALE_BN.bank"},
			{Language.CN, "Assets/Samples/Audio System for FMOD/0.1.7/Audio System for FMOD Example/Sample_FMOD_Project/Build/Desktop/DialogueTable_LOCALE_CN.bank"},
			{Language.EN, "Assets/Samples/Audio System for FMOD/0.1.7/Audio System for FMOD Example/Sample_FMOD_Project/Build/Desktop/DialogueTable_LOCALE_EN.bank"},
			{Language.JP, "Assets/Samples/Audio System for FMOD/0.1.7/Audio System for FMOD Example/Sample_FMOD_Project/Build/Desktop/DialogueTable_LOCALE_JP.bank"},
		};
	}
}