namespace Tilia.Input.CombinedActions
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
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
        /// <summary>
        /// The public interface facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public DoubleClickActionFacade Facade { get; protected set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the first click state.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public BooleanAction FirstClickAction { get; protected set; }
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the second click state.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public BooleanAction SecondClickAction { get; protected set; }
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the final double click state.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public BooleanAction DoubleClickAction { get; protected set; }
        /// <summary>
        /// The <see cref="BooleanAction"/> that handles the final output state.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public BooleanAction OutputAction { get; protected set; }
        /// <summary>
        /// The <see cref="CountdownTimer"/> that handles the delay between clicks.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public CountdownTimer ClickTimer { get; protected set; }
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