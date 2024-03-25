using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FMOD;
using FMOD.Studio;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Studio23.SS2.AudioSystem.fmod.Data;


namespace Studio23.SS2.Settings.Audio.fmod.editor
{
    public class CreateFModBusEnumEditor : Editor
    {
        //    private static Dictionary<string, string> _bankList = new Dictionary<string, string>();
        //    private static List<string> _busList = new List<string>();
        //    private static string _folderPath = "Assets/Resources/FMOD_Data";
        //    private static string _nameSpace = "Studio23.SS2.Settings.BusAudioSettingsData.fmod.Data";

        //    [MenuItem("Studio-23/Settings/BusAudioSettingsData/FMOD Bus Enum")]
        //    public static void GenerateData()
        //    {
        //        _busList.Clear();
        //        _bankList.Clear();
        //        GetAllData(_folderPath, _nameSpace);
        //    }

        //    private static void GetAllData(string folderPath, string nameSpace, string prefix = "", bool test = false)
        //    {
        //        foreach (var b in FMODUnity.EventManager.Banks)
        //        {
        //            if (!_bankList.ContainsKey(b.Name))
        //            {
        //                _bankList.Add(b.Name, b.Path);
        //            }
        //        }
        //        GetMixerDataList(folderPath, nameSpace, prefix, test);
        //    }


        //    private static void GetMixerDataList(string folderPath, string nameSpace, string prefix, bool test)
        //    {

        //        FMOD.Studio.System.create(out FMOD.Studio.System fmodSystem);
        //        fmodSystem.initialize(8, FMOD.Studio.INITFLAGS.NORMAL, FMOD.INITFLAGS.NORMAL, new IntPtr(0));

        //        for (int i = 0; i < _bankList.Count; i++)
        //        {
        //            fmodSystem.loadBankFile(_bankList.ElementAt(i).Value, LOAD_BANK_FLAGS.NORMAL, out Bank masterBank);
        //        }

        //        fmodSystem.getBankList(out FMOD.Studio.Bank[] allBanks);
        //        foreach (FMOD.Studio.Bank bank in allBanks)
        //        {
        //            var busResult = bank.getBusList(out Bus[] bus);
        //            if (busResult == RESULT.OK)
        //            {
        //                bank.getBusCount(out int busCount);
        //                if (busCount > 0)
        //                {
        //                    foreach (var b in bus)
        //                    {
        //                        b.getPath(out string busPath);
        //                        if (!_busList.Contains(busPath)) _busList.Add(busPath);
        //                    }
        //                }
        //            }
        //        }
        //        fmodSystem.unloadAll();
        //        fmodSystem.release();
        //        GenerateBusList(folderPath, nameSpace, prefix, test);
        //    }

        //    private static void GenerateBusList(string folderPath, string nameSpace, string prefix, bool test)
        //    {
        //        //string filename = $"{prefix}FMODBusList";

        //        //string scriptContent = "";
        //        //if (test)
        //        //{
        //        //    scriptContent += "using Studio23.SS2.AudioSystem.fmod.Data;\n\n";
        //        //}
        //        //scriptContent += $"namespace {nameSpace}\n{{\n";

        //        //scriptContent += $"\tpublic static class {filename}\n\t{{\n";

        //        //for (int i = 0; i < _busList.Count; i++)
        //        //{
        //        //    string busName = _busList[i].Replace("bus:/", "").Replace(" ", "_").Replace("/", "_").Replace("-", "_");
        //        //    if (String.IsNullOrEmpty(busName)) busName = "Master";
        //        //    scriptContent += $"\t\tpublic static readonly string {busName} = \"{_busList[i]}\";\n";
        //        //}
        //        //scriptContent += "\t}\n";
        //        //scriptContent += "}";


        //        string filename = $"{prefix}FMODLocaleList";

        //        string scriptContent = "";
        //        if (test)
        //        {
        //            scriptContent += "using Studio23.SS2.AudioSystem.fmod.Data;\n";
        //        }
        //        scriptContent += "using System.Collections.Generic;\n\n";
        //        scriptContent += $"namespace {nameSpace}\n{{\n";
        //        scriptContent += $"\tpublic enum Language\n";
        //        scriptContent += "\t{";
        //        scriptContent += "\n";

        //        for (int i = 0; i < _bankList.Count; i++)
        //        {
        //            if (_bankList.ElementAt(i).Key.Contains("LOCALE"))
        //            {
        //                var temp = _bankList.ElementAt(i).Key.Split("LOCALE_")[1];
        //                scriptContent += $"\t\t{temp},\n";
        //            }
        //        }
        //        scriptContent += "\t}";
        //        scriptContent += "\n\n";



        //        if (!Directory.Exists(folderPath))
        //        {
        //            Directory.CreateDirectory(folderPath);
        //        }
        //        string scriptPath = Path.Combine(folderPath, $"{filename}.cs");
        //        if (File.Exists(scriptPath))
        //        {
        //            File.Delete(scriptPath);
        //        }

        //        File.WriteAllText(scriptPath, scriptContent);
        //        AssetDatabase.Refresh();
        //    }


        //public override void OnInspectorGUI()
        //{
        //    base.OnInspectorGUI();

        //    FMODBusList = target;

        //    GUILayout.Space(10);
        //    EditorGUILayout.LabelField("Generate Enum", EditorStyles.boldLabel);
        //    GUILayout.Space(5);

        //    if (GUILayout.Button("Generate Enum"))
        //    {
        //        GenerateEnum(busList);
        //        Debug.Log("Enum generated successfully.");
        //    }
        //}

        //private void GenerateEnum(FMODBusList busList)
        //{
        //    string enumName = "FMODBusEnum";
        //    string enumCode = "public enum " + enumName + "\n{\n";

        //    foreach (var field in busList.GetType().GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.FlattenHierarchy))
        //    {
        //        if (field.FieldType == typeof(string))
        //        {
        //            enumCode += "\t" + field.name + ",\n";
        //        }
        //    }

        //    enumCode += "}";

        //    // Create or overwrite existing enum script
        //    string enumFilePath = Application.dataPath + "/Scripts/" + enumName + ".cs";
        //    System.IO.File.WriteAllText(enumFilePath, enumCode);
        //    AssetDatabase.Refresh();
        //}

    }
}
