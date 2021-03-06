#if UNITY_EDITOR

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEditor;
using static UnityEditor.AssetDatabase;
using static System.IO.Path;
using static UnityEngine.Application;

namespace Editor
{
    public static class ToolsMenu
    {
        #region Directories

        [MenuItem("Tools/Folders/Create all")]
        static void CreateAllDirectories()
        {
            CreateScenesFolder();
            CreateScriptFolder();
            CreateSoundsFolder();
            CreatePrefabsFolder();
            CreateResourcesFolder();
            CreateArtFolder();
            CreateFontsFolder();
        }

        [MenuItem("Tools/Folders/Scripts")]
        static void CreateScriptFolder()
        {
            CreateDirectory("Scripts");
        }

        [MenuItem("Tools/Folders/Scenes")]
        static void CreateScenesFolder()
        {
            CreateDirectory("Scenes");
        }

        [MenuItem("Tools/Folders/Sounds")]
        static void CreateSoundsFolder()
        {
            CreateDirectory("Sounds");
        }

        [MenuItem("Tools/Folders/Prefabs")]
        static void CreatePrefabsFolder()
        {
            CreateDirectory("Prefabs");
        }

        [MenuItem("Tools/Folders/Resources")]
        static void CreateResourcesFolder()
        {
            CreateDirectory("Resources");
        }

        [MenuItem("Tools/Folders/Art")]
        static void CreateArtFolder()
        {
            CreateDirectory("Art");
        }

        [MenuItem("Tools/Folders/Fonts")]
        static void CreateFontsFolder()
        {
            CreateDirectory("Fonts");
        }

        #endregion

        #region Scripts

        [MenuItem("Tools/Scripts/Others/Helpers")]
        static async void LoadHelperFunctionsScript()
        {
            var url = GetGistUrl("c07619ecc1844e8101060572947e452c");
            var contents = await GetContents(url);
            CreateScriptFile("Helpers", contents);
        }

        [MenuItem("Tools/Scripts/Others/PlayerPrefsX")]
        static async void LoadPlayerPrefsXScript()
        {
            var url = GetGistUrl("73305515e58b98cd2ad070ca72ee8895");
            var contents = await GetContents(url);
            CreateScriptFile("PlayerPrefsX", contents);
        }

        [MenuItem("Tools/Scripts/Others/ArdaTween")]
        static async void LoadArdaTweenScript()
        {
            var url = GetGistUrl("8291c7c970dbd00db9037a015f233730");
            var contents = await GetContents(url);
            CreateScriptFile("ArdaTween", contents);
        }

        [MenuItem("Tools/Scripts/Others/iTween")]
        static async void LoadiTweenScript()
        {
            var url = GetGistUrl("5ab971d7c1332942763c04d279814268");
            var contents = await GetContents(url);
            CreateScriptFile("iTween", contents);
        }

        [MenuItem("Tools/Scripts/Others/Scene Controller")]
        static async void LoadSceneControllerScript()
        {
            var url = GetGistUrl("1552f8b8e4ab26136892c38d135f2391");
            var contents = await GetContents(url);
            CreateScriptFile("SceneController", contents);
        }

        [MenuItem("Tools/Scripts/Others/Screenshot")]
        static async void LoadScreenshotScript()
        {
            var url = GetGistUrl("7368c8e45635d948b8b9d381160f8b2e");
            var contents = await GetContents(url);
            CreateScriptFile("Screenshot", contents);
        }

        [MenuItem("Tools/Scripts/Others/Admob Controller")]
        static async void LoadAdmobControllerScript()
        {
            var url = GetGistUrl("ee2a8d89c679af08d120c6b3fd923931");
            var contents = await GetContents(url);
            CreateScriptFile("AdmobController", contents);
        }

        [MenuItem("Tools/Scripts/Others/Vibration")]
        static async void LoadVibrationScript()
        {
            var url = GetGistUrl("2042c86dfbe7e511cd00dbe6317b81f0");
            var contents = await GetContents(url);
            CreateScriptFile("Vibration", contents);
        }

        [MenuItem("Tools/Scripts/Others/Input Manager")]
        static async void LoadInputManagerScript()
        {
            var url = GetGistUrl("4ed9fa5fdaf64c2b5876117b140578e1");
            var contents = await GetContents(url);
            CreateScriptFile("InputManager", contents);
        }

        [MenuItem("Tools/Scripts/Others/Shake Camera")]
        static async void LoadShakeCameraScript()
        {
            var url = GetGistUrl("2ef7a75196218a762385628395b8b6c7");
            var contents = await GetContents(url);
            CreateScriptFile("ShakeCamera", contents);
        }

