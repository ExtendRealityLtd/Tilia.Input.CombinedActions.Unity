namespace Tilia.Input.CombinedActions
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Operation.Extraction;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// Converts a lateral, vertical and longitudinal float representation into a Vector3 action.
    /// </summary>
    public class AxesToVector3Action : Vector3Action
    {
        /// <summary>
        /// The way the input is handled.
        /// </summary>
        public enum InputHandler
        {
            /// <summary>
            /// The axis data will be used to incrementally change the <see cref="Vector3"/> value.
            /// </summary>
            Incremental,
            /// <summary>
            /// The axis data will be used to provide a single direction change to the <see cref="Vector3"/> value.
            /// </summary>
            Directional
        }

        /// <summary>
        /// The type of deadzone to apply to the input.
        /// </summary>
        public enum DeadzoneType
        {
            /// <summary>
            /// Each single axis value has its own deadzone applied independently.
            /// </summary>
            SingleAxis,
            /// <summary>
            /// All of the axis deadzone values are combined to form a zonal deadzone.
            /// </summary>
            CombinedAxis
        }

        #region Axis Settings
        /// <summary>
        /// Determines how to handle the axis input data to control the <see cref="Vector3"/> output.
        /// </summary>
        [Serialized]
        [field: Header("Axis Settings"), DocumentedByXml]
        public InputHandler InputType { get; set; } = InputHandler.Incremental;
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Lateral (X Axis)[left/right].
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public FloatAction LateralAxis { get; set; }
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Vertical (Y Axis)[up/down].
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public FloatAction VerticalAxis { get; set; }
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Longitudinal (Z Axis)[forward/backward].
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public FloatAction LongitudinalAxis { get; set; }
        /// <summary>
        /// Multiply the output values.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public Vector3 Multiplier { get; set; } = Vector3.one;
        /// <summary>
        /// Multiply the output values by this <see cref="Time"/> component.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public TimeComponentExtractor.TimeComponent TimeMultiplier { get; set; } = TimeComponentExtractor.TimeComponent.Time;
        #endregion

        #region Deadzone Settings
        /// <summary>
        /// The way in which the deadzone is calculated by the input axes.
        /// </summary>
        [Serialized]
        [field: Header("Deadzone Settings"), DocumentedByXml]
        public DeadzoneType DeadzoneCalculation { get; set; } = DeadzoneType.SingleAxis;
        /// <summary>
        /// The bounds in which the Lateral Axis is considered inactive.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, MinMaxRange(-1f, 1f)]
        public FloatRange LateralDeadzone { get; set; } = new FloatRange(-0.5f, 0.5f);
        /// <summary>
        /// The bounds in which the Vertical Axis is considered inactive.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, MinMaxRange(-1f, 1f)]
        public FloatRange VerticalDeadzone { get; set; } = new FloatRange(-0.5f, 0.5f);
        /// <summary>
        /// The bounds in which the Longitudinal Axis is considered inactive.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, MinMaxRange(-1f, 1f)]
        public FloatRange LongitudinalDeadzone { get; set; } = new FloatRange(-0.5f, 0.5f);
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public AxesToVector3ActionConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Sets <see cref="InputType"/>.
        /// </summary>
        /// <param name="inputTypeIndex">The index of the <see cref="InputHandler"/>.</param>
        public virtual void SetInputType(int inputTypeIndex)
        {
            InputType = (InputHandler)Mathf.Clamp(inputTypeIndex, 0, System.Enum.GetValues(typeof(InputHandler)).Length);
        }

        /// <summary>
        /// Sets the <see cref="Multiplier"/> x value.
        /// </summary>
        /// <param name="value">The value to set to.</param>
        public virtual void SetMultiplierX(float value)
        {
            Multiplier = new Vector3(value, Multiplier.y, Multiplier.z);
        }

        /// <summary>
        /// Sets the <see cref="Multiplier"/> y value.
        /// </summary>
        /// <param name="value">The value to set to.</param>
        public virtual void SetMultiplierY(float value)
        {
            Multiplier = new Vector3(Multiplier.x, value, Multiplier.z);
        }

        /// <summary>
        /// Sets the <see cref="Multiplier"/> z value.
        /// </summary>
        /// <param name="value">The value to set to.</param>
        public virtual void SetMultiplierZ(float value)
        {
            Multiplier = new Vector3(Multiplier.x, Multiplier.y, value);
        }

        /// <summary>
        /// Sets <see cref="TimeMultiplier"/>.
        /// </summary>
        /// <param name="timeMultiplierIndex">The index of the <see cref="TimeComponentExtractor.TimeComponent"/>.</param>
        public virtual void SetTimeMultiplier(int timeMultiplierIndex)
        {
            TimeMultiplier = EnumExtensions.GetByIndex<TimeComponentExtractor.TimeComponent>(timeMultiplierIndex);
        }

        /// <summary>
        /// Sets <see cref="DeadzoneCalculation"/>.
        /// </summary>
        /// <param name="deadzoneTypeIndex">The index of the <see cref="DeadzoneType"/>.</param>
        public virtual void SetDeadzoneCalculation(int deadzoneTypeIndex)
        {
            DeadzoneCalculation = (DeadzoneType)Mathf.Clamp(deadzoneTypeIndex, 0, System.Enum.GetValues(typeof(DeadzoneType)).Length);
        }

        /// <summary>
        /// Sets the <see cref="LateralDeadzone"/> minimum value.
        /// </summary>
        /// <param name="value">The new minimum value.</param>
        public virtual void SetLateralDeadzoneMinimum(float value)
        {
            FloatRange newLimit = new FloatRange(LateralDeadzone.ToVector2());
            newLimit.minimum = value;
            LateralDeadzone = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="LateralDeadzone"/> maximum value.
        /// </summary>
        /// <param name="value">The new maximum value.</param>
        public virtual void SetLateralDeadzoneMaximum(float value)
        {
            FloatRange newLimit = new FloatRange(LateralDeadzone.ToVector2());
            newLimit.maximum = value;
            LateralDeadzone = newLimit;
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

        /// <summary>
        /// Sets the <see cref="LongitudinalDeadzone"/> minimum value.
        /// </summary>
        /// <param name="value">The new minimum value.</param>
        public virtual void SetLongitudinalDeadzoneMinimum(float value)
        {
            FloatRange newLimit = new FloatRange(LongitudinalDeadzone.ToVector2());
            newLimit.minimum = value;
            LongitudinalDeadzone = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="LongitudinalDeadzone"/> maximum value.
        /// </summary>
        /// <param name="value">The new maximum value.</param>
        public virtual void SetLongitudinalDeadzoneMaximum(float value)
        {
            FloatRange newLimit = new FloatRange(LongitudinalDeadzone.ToVector2());
            newLimit.maximum = value;
            LongitudinalDeadzone = newLimit;
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            Configuration.SetInputType(InputType);
            Configuration.SetLateralAxisSource(LateralAxis);
            Configuration.SetVerticalAxisSource(VerticalAxis);
            Configuration.SetLongitudinalAxisSource(LongitudinalAxis);
            Configuration.SetMultiplier(Multiplier);
            Configuration.SetTimeMultiplier(TimeMultiplier);
            Configuration.SetDeadzoneCalculation(DeadzoneCalculation);
            Configuration.SetLateralDeadzone(LateralDeadzone);
            Configuration.SetVerticalDeadzone(VerticalDeadzone);
            Configuration.SetLongitudinalDeadzone(LongitudinalDeadzone);
        }

        /// <summary>
        /// Called after <see cref="InputType"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(InputType))]
        protected virtual void OnAfterInputTypeChange()
        {
            Configuration.SetInputType(InputType);
        }

        /// <summary>
        /// Called after <see cref="LateralAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LateralAxis))]
        protected virtual void OnAfterLateralAxisChange()
        {
            Configuration.SetLateralAxisSource(LateralAxis);
        }

        /// <summary>
        /// Called after <see cref="VerticalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(VerticalAxis))]
        protected virtual void OnAfterVerticalAxisChange()
        {
            Configuration.SetVerticalAxisSource(VerticalAxis);
        }

        /// <summary>
        /// Called after <see cref="LongitudinalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LongitudinalAxis))]
        protected virtual void OnAfterLongitudinalAxisChange()
        {
            Configuration.SetLongitudinalAxisSource(LongitudinalAxis);
        }

        /// <summary>
        /// Called after <see cref="Multiplier"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Multiplier))]
        protected virtual void OnAfterMultiplierChange()
        {
            Configuration.SetMultiplier(Multiplier);
        }

        /// <summary>
        /// Called after <see cref="TimeMultiplier"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(TimeMultiplier))]
        protected virtual void OnAfterTimeMultiplierChange()
        {
            Configuration.SetTimeMultiplier(TimeMultiplier);
        }

        /// <summary>
        /// Called after <see cref="DeadzoneCalculation"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(DeadzoneCalculation))]
        protected virtual void OnAfterDeadzoneCalculationChange()
        {
            Configuration.SetDeadzoneCalculation(DeadzoneCalculation);
        }

        /// <summary>
        /// Called after <see cref="LateralDeadzone"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LateralDeadzone))]
        protected virtual void OnAfterLateralDeadzoneChange()
        {
            Configuration.SetLateralDeadzone(LateralDeadzone);
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
        /// Called after <see cref="LongitudinalDeadzone"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LongitudinalDeadzone))]
        protected virtual void OnAfterLongitudinalDeadzoneChange()
        {
            Configuration.SetLongitudinalDeadzone(LongitudinalDeadzone);
        }
    }
}