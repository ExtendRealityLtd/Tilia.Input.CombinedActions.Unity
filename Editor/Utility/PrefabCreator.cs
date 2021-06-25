namespace Tilia.Input.CombinedActions.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Input/CombinedActions/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.input.combinedactions.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCombinedActionsAngleRangeToBoolean = "Input.CombinedActions.AngleRangeToBoolean";
        private const string prefabCombinedActionsAxesToAngle = "Input.CombinedActions.AxesToAngle";
        private const string prefabCombinedActionsAxesToVector3Action = "Input.CombinedActions.AxesToVector3Action";
        private const string prefabCombinedActionsBooleanTo1DAxisAction = "Input.CombinedActions.BooleanTo1DAxisAction";
        private const string prefabCombinedActionsDoubleClickAction = "Input.CombinedActions.DoubleClickAction";

        [MenuItem(menuItemRoot + prefabCombinedActionsAngleRangeToBoolean, false, priority)]
        private static void AddCombinedActionsAngleRangeToBoolean()
        {
            string prefab = prefabCombinedActionsAngleRangeToBoolean + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabCombinedActionsAxesToAngle, false, priority)]
        private static void AddCombinedActionsAxesToAngle()
        {
            string prefab = prefabCombinedActionsAxesToAngle + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabCombinedActionsAxesToVector3Action, false, priority)]
        private static void AddCombinedActionsAxesToVector3Action()
        {
            string prefab = prefabCombinedActionsAxesToVector3Action + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabCombinedActionsBooleanTo1DAxisAction, false, priority)]
        private static void AddCombinedActionsBooleanTo1DAxisAction()
        {
            string prefab = prefabCombinedActionsBooleanTo1DAxisAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabCombinedActionsDoubleClickAction, false, priority)]
        private static void AddCombinedActionsDoubleClickAction()
        {
            string prefab = prefabCombinedActionsDoubleClickAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}