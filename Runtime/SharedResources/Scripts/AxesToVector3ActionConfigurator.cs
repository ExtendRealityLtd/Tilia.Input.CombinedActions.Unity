namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Collection.List;
    using Zinnia.Data.Operation.Extraction;
    using Zinnia.Data.Type;
    using Zinnia.Data.Type.Transformation.Conversion;

    /// <summary>
    /// Sets up the AxesToVector3Action prefab based on the provided user settings.
    /// </summary>
    public class AxesToVector3ActionConfigurator : MonoBehaviour
    {
        #region Axis Settings
        [Header("Axis Settings")]
        [Tooltip("The FloatAction representing the Lateral (X Axis)[left/right].")]
        [SerializeField]
        [Restricted]
        private FloatAction lateralAction;
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Lateral (X Axis)[left/right].
        /// </summary>
        public FloatAction LateralAction
        {
            get
            {
                return lateralAction;
            }
            set
            {
                lateralAction = value;
            }
        }
        [Tooltip("The FloatAction representing the Vertical (Y Axis)[up/down].")]
        [SerializeField]
        [Restricted]
        private FloatAction verticalAction;
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Vertical (Y Axis)[up/down].
        /// </summary>
        public FloatAction VerticalAction
        {
            get
            {
                return verticalAction;
            }
            set
            {
                verticalAction = value;
            }
        }
        [Tooltip("The FloatAction representing the Longitudinal (Z Axis)[forward/backward].")]
        [SerializeField]
        [Restricted]
        private FloatAction longitudinalAction;
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Longitudinal (Z Axis)[forward/backward].
        /// </summary>
        public FloatAction LongitudinalAction
        {
            get
            {
                return longitudinalAction;
            }
            set
            {
                longitudinalAction = value;
            }
        }
        [Tooltip("Whether to automatically configure the deadzones and axis bounds.")]
        [SerializeField]
        [Restricted]
        private bool autoConfigureBounds = true;
        /// <summary>
        /// Whether to automatically configure the deadzones and axis bounds.
        /// </summary>
        public bool AutoConfigureBounds
        {
            get
            {
                return autoConfigureBounds;
            }
            set
            {
                autoConfigureBounds = value;
            }
        }
        [Tooltip("The value to overlap the directional input bounds by.")]
        [SerializeField]
        [Restricted]
        private float boundOverlap = 0.09f;
        /// <summary>
        /// The value to overlap the directional input bounds by.
        /// </summary>
        public float BoundOverlap
        {
            get
            {
                return boundOverlap;
            }
            set
            {
                boundOverlap = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The collection used to multiply the output Vector3.")]
        [SerializeField]
        [Restricted]
        private Vector3ObservableList multiplier;
        /// <summary>
        /// The collection used to multiply the output <see cref="Vector3"/>.
        /// </summary>
        public Vector3ObservableList Multiplier
        {
            get
            {
                return multiplier;
            }
            set
            {
                multiplier = value;
            }
        }
        [Tooltip("The container that holds the incremental input logic.")]
        [SerializeField]
        [Restricted]
        private GameObject incrementalContainer;
        /// <summary>
        /// The container that holds the incremental input logic.
        /// </summary>
        public GameObject IncrementalContainer
        {
            get
            {
                return incrementalContainer;
            }
            set
            {
                incrementalContainer = value;
            }
        }
        [Tooltip("The container that holds the directional input logic.")]
        [SerializeField]
        [Restricted]
        private GameObject directionalContainer;
        /// <summary>
        /// The container that holds the directional input logic.
        /// </summary>
        public GameObject DirectionalContainer
        {
            get
            {
                return directionalContainer;
            }
            set
            {
                directionalContainer = value;
            }
        }
        [Tooltip("The container that holds the single axis deadzone logic.")]
        [SerializeField]
        [Restricted]
        private GameObject singleAxisDeadzoneContainer;
        /// <summary>
        /// The container that holds the single axis deadzone logic.
        /// </summary>
        public GameObject SingleAxisDeadzoneContainer
        {
            get
            {
                return singleAxisDeadzoneContainer;
            }
            set
            {
                singleAxisDeadzoneContainer = value;
            }
        }
        [Tooltip("The container that holds the combined axis deadzone logic.")]
        [SerializeField]
        [Restricted]
        private GameObject combinedAxisDeadzoneContainer;
        /// <summary>
        /// The container that holds the combined axis deadzone logic.
        /// </summary>
        public GameObject CombinedAxisDeadzoneContainer
        {
            get
            {
                return combinedAxisDeadzoneContainer;
            }
            set
            {
                combinedAxisDeadzoneContainer = value;
            }
        }
        [Tooltip("The lateral deadzone controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean[] lateralDeadZone = new FloatToBoolean[0];
        /// <summary>
        /// The lateral deadzone controller.
        /// </summary>
        public FloatToBoolean[] LateralDeadZone
        {
            get
            {
                return lateralDeadZone;
            }
            set
            {
                lateralDeadZone = value;
            }
        }
        [Tooltip("The lateral positive bounds controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean lateralPositiveBounds;
        /// <summary>
        /// The lateral positive bounds controller.
        /// </summary>
        public FloatToBoolean LateralPositiveBounds
        {
            get
            {
                return lateralPositiveBounds;
            }
            set
            {
                lateralPositiveBounds = value;
            }
        }
        [Tooltip("The lateral negative bounds controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean lateralNegativeBounds;
        /// <summary>
        /// The lateral negative bounds controller.
        /// </summary>
        public FloatToBoolean LateralNegativeBounds
        {
            get
            {
                return lateralNegativeBounds;
            }
            set
            {
                lateralNegativeBounds = value;
            }
        }
        [Tooltip("The lateral bounds manager.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean lateralBoundsManager;
        /// <summary>
        /// The lateral bounds manager.
        /// </summary>
        public FloatToBoolean LateralBoundsManager
        {
            get
            {
                return lateralBoundsManager;
            }
            set
            {
                lateralBoundsManager = value;
            }
        }
        [Tooltip("The vertical deadzone controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean[] verticalDeadZone = new FloatToBoolean[0];
        /// <summary>
        /// The vertical deadzone controller.
        /// </summary>
        public FloatToBoolean[] VerticalDeadZone
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
        [Tooltip("The vertical positive bounds controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean verticalPositiveBounds;
        /// <summary>
        /// The vertical positive bounds controller.
        /// </summary>
        public FloatToBoolean VerticalPositiveBounds
        {
            get
            {
                return verticalPositiveBounds;
            }
            set
            {
                verticalPositiveBounds = value;
            }
        }
        [Tooltip("The vertical negative bounds controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean verticalNegativeBounds;
        /// <summary>
        /// The vertical negative bounds controller.
        /// </summary>
        public FloatToBoolean VerticalNegativeBounds
        {
            get
            {
                return verticalNegativeBounds;
            }
            set
            {
                verticalNegativeBounds = value;
            }
        }
        [Tooltip("The vertical bounds manager.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean verticalBoundsManager;
        /// <summary>
        /// The vertical bounds manager.
        /// </summary>
        public FloatToBoolean VerticalBoundsManager
        {
            get
            {
                return verticalBoundsManager;
            }
            set
            {
                verticalBoundsManager = value;
            }
        }
        [Tooltip("The longitudinal deadzone controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean[] longitudinalDeadZone = new FloatToBoolean[0];
        /// <summary>
        /// The longitudinal deadzone controller.
        /// </summary>
        public FloatToBoolean[] LongitudinalDeadZone
        {
            get
            {
                return longitudinalDeadZone;
            }
            set
            {
                longitudinalDeadZone = value;
            }
        }
        [Tooltip("The longitudinal positive bounds controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean longitudinalPositiveBounds;
        /// <summary>
        /// The longitudinal positive bounds controller.
        /// </summary>
        public FloatToBoolean LongitudinalPositiveBounds
        {
            get
            {
                return longitudinalPositiveBounds;
            }
            set
            {
                longitudinalPositiveBounds = value;
            }
        }
        [Tooltip("The longitudinal negative bounds controller.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean longitudinalNegativeBounds;
        /// <summary>
        /// The longitudinal negative bounds controller.
        /// </summary>
        public FloatToBoolean LongitudinalNegativeBounds
        {
            get
            {
                return longitudinalNegativeBounds;
            }
            set
            {
                longitudinalNegativeBounds = value;
            }
        }
        [Tooltip("The longitudinal bounds manager.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean longitudinalBoundsManager;
        /// <summary>
        /// The longitudinal bounds manager.
        /// </summary>
        public FloatToBoolean LongitudinalBoundsManager
        {
            get
            {
                return longitudinalBoundsManager;
            }
            set
            {
                longitudinalBoundsManager = value;
            }
        }
        [Tooltip("Extracts a Time component.")]
        [SerializeField]
        [Restricted]
        private TimeComponentExtractor timeExtractor;
        /// <summary>
        /// Extracts a <see cref="Time"/> component.
        /// </summary>
        public TimeComponentExtractor TimeExtractor
        {
            get
            {
                return timeExtractor;
            }
            set
            {
                timeExtractor = value;
            }
        }
        #endregion

        /// <summary>
        /// Adds the given <see cref="source"/> to the <see cref="LateralAction"/> Sources collection.
        /// </summary>
        /// <param name="source">The <see cref="FloatAction"/> to add to the Sources collection.</param>
        public virtual void SetLateralAxisSource(FloatAction source)
        {
            SetInputSource(source, LateralAction);
        }

        /// <summary>
        /// Adds the given <see cref="source"/> to the <see cref="VerticalAction"/> Sources collection.
        /// </summary>
        /// <param name="source">The <see cref="FloatAction"/> to add to the Sources collection.</param>
        public virtual void SetVerticalAxisSource(FloatAction source)
        {
            SetInputSource(source, VerticalAction);
        }

        /// <summary>
        /// Adds the given <see cref="source"/> to the <see cref="LongitudinalAction"/> Sources collection.
        /// </summary>
        /// <param name="source">The <see cref="FloatAction"/> to add to the Sources collection.</param>
        public virtual void SetLongitudinalAxisSource(FloatAction source)
        {
            SetInputSource(source, LongitudinalAction);
        }

        /// <summary>
        /// Sets the state of the relevant input type GameObjects.
        /// </summary>
        /// <param name="inputType">The current input type to use.</param>
        public virtual void SetInputType(AxesToVector3Action.InputHandler inputType)
        {
            switch (inputType)
            {
                case AxesToVector3Action.InputHandler.Incremental:
                    DirectionalContainer.SetActive(false);
                    IncrementalContainer.SetActive(true);
                    break;
                case AxesToVector3Action.InputHandler.Directional:
                    IncrementalContainer.SetActive(false);
                    DirectionalContainer.SetActive(true);
                    break;
            }
        }

        /// <summary>
        /// Sets the output multiplier.
        /// </summary>
        /// <param name="multiplier">The new multiplier to use.</param>
        public virtual void SetMultiplier(Vector3 multiplier)
        {
            Multiplier.SetAt(multiplier, 2);
        }

        /// <summary>
        /// Enables the appropriate Deadzone Calculation logic.
        /// </summary>
        /// <param name="deadzoneType">The type of deadzone to use.</param>
        public virtual void SetDeadzoneCalculation(AxesToVector3Action.DeadzoneType deadzoneType)
        {
            switch (deadzoneType)
            {
                case AxesToVector3Action.DeadzoneType.SingleAxis:
                    CombinedAxisDeadzoneContainer.SetActive(false);
                    SingleAxisDeadzoneContainer.SetActive(true);
                    break;
                case AxesToVector3Action.DeadzoneType.CombinedAxis:
                    SingleAxisDeadzoneContainer.SetActive(false);
                    CombinedAxisDeadzoneContainer.SetActive(true);
                    break;
            }
        }

        /// <summary>
        /// Sets the deadzone for the lateral axis.
        /// </summary>
        /// <param name="deadzone">The deadzone range to set to.</param>
        public virtual void SetLateralDeadzone(FloatRange deadzone)
        {
            SetBounds(deadzone, LateralDeadZone, LateralPositiveBounds, LateralNegativeBounds, LateralBoundsManager);
        }

        /// <summary>
        /// Sets the deadzone for the vertical axis.
        /// </summary>
        /// <param name="deadzone">The deadzone range to set to.</param>
        public virtual void SetVerticalDeadzone(FloatRange deadzone)
        {
            SetBounds(deadzone, VerticalDeadZone, VerticalPositiveBounds, VerticalNegativeBounds, VerticalBoundsManager);
        }

        /// <summary>
        /// Sets the deadzone for the longitudinal axis.
        /// </summary>
        /// <param name="deadzone">The deadzone range to set to.</param>
        public virtual void SetLongitudinalDeadzone(FloatRange deadzone)
        {
            SetBounds(deadzone, LongitudinalDeadZone, LongitudinalPositiveBounds, LongitudinalNegativeBounds, LongitudinalBoundsManager);
        }

        /// <summary>
        /// Sets the <see cref="Time"/> source type to multiply by.
        /// </summary>
        /// <param name="component">The component to multiply by.</param>
        public virtual void SetTimeMultiplier(TimeComponentExtractor.TimeComponent component)
        {
            TimeExtractor.Source = component;
        }

        /// <summary>
        /// Sets the boundary data for the input.
        /// </summary>
        /// <param name="newBounds">Thew new range for the bounds.</param>
        /// <param name="deadzone">The axis deadzone to set.</param>
        /// <param name="positiveBounds">The axis positive bounds to set.</param>
        /// <param name="negativeBounds">The axis negative bounds to set.</param>
        /// <param name="boundsManager">The axis bounds manager to set.</param>
        protected virtual void SetBounds(FloatRange newBounds, FloatToBoolean[] deadzone, FloatToBoolean positiveBounds, FloatToBoolean negativeBounds, FloatToBoolean boundsManager)
        {
            foreach (FloatToBoolean zone in deadzone)
            {
                zone.SetPositiveBounds(newBounds.ToVector2());
            }

            positiveBounds.SetPositiveBounds(new Vector2(newBounds.maximum, 1f));
            negativeBounds.SetPositiveBounds(new Vector2(-1f, newBounds.minimum));
            boundsManager.SetPositiveBounds(new Vector2(Mathf.Max(-1f, newBounds.minimum - BoundOverlap), Mathf.Min(newBounds.maximum + BoundOverlap, 1f)));
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
    }
}