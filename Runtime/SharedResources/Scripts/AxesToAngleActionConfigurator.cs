namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Operation.Extraction;
    using Zinnia.Data.Type;
    using Zinnia.Data.Type.Transformation.Conversion;

    /// <summary>
    /// Sets up the AxesToAngleAction prefab based on the provided user settings.
    /// </summary>
    public class AxesToAngleActionConfigurator : MonoBehaviour
    {
        #region Axis Settings
        [Header("Axis Settings")]
        [Tooltip("The FloatAction that represents the Horizontal Axis.")]
        [SerializeField]
        [Restricted]
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
            }
        }
        [Tooltip("The FloatAction that represents the Vertical Axis.")]
        [SerializeField]
        [Restricted]
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
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The horizontal deadzone controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean horizontalDeadZone;
        /// <summary>
        /// The horizontal deadzone controller.
        /// </summary>
        public FloatToBoolean HorizontalDeadZone
        {
            get
            {
                return horizontalDeadZone;
            }
            set
            {
                horizontalDeadZone = value;
            }
        }
        [Tooltip("The vertical deadzone controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean verticalDeadZone;
        /// <summary>
        /// The vertical deadzone controller.
        /// </summary>
        public FloatToBoolean VerticalDeadZone
        {
            get
            {
                return verticalDeadZone;
            }
            set
            {
                verticalDeadZone = value;
            }
        }
        [Tooltip("The direction extractor for the direction offset.")]
        [SerializeField]
        [Restricted]
        private TransformDirectionExtractor directionExtractor;
        /// <summary>
        /// The direction extractor for the direction offset.
        /// </summary>
        public TransformDirectionExtractor DirectionExtractor
        {
            get
            {
                return directionExtractor;
            }
            set
            {
                directionExtractor = value;
            }
        }
        [Tooltip("The vector2 to angle converter.")]
        [SerializeField]
        [Restricted]
        private Vector2ToAngle angleConverter;
        /// <summary>
        /// The vector2 to angle converter.
        /// </summary>
        public Vector2ToAngle AngleConverter
        {
            get
            {
                return angleConverter;
            }
            set
            {
                angleConverter = value;
            }
        }
        #endregion

        /// <summary>
        /// Adds the given <see cref="source"/> to the <see cref="HorizontalAxis"/> Sources collection.
        /// </summary>
        /// <param name="source">The <see cref="FloatAction"/> to add to the Sources collection.</param>
        public virtual void SetHorizontalInputSource(FloatAction source)
        {
            SetInputSource(source, HorizontalAxis);
        }

        /// <summary>
        /// Adds the given <see cref="source"/> to the <see cref="VerticalAxis"/> Sources collection.
        /// </summary>
        /// <param name="source">The <see cref="FloatAction"/> to add to the Sources collection.</param>
        public virtual void SetVerticalInputSource(FloatAction source)
        {
            SetInputSource(source, VerticalAxis);
        }

        /// <summary>
        /// Sets the Horizontal Deadzone.
        /// </summary>
        /// <param name="source">The <see cref="FloatRange"/> for the deadzone.</param>
        public virtual void SetHorizontalDeadzone(FloatRange source)
        {
            SetDeadzone(source, HorizontalDeadZone);
        }

        /// <summary>
        /// Sets the Vertical Deadzone.
        /// </summary>
        /// <param name="source">The <see cref="FloatRange"/> for the deadzone.</param>
        public virtual void SetVerticalDeadzone(FloatRange source)
        {
            SetDeadzone(source, VerticalDeadZone);
        }

        /// <summary>
        /// Sets the source of the direction extractor.
        /// </summary>
        /// <param name="source">The <see cref="GameObject"/> for the source.</param>
        public virtual void SetDirectionExtractorSource(GameObject source)
        {
            DirectionExtractor.Source = source;
            DirectionExtractor.gameObject.SetActive(source != null);
        }

        /// <summary>
        /// Sets the adds the <see cref="source"/> to the Sources collection of the <see cref="target"/> <see cref="FloatAction"/>.
        /// </summary>
        /// <param name="source">The <see cref="FloatAction"/> to add as a source.</param>
        /// <param name="target">The <see cref="FloatAction"/> to have the Sources collection updated.</param>
        protected virtual void SetInputSource(FloatAction source, FloatAction target)
        {
            target.ClearSources();
            target.AddSource(source);
        }

        /// <summary>
        /// Sets the <see cref="target"/> deadzone based on the given <see cref="source"/>.
        /// </summary>
        /// <param name="source">The new deadzone range.</param>
        /// <param name="target">The range to update.</param>
        protected virtual void SetDeadzone(FloatRange source, FloatToBoolean target)
        {
            target.SetPositiveBounds(source.ToVector2());
        }
    }
}