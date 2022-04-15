namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// Converts a positive and negative boolean representation into a 1D axis float action.
    /// </summary>
    public class BooleanTo1DAxisAction : FloatAction
    {
        #region Axis Settings
        [Header("Axis Settings")]
        [Tooltip("The BooleanAction that represents the negative direction of the Axis.")]
        [SerializeField]
        private BooleanAction negativeInput;
        /// <summary>
        /// The <see cref="BooleanAction"/> that represents the negative direction of the Axis.
        /// </summary>
        public BooleanAction NegativeInput
        {
            get
            {
                return negativeInput;
            }
            set
            {
                negativeInput = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterNegativeInputChange();
                }
            }
        }
        [Tooltip("The BooleanAction that represents the positive direction of the Axis.")]
        [SerializeField]
        private BooleanAction positiveInput;
        /// <summary>
        /// The <see cref="BooleanAction"/> that represents the positive direction of the Axis.
        /// </summary>
        public BooleanAction PositiveInput
        {
            get
            {
                return positiveInput;
            }
            set
            {
                positiveInput = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterPositiveInputChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private BooleanTo1DAxisActionConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public BooleanTo1DAxisActionConfigurator Configuration
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
        /// Clears <see cref="NegativeInput"/>.
        /// </summary>
        public virtual void ClearNegativeInput()
        {
            if (!this.IsValidState())
            {
                return;
            }

            NegativeInput = default;
        }

        /// <summary>
        /// Clears <see cref="PositiveInput"/>.
        /// </summary>
        public virtual void ClearPositiveInput()
        {
            if (!this.IsValidState())
            {
                return;
            }

            PositiveInput = default;
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            Configuration.SetPositiveInputSource(PositiveInput);
            Configuration.SetNegativeInputSource(NegativeInput);
        }

        /// <summary>
        /// Called after <see cref="PositiveInput"/> has been changed.
        /// </summary>
        protected virtual void OnAfterPositiveInputChange()
        {
            Configuration.SetPositiveInputSource(PositiveInput);
        }

        /// <summary>
        /// Called after <see cref="NegativeInput"/> has been changed.
        /// </summary>
        protected virtual void OnAfterNegativeInputChange()
        {
            Configuration.SetNegativeInputSource(NegativeInput);
        }
    }
}