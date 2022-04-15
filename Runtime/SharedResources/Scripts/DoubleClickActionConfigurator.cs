namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Utility;

    /// <summary>
    /// Sets up the DoubleClickAction prefab based on the provided user settings.
    /// </summary>
    public class DoubleClickActionConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private DoubleClickActionFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public DoubleClickActionFacade Facade
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
        [Tooltip("The BooleanAction that handles the first click state.")]
        [SerializeField]
        [Restricted]
        private BooleanAction firstClickAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the first click state.
        /// </summary>
        public BooleanAction FirstClickAction
        {
            get
            {
                return firstClickAction;
            }
            protected set
            {
                firstClickAction = value;
            }
        }
        [Tooltip("The BooleanAction that handles the second click state.")]
        [SerializeField]
        [Restricted]
        private BooleanAction secondClickAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the second click state.
        /// </summary>
        public BooleanAction SecondClickAction
        {
            get
            {
                return secondClickAction;
            }
            protected set
            {
                secondClickAction = value;
            }
        }
        [Tooltip("The BooleanAction that handles the final double click state.")]
        [SerializeField]
        [Restricted]
        private BooleanAction doubleClickAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the final double click state.
        /// </summary>
        public BooleanAction DoubleClickAction
        {
            get
            {
                return doubleClickAction;
            }
            protected set
            {
                doubleClickAction = value;
            }
        }
        [Tooltip("The BooleanAction that handles the final output state.")]
        [SerializeField]
        [Restricted]
        private BooleanAction outputAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the final output state.
        /// </summary>
        public BooleanAction OutputAction
        {
            get
            {
                return outputAction;
            }
            protected set
            {
                outputAction = value;
            }
        }
        [Tooltip("The CountdownTimer that handles the delay between clicks.")]
        [SerializeField]
        [Restricted]
        private CountdownTimer clickTimer;
        /// <summary>
        /// The <see cref="CountdownTimer"/> that handles the delay between clicks.
        /// </summary>
        public CountdownTimer ClickTimer
        {
            get
            {
                return clickTimer;
            }
            protected set
            {
                clickTimer = value;
            }
        }
        #endregion

        /// <summary>
        /// Configures the source action for the double click to monitor.
        /// </summary>
        /// <param name="source">The source action.</param>
        public virtual void ConfigureSourceClickAction(BooleanAction source)
        {
            FirstClickAction.RunWhenActiveAndEnabled(() => FirstClickAction.ClearSources());
            FirstClickAction.RunWhenActiveAndEnabled(() => FirstClickAction.AddSource(source));
            SecondClickAction.RunWhenActiveAndEnabled(() => SecondClickAction.ClearSources());
            SecondClickAction.RunWhenActiveAndEnabled(() => SecondClickAction.AddSource(source));
            SecondClickAction.RunWhenActiveAndEnabled(() => SecondClickAction.gameObject.SetActive(false));
        }

        /// <summary>
        /// Configures the timer for the monitored delay between clicks.
        /// </summary>
        /// <param name="clickDuration">The duration in which the double click must take place.</param>
        public virtual void ConfigureClickTimer(float clickDuration)
        {
            ClickTimer.StartTime = clickDuration;
        }

        protected virtual void OnEnable()
        {
            FirstClickAction.gameObject.SetActive(true);
            SecondClickAction.gameObject.SetActive(true);
            ConfigureSourceClickAction(Facade.ControlAction);
            ConfigureClickTimer(Facade.ClickDuration);
        }
    }
}