        [MenuItem("Tools/Scripts/Others/Object Pool")]
        static async void LoadObjectPoolScript()
        {
            var url = GetGistUrl("d8cce8d8869f8ec4f56b555bb85d9e9a");
            var contents = await GetContents(url);
            CreateScriptFile("ObjectPool", contents);
        }

        [MenuItem("Tools/Scripts/Others/Easing Function")]
        static async void LoadEasingFunctionScript()
        {
            var url = GetGistUrl("3821683f2ba08664596a8cf9cfba8f40");
            var contents = await GetContents(url);
            CreateScriptFile("EasingFunction", contents);
        }


        [MenuItem("Tools/Scripts/Others/Dragger")]
        static async void LoadDraggerScript()
        {
            var url = GetGistUrl("ce5cf10376ea6d7e15061717fb94dd51");
            var contents = await GetContents(url);
            CreateScriptFile("Dragger", contents);
        }

        [MenuItem("Tools/Scripts/Others/No Clip Fly")]
        static async void LoadNoClipFlyScript()
        {
            var url = GetGistUrl("53f6d33b2658ec444ea37350146b192d");
            var contents = await GetContents(url);
            CreateScriptFile("NoClipFly", contents);
        }

        [MenuItem("Tools/Scripts/Others/Sound manager")]
        static async void LoadSoundManagerScript()
        {
            var url = GetGistUrl("86fc52d4af7e83e08ffae949a67690dc");
            var contents = await GetContents(url);
            CreateScriptFile("SoundManager", contents);
        }

        [MenuItem("Tools/Scripts/Others/Swipe Manager")]
        static async void LoadSwipeManagerScript()
        {
            var url = GetGistUrl("e52485fa43fbfa7678d65190c2a58aa0");
            var contents = await GetContents(url);
            CreateScriptFile("SwipeManager", contents);
        }

        [MenuItem("Tools/Scripts/Others/Bootstrapper")]
        static async void LoadBootstrapperScript()
        {
            var url = GetGistUrl("d5f6f0088b15ec146e942d9e34c1593b");
            var contents = await GetContents(url);
            CreateScriptFile("Bootstrapper", contents);
        }

        [MenuItem("Tools/Scripts/Others/Vibration and Native")]
        static async void LoadVibrationAndNativeScripts()
        {
            var url = GetGistUrl("2042c86dfbe7e511cd00dbe6317b81f0", "Vibration", "cs");
            var contents = await GetContents(url);
            CreateScriptFile("Vibration", contents);

            var url2 = GetGistUrl("2042c86dfbe7e511cd00dbe6317b81f0", "Native", "cs");
            var contents2 = await GetContents(url2);
            CreateScriptFile("Native", contents2);
        }

        [MenuItem("Tools/Scripts/Others/Serializable Dictionary and KeyValuePair")]
        static async void LoadSerializableDictionaryAndKeyValuePairScripts()
        {
            var url = GetGistUrl("eea761fee785b5072a6559a8146f6199", "DictionaryUnity", "cs");
            var contents = await GetContents(url);
            CreateScriptFile("DictionaryUnity", contents);

            var url2 = GetGistUrl("eea761fee785b5072a6559a8146f6199", "KeyValuePairUnity", "cs");
            var contents2 = await GetContents(url2);
            CreateScriptFile("KeyValuePairUnity", contents2);
        }

        [MenuItem("Tools/Scripts/Others/Page Controller")]
        static async void LoadPageControllerScripts()
        {
            var url = GetGistUrl("c818f069c8bf08de05b0de2fd81b5b9f", "PageController", "cs");
            var contents = await GetContents(url);
            CreateScriptFile("PageController", contents);

            var url2 = GetGistUrl("c818f069c8bf08de05b0de2fd81b5b9f", "Pages", "cs");
            var contents2 = await GetContents(url2);
            CreateScriptFile("Pages", contents2);

            LoadListExtensionsScript();
            LoadSerializableDictionaryAndKeyValuePairScripts();
        }

        #endregion

        #region Extension Methods

        [MenuItem("Tools/Scripts/Extension Methods/All Extensions")]
        static void LoadAllExtensionsScripts()
        {
            LoadGameObjectExtensionsScript();
            LoadFloatExtensionsScript();
            LoadTransformExtensionsScript();
            LoadStringExtensionsScript();
            LoadImageExtensionsScript();
            LoadListExtensionsScript();
        }

        [MenuItem("Tools/Scripts/Extension Methods/Transform Extensions")]
        static async void LoadTransformExtensionsScript()
        {
            var url = GetGistUrl("b548d42ffb2145198e57912a7bb1d0d3");
            var contents = await GetContents(url);
            CreateScriptFile("TransformExtensions", contents, "Extensions");
        }

