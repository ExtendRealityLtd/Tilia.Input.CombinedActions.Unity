namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// Controls the <see cref="BooleanAction"/> state based on whether the given input action has been activated twice within a given period of time.
    /// </summary>
    public class DoubleClickActionFacade : MonoBehaviour
    {
        #region Action Settings
        [Header("Action Settings")]
        [Tooltip("The BooleanAction that controls the double click action.")]
        [SerializeField]
        private BooleanAction controlAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that controls the double click action.
        /// </summary>
        public BooleanAction ControlAction
        {
            get
            {
                return controlAction;
            }
            set
            {
                controlAction = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterControlActionChange();
                }
            }
        }
        [Tooltip("The time between each click can occur to expect the double click action to execute.")]
        [SerializeField]
        private float clickDuration = 1f;
        /// <summary>
        /// The time between each click can occur to expect the double click action to execute.
        /// </summary>
        public float ClickDuration
        {
            get
            {
                return clickDuration;
            }
            set
            {
                clickDuration = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterClickDurationChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private DoubleClickActionConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public DoubleClickActionConfigurator Configuration
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
        /// Clears <see cref="ControlAction"/>.
        /// </summary>
        public virtual void ClearControlAction()
        {
            if (!this.IsValidState())
            {
                return;
            }

            ControlAction = default;
        }

        /// <summary>
        /// Called after <see cref="ControlAction"/> has been changed.
        /// </summary>
        protected virtual void OnAfterControlActionChange()
        {
            Configuration.ConfigureSourceClickAction(ControlAction);
        }

        /// <summary>
        /// Called after <see cref="ClickDuration"/> has been changed.
        /// </summary>
        protected virtual void OnAfterClickDurationChange()
        {
            Configuration.ConfigureClickTimer(ClickDuration);
        }
    }
}