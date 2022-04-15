namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// Converts a the given axis data into an output angle.
    /// </summary>
    public class AxesToAngleAction : FloatAction
    {
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
        [Tooltip("An optional GameObject to be used as the direction offset for the output axis angle.")]
        [SerializeField]
        private GameObject directionOffset;
        /// <summary>
        /// An optional <see cref="GameObject"/> to be used as the direction offset for the output axis angle.
        /// </summary>
        public GameObject DirectionOffset
        {
            get
            {
                return directionOffset;
            }
            set
            {
                directionOffset = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterDirectionOffsetChange();
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
        private AxesToAngleActionConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public AxesToAngleActionConfigurator Configuration
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
        /// Clears <see cref="DirectionOffset"/>.
        /// </summary>
        public virtual void ClearDirectionOffset()
        {
            if (!this.IsValidState())
            {
                return;
            }

            DirectionOffset = default;
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
        protected virtual void OnAfterHorizontalAxisChange()
        {
            Configuration.SetHorizontalInputSource(HorizontalAxis);
        }

        /// <summary>
        /// Called after <see cref="VerticalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterVerticalAxisChange()
        {
            Configuration.SetVerticalInputSource(VerticalAxis);
        }

        /// <summary>
        /// Called after <see cref="HorizontalDeadzone"/> has been changed.
        /// </summary>
        protected virtual void OnAfterHorizontalDeadzoneChange()
        {
            Configuration.SetHorizontalDeadzone(HorizontalDeadzone);
        }

        /// <summary>
        /// Called after <see cref="VerticalDeadzone"/> has been changed.
        /// </summary>
        protected virtual void OnAfterVerticalDeadzoneChange()
        {
            Configuration.SetVerticalDeadzone(VerticalDeadzone);
        }

        /// <summary>
        /// Called after <see cref="DirectionOffset"/> has been changed.
        /// </summary>
        protected virtual void OnAfterDirectionOffsetChange()
        {
            Configuration.SetDirectionExtractorSource(DirectionOffset);
        }
    }
}