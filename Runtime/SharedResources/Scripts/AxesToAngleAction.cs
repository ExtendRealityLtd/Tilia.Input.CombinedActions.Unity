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
    /// Converts a the given axis data into an output angle.
    /// </summary>
    public class AxesToAngleAction : FloatAction
    {
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
        /// <summary>
        /// An optional <see cref="GameObject"/> to be used as the direction offset for the output axis angle.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public GameObject DirectionOffset { get; set; }
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
        public AxesToAngleActionConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Sets the <see cref="HorizontalDeadzone"/> minimum value.
        /// </summary>
        /// <param name="value">The new minimum value.</param>
        public virtual void SetHorizontalDeadzoneMinimum(float value)
        {
            FloatRange newLimit = new FloatRange(HorizontalDeadzone.ToVector2());
            newLimit.minimum = value;
            HorizontalDeadzone = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="HorizontalDeadzone"/> maximum value.
        /// </summary>
        /// <param name="value">The new maximum value.</param>
        public virtual void SetHorizontalDeadzoneMaximum(float value)
        {
            FloatRange newLimit = new FloatRange(HorizontalDeadzone.ToVector2());
            newLimit.maximum = value;
            HorizontalDeadzone = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="VerticalDeadzone"/> minimum value.
        /// </summary>
        /// <param name="value">The new minimum value.</param>
        public virtual void SetVerticalDeadzoneMinimum(float value)
        {
            FloatRange newLimit = new FloatRange(VerticalDeadzone.ToVector2());
            newLimit.minimum = value;
            VerticalDeadzone = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="VerticalDeadzone"/> maximum value.
        /// </summary>
        /// <param name="value">The new maximum value.</param>
        public virtual void SetVerticalDeadzoneMaximum(float value)
        {
            FloatRange newLimit = new FloatRange(VerticalDeadzone.ToVector2());
            newLimit.maximum = value;
            VerticalDeadzone = newLimit;
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            Configuration.SetHorizontalInputSource(HorizontalAxis);
            Configuration.SetVerticalInputSource(VerticalAxis);
            Configuration.SetHorizontalDeadzone(HorizontalDeadzone);
            Configuration.SetVerticalDeadzone(VerticalDeadzone);
            Configuration.SetDirectionExtractorSource(DirectionOffset);
        }

        /// <summary>
        /// Called after <see cref="HorizontalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(HorizontalAxis))]
        protected virtual void OnAfterHorizontalAxisChange()
        {
            Configuration.SetHorizontalInputSource(HorizontalAxis);
        }

        /// <summary>
        /// Called after <see cref="VerticalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(VerticalAxis))]
        protected virtual void OnAfterVerticalAxisChange()
        {
            Configuration.SetVerticalInputSource(VerticalAxis);
        }

        /// <summary>
        /// Called after <see cref="HorizontalDeadzone"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(HorizontalDeadzone))]
        protected virtual void OnAfterHorizontalDeadzoneChange()
        {
            Configuration.SetHorizontalDeadzone(HorizontalDeadzone);
        }

        /// <summary>
        /// Called after <see cref="VerticalDeadzone"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(VerticalDeadzone))]
        protected virtual void OnAfterVerticalDeadzoneChange()
        {
            Configuration.SetVerticalDeadzone(VerticalDeadzone);
        }

        /// <summary>
        /// Called after <see cref="DirectionOffset"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(DirectionOffset))]
        protected virtual void OnAfterDirectionOffsetChange()
        {
            Configuration.SetDirectionExtractorSource(DirectionOffset);
        }
    }
}