using UnityEditor;

public class MyEditorScript
{
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/StartMenu.unity" };
        BuildPipeline.BuildPlayer(
            defaultScene, "Build/Test.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None);

    }
}
