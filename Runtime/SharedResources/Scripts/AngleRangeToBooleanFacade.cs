namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Data.Type.Transformation.Conversion;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface into the AngleRangeToBoolean Prefab.
    /// </summary>
    public class AngleRangeToBooleanFacade : MonoBehaviour
    {
        #region Angle Settings
        [Header("Angle Settings")]
        [Tooltip("The range of the angle to consider true.")]
        [SerializeField]
        [MinMaxRange(-360f, 360f)]
        private FloatRange angleRange = new FloatRange(-180f, 180f);
        /// <summary>
        /// The range of the angle to consider true.
        /// </summary>
        public FloatRange AngleRange
        {
            get
            {
                return angleRange;
            }
            set
            {
                angleRange = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterAngleRangeChange();
                }
            }
        }
        [Tooltip("The units in which to determine the angle range in.")]
        [SerializeField]
        private Vector2ToAngle.AngleUnit unitType = Vector2ToAngle.AngleUnit.SignedDegrees;
        /// <summary>
        /// The units in which to determine the angle range in.
        /// </summary>
        public Vector2ToAngle.AngleUnit UnitType
        {
            get
            {
                return unitType;
            }
            set
            {
                unitType = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterUnitTypeChange();
                }
            }
        }
        #endregion

        #region Axis Settings
        [Header("Axis Settings")]
        [Tooltip("The FloatAction that represents the Horizontal Axis.")]
        [SerializeField]
        private FloatAction horizontalAxis;
        /// <summary>
        /// The <see cref="FloatAction"/> that represents the Horizontal Axis.
        /// </summary>
        public FloatAction HorizontalAxis
        {
            get
            {
                return horizontalAxis;
            }
            set
            {
                horizontalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterHorizontalAxisChange();
                }
            }
        }
        [Tooltip("The FloatAction that represents the Vertical Axis.")]
        [SerializeField]
        private FloatAction verticalAxis;
        /// <summary>
        /// The <see cref="FloatAction"/> that represents the Vertical Axis.
        /// </summary>
        public FloatAction VerticalAxis
        {
            get
            {
                return verticalAxis;
            }
            set
            {
                verticalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterVerticalAxisChange();
                }
            }
        }
        #endregion

        #region Deadzone Settings
        [Header("Deadzone Settings")]
        [Tooltip("The bounds in which the Horizontal Axis is considered inactive.")]
        [SerializeField]
        [MinMaxRange(-1f, 1f)]
        private FloatRange horizontalDeadzone = new FloatRange(-0.75f, 0.75f);
        /// <summary>
        /// The bounds in which the Horizontal Axis is considered inactive.
        /// </summary>
        public FloatRange HorizontalDeadzone
        {
            get
            {
                return horizontalDeadzone;
            }
            set
            {
                horizontalDeadzone = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterHorizontalDeadzoneChange();
                }
            }
        }
        [Tooltip("The bounds in which the Vertical Axis is considered inactive.")]
        [SerializeField]
        [MinMaxRange(-1f, 1f)]
        private FloatRange verticalDeadzone = new FloatRange(-0.75f, 0.75f);
        /// <summary>
        /// The bounds in which the Vertical Axis is considered inactive.
        /// </summary>
        public FloatRange VerticalDeadzone
        {
            get
            {
                return verticalDeadzone;
            }
            set
            {
                verticalDeadzone = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterVerticalDeadzoneChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private AngleRangeToBooleanConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public AngleRangeToBooleanConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="HorizontalAxis"/>.
        /// </summary>
        public virtual void ClearHorizontalAxis()
        {
            if (!this.IsValidState())
            {
                return;
            }

            HorizontalAxis = default;
        }

        /// <summary>
        /// Clears <see cref="VerticalAxis"/>.
        /// </summary>
        public virtual void ClearVerticalAxis()
        {
            if (!this.IsValidState())
            {
                return;
            }

            VerticalAxis = default;
        }

        /// <summary>
        /// Sets the <see cref="AngleRange"/> minimum value.
        /// </summary>
        /// <param name="value">The new minimum value.</param>
        public virtual void SetAngleRangeMinimum(float value)
        {
            FloatRange newLimit = new FloatRange(AngleRange.ToVector2());
            newLimit.minimum = value;
            AngleRange = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="AngleRange"/> maximum value.
        /// </summary>
        /// <param name="value">The new maximum value.</param>
        public virtual void SetAngleRangeMaximum(float value)
        {
            FloatRange newLimit = new FloatRange(AngleRange.ToVector2());
            newLimit.maximum = value;
            AngleRange = newLimit;
        }

        /// <summary>
        /// Sets <see cref="UnitType"/>.
        /// </summary>
        /// <param name="unitTypeIndex">The index of the <see cref="Vector2ToAngle.AngleUnit"/>.</param>
        public virtual void SetUnitType(int unitTypeIndex)
        {
            UnitType = EnumExtensions.GetByIndex<Vector2ToAngle.AngleUnit>(unitTypeIndex);
        }

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

        /// <summary>
        /// Called after <see cref="AngleRange"/> has been changed.
        /// </summary>
        protected virtual void OnAfterAngleRangeChange()
        {
            Configuration.ConfigureAngleChecker();
        }

        /// <summary>
        /// Called after <see cref="UnitType"/> has been changed.
        /// </summary>
        protected virtual void OnAfterUnitTypeChange()
        {
            Configuration.ConfigureAngleInput();
        }

        /// <summary>
        /// Called after <see cref="HorizontalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterHorizontalAxisChange()
        {
            Configuration.ConfigureAngleInput();
        }

        /// <summary>
        /// Called after <see cref="VerticalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterVerticalAxisChange()
        {
            Configuration.ConfigureAngleInput();
        }

        /// <summary>
        /// Called after <see cref="HorizontalDeadzone"/> has been changed.
        /// </summary>
        protected virtual void OnAfterHorizontalDeadzoneChange()
        {
            Configuration.ConfigureAngleInput();
        }

        /// <summary>
        /// Called after <see cref="VerticalDeadzone"/> has been changed.
        /// </summary>
        protected virtual void OnAfterVerticalDeadzoneChange()
        {
            Configuration.ConfigureAngleInput();
        }
    }
}