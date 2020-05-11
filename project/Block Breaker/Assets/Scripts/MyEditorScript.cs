using UnityEditor;

public class MyEditorScript
{
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/StartMenu.unity",
                                    "Assets/Scenes/Level 1.unity",
                                    "Assets/Scenes/Level 2.unity",
                                    "Assets/Scenes/Level 3.unity",
                                    "Assets/Scenes/Level 4.unity",
                                    "Assets/Scenes/Level 5.unity",
                                     "Assets/Scenes/Game Over.unity"};
        BuildPipeline.BuildPlayer(
            defaultScene, "Build/Test.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None);

    }
}
