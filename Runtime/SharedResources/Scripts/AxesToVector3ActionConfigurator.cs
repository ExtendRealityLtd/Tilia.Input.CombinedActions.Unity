namespace Tilia.Input.CombinedActions
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
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
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Lateral (X Axis)[left/right].
        /// </summary>
        [Serialized]
        [field: Header("Axis Settings"), DocumentedByXml, Restricted]
        public FloatAction LateralAction { get; set; }
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Vertical (Y Axis)[up/down].
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatAction VerticalAction { get; set; }
        /// <summary>
        /// The <see cref="FloatAction"/> representing the Longitudinal (Z Axis)[forward/backward].
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatAction LongitudinalAction { get; set; }
        /// <summary>
        /// Whether to automatically configure the deadzones and axis bounds.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool AutoConfigureBounds { get; set; } = true;
        /// <summary>
        /// The value to overlap the directional input bounds by.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float BoundOverlap { get; set; } = 0.09f;
        #endregion

        #region Reference Settings
        /// <summary>
        /// The collection used to multiply the output <see cref="Vector3"/>.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public Vector3ObservableList Multiplier { get; set; }
        /// <summary>
        /// The container that holds the incremental input logic.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject IncrementalContainer { get; set; }
        /// <summary>
        /// The container that holds the directional input logic.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject DirectionalContainer { get; set; }
        /// <summary>
        /// The container that holds the single axis deadzone logic.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject SingleAxisDeadzoneContainer { get; set; }
        /// <summary>
        /// The container that holds the combined axis deadzone logic.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject CombinedAxisDeadzoneContainer { get; set; }
        /// <summary>
        /// The lateral deadzone controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean[] LateralDeadZone { get; set; }
        /// <summary>
        /// The lateral positive bounds controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean LateralPositiveBounds { get; set; }
        /// <summary>
        /// The lateral negative bounds controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean LateralNegativeBounds { get; set; }
        /// <summary>
        /// The lateral bounds manager.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean LateralBoundsManager { get; set; }
        /// <summary>
        /// The vertical deadzone controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean[] VerticalDeadZone { get; set; }
        /// <summary>
        /// The vertical positive bounds controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean VerticalPositiveBounds { get; set; }
        /// <summary>
        /// The vertical negative bounds controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean VerticalNegativeBounds { get; set; }
        /// <summary>
        /// The vertical bounds manager.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean VerticalBoundsManager { get; set; }
        /// <summary>
        /// The longitudinal deadzone controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean[] LongitudinalDeadZone { get; set; }
        /// <summary>
        /// The longitudinal positive bounds controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean LongitudinalPositiveBounds { get; set; }
        /// <summary>
        /// The longitudinal negative bounds controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean LongitudinalNegativeBounds { get; set; }
        /// <summary>
        /// The longitudinal bounds manager.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public FloatToBoolean LongitudinalBoundsManager { get; set; }
        /// <summary>
        /// Extracts a <see cref="Time"/> component.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TimeComponentExtractor TimeExtractor { get; set; }
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