namespace Tilia.Input.CombinedActions
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// Controls the <see cref="BooleanAction"/> state based on whether the given input action has been activated twice within a given period of time.
    /// </summary>
    public class DoubleClickActionFacade : MonoBehaviour
    {
        #region Action Settings
        /// <summary>
        /// The <see cref="BooleanAction"/> that controls the double click action.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Action Settings"), DocumentedByXml]
        public BooleanAction ControlAction { get; set; }
        /// <summary>
        /// The time between each click can occur to expect the double click action to execute.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float ClickDuration { get; set; } = 1f;
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public DoubleClickActionConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Called after <see cref="ControlAction"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(ControlAction))]
        protected virtual void OnAfterControlActionChange()
        {
            Configuration.ConfigureSourceClickAction(ControlAction);
        }

        /// <summary>
        /// Called after <see cref="ClickDuration"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(ClickDuration))]
        protected virtual void OnAfterClickDurationChange()
        {
            Configuration.ConfigureClickTimer(ClickDuration);
        }
    }
}