        [MenuItem("Tools/Scripts/Extension Methods/GameObject Extensions")]
        static async void LoadGameObjectExtensionsScript()
        {
            var url = GetGistUrl("26fb6f529b9270328d968bae2096712e");
            var contents = await GetContents(url);
            CreateScriptFile("GameObjectExtensions", contents, "Extensions");
        }

        [MenuItem("Tools/Scripts/Extension Methods/Float Extensions")]
        static async void LoadFloatExtensionsScript()
        {
            var url = GetGistUrl("50cc7923690080e08d130b236051fda3");
            var contents = await GetContents(url);
            CreateScriptFile("FloatExtensions", contents, "Extensions");
        }

        [MenuItem("Tools/Scripts/Extension Methods/String Extensions")]
        static async void LoadStringExtensionsScript()
        {
            var url = GetGistUrl("3704403725b2fce34b3a7eb449f18d4e");
            var contents = await GetContents(url);
            CreateScriptFile("StringExtensions", contents, "Extensions");
        }

        [MenuItem("Tools/Scripts/Extension Methods/Image Extensions")]
        static async void LoadImageExtensionsScript()
        {
            var url = GetGistUrl("e225b6c6efd4fafd52fecf9b4c226a30");
            var contents = await GetContents(url);
            CreateScriptFile("ImageExtensions", contents, "Extensions");
        }

        [MenuItem("Tools/Scripts/Extension Methods/List Extensions")]
        static async void LoadListExtensionsScript()
        {
            var url = GetGistUrl("d1cdc6a1f0c83ac65faf82acdaeb40c7");
            var contents = await GetContents(url);
            CreateScriptFile("ListExtensions", contents, "Extensions");
        }

        #endregion


        #region Helpers

        static string GetGistUrl(string id, string user = "ardaerbaharli") =>
            $"https://gist.github.com/{user}/{id}/raw";

        static string GetGistUrl(string id, string scriptName, string fileExtension, string user = "ardaerbaharli") =>
            $"https://gist.github.com/{user}/{id}/raw/{scriptName}.{fileExtension}";

        static async Task<string> GetContents(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
        }

        static void CreateDirectory(string directoryName)
        {
            var path = Path.Combine(dataPath, directoryName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            Refresh();
        }

        static void CreateScriptFile(string fileName, string contents)
        {
            var path = Combine(dataPath, "Scripts");
            CreateDirectory(path);

            path = Combine(path, $"{fileName}.cs");
            File.WriteAllText(path, contents);
            Refresh();
        }

        static void CreateScriptFile(string fileName, string contents, params string[] dir)
        {
            var root = Combine(dataPath, "Scripts");
            CreateDirectory(root);


            foreach (var newDirectory in dir)
            {
                root = Combine(root, newDirectory);
                CreateDirectory(root);
            }

            var path = Combine(root, $"{fileName}.cs");
            File.WriteAllText(path, contents);
            Refresh();
        }

        #endregion

        #region UI Elements

        [MenuItem("Tools/Scripts/UI Elements/Toggle Switch")]
        static async void LoadToggleSwitchScript()
        {
            var url = GetGistUrl("ca1b74784200f8991a559cbac7f36df0");
            var contents = await GetContents(url);
            CreateScriptFile("ToggleSwitch", contents);
        }

        [MenuItem("Tools/Scripts/UI Elements/Double Switch")]
        static async void LoadDoubleSwitchScript()
        {
            var url = GetGistUrl("be2b70be410192606be85cdd6592d77d");
            var contents = await GetContents(url);
            CreateScriptFile("DoubleSwitch", contents);
        }

        [MenuItem("Tools/Scripts/UI Elements/Range Slider")]
        static async void LoadRangeSliderScript()
        {
            var url = GetGistUrl("592ce9f3b18c4cbba9fd6b2961801174", "RangeSlider", "cs");
            var contents = await GetContents(url);
            CreateScriptFile("RangeSlider", contents);

            var url2 = GetGistUrl("592ce9f3b18c4cbba9fd6b2961801174", "SliderHandle", "cs");
            var contents2 = await GetContents(url2);
            CreateScriptFile("SliderHandle", contents2);
        }
    
        [MenuItem("Tools/Scripts/UI Elements/Display FPS")]
        static async void LoadDisplayFPSScript()
        {
            var url = GetGistUrl("1c783f1c6a2df7b39c7832e983f118c6");
            var contents = await GetContents(url);
            CreateScriptFile("DisplayFPS", contents);
        }

        [MenuItem("Tools/Scripts/UI Elements/Loading Screen")]
        static async void LoadLoadingScreenScript()
        {
            var url = GetGistUrl("acf22314b3371f1e5bec7b6148842f43");
            var contents = await GetContents(url);
            CreateScriptFile("LoadingScreenManager", contents);
        }

        #endregion
    }
}
#endif