namespace Tilia.Input.CombinedActions
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type.Transformation.Conversion;

    /// <summary>
    /// Sets up the AngleRangeToBoolean Prefab based on the provided user settings.
    /// </summary>
    public class AngleRangeToBooleanConfigurator : MonoBehaviour
    {
        #region Facade Settings
        /// <summary>
        /// The public interface facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public AngleRangeToBooleanFacade Facade { get; protected set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The <see cref="FloatToBoolean"/> for checking the angle states.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public FloatToBoolean AngleChecker { get; protected set; }
        /// <summary>
        /// The <see cref="AxesToAngleAction"/> getting the input angle.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public AxesToAngleAction AngleInput { get; protected set; }
        #endregion

        /// <summary>
        /// Configures the <see cref="AngleChecker"/> properties.
        /// </summary>
        public virtual void ConfigureAngleChecker()
        {
            AngleChecker.SetPositiveBounds(Facade.AngleRange.ToVector2());
        }

        /// <summary>
        /// Configures the <see cref="AngleInput"/> properties.
        /// </summary>
        public virtual void ConfigureAngleInput()
        {
            AngleInput.HorizontalAxis = Facade.HorizontalAxis;
            AngleInput.VerticalAxis = Facade.VerticalAxis;
            AngleInput.HorizontalDeadzone = Facade.HorizontalDeadzone;
            AngleInput.VerticalDeadzone = Facade.VerticalDeadzone;
            AngleInput.Configuration.AngleConverter.Unit = Facade.UnitType;
        }

        protected virtual void OnEnable()
        {
            ConfigureAngleChecker();
            ConfigureAngleInput();
        }
    }
}