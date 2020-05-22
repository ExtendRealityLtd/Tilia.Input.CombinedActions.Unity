namespace Tilia.Input.CombinedActions
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;

    /// <summary>
    /// The public interface into the AngleRangeToBoolean Prefab.
    /// </summary>
    public class AngleRangeToBooleanFacade : MonoBehaviour
    {
        #region Angle Settings
        /// <summary>
        /// The range of the angle to consider true.
        /// </summary>
        [Serialized]
        [field: Header("Target Settings"), DocumentedByXml, MinMaxRange(-180f, 180f)]
        public FloatRange AngleRange { get; set; } = new FloatRange(-180f, 180f);
        #endregion

        #region Axis Settings
        /// <summary>
        /// The <see cref="FloatAction"/> that represents the Horizontal Axis.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Axis Settings"), DocumentedByXml]
        public FloatAction HorizontalAxis { get; set; }
        /// <summary>
        /// The <see cref="FloatAction"/> that represents the Vertical Axis.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public FloatAction VerticalAxis { get; set; }
        #endregion

        #region Deadzone Settings
        /// <summary>
        /// The bounds in which the Horizontal Axis is considered inactive.
        /// </summary>
        [Serialized]
        [field: Header("Deadzone Settings"), DocumentedByXml, MinMaxRange(-1f, 1f)]
        public FloatRange HorizontalDeadzone { get; set; } = new FloatRange(-0.75f, 0.75f);
        /// <summary>
        /// The bounds in which the Vertical Axis is considered inactive.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, MinMaxRange(-1f, 1f)]
        public FloatRange VerticalDeadzone { get; set; } = new FloatRange(-0.75f, 0.75f);
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public AngleRangeToBooleanConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Called after <see cref="AngleRange"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(AngleRange))]
        protected virtual void OnAfterAngleRangeChange()
        {
            Configuration.ConfigureAngleChecker();
        }

        /// <summary>
        /// Called after <see cref="HorizontalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(HorizontalAxis))]
        protected virtual void OnAfterHorizontalAxisChange()
        {
            Configuration.ConfigureAngleInput();
        }

        /// <summary>
        /// Called after <see cref="VerticalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(VerticalAxis))]
        protected virtual void OnAfterVerticalAxisChange()
        {
            Configuration.ConfigureAngleInput();
        }

        /// <summary>
        /// Called after <see cref="HorizontalDeadzone"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(HorizontalDeadzone))]
        protected virtual void OnAfterHorizontalDeadzoneChange()
        {
            Configuration.ConfigureAngleInput();
        }

        /// <summary>
        /// Called after <see cref="VerticalDeadzone"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(VerticalDeadzone))]
        protected virtual void OnAfterVerticalDeadzoneChange()
        {
            Configuration.ConfigureAngleInput();
        }
    }
}