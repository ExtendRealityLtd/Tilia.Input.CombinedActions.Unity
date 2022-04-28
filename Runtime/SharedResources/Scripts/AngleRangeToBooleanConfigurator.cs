namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type.Transformation.Conversion;

    /// <summary>
    /// Sets up the AngleRangeToBoolean Prefab based on the provided user settings.
    /// </summary>
    public class AngleRangeToBooleanConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private AngleRangeToBooleanFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public AngleRangeToBooleanFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The FloatToBoolean for checking the angle states.")]
        [SerializeField]
        [Restricted]
        private FloatToBoolean angleChecker;
        /// <summary>
        /// The <see cref="FloatToBoolean"/> for checking the angle states.
        /// </summary>
        public FloatToBoolean AngleChecker
        {
            get
            {
                return angleChecker;
            }
            protected set
            {
                angleChecker = value;
            }
        }
        [Tooltip("The AxesToAngleAction getting the input angle.")]
        [SerializeField]
        [Restricted]
        private AxesToAngleAction angleInput;
        /// <summary>
        /// The <see cref="AxesToAngleAction"/> getting the input angle.
        /// </summary>
        public AxesToAngleAction AngleInput
        {
            get
            {
                return angleInput;
            }
            protected set
            {
                angleInput = value;
            }
        }
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