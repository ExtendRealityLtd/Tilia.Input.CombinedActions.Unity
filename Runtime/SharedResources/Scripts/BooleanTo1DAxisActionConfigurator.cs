namespace Tilia.Input.CombinedActions
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// Sets up the BooleanTo1DAxisAction prefab based on the provided user settings.
    /// </summary>
    public class BooleanTo1DAxisActionConfigurator : MonoBehaviour
    {
        #region Axis Settings
        [Header("Axis Settings")]
        [Tooltip("The BooleanAction that represents the negative direction of the Axis.")]
        [SerializeField]
        [Restricted]
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
            }
        }
        [Tooltip("The BooleanAction that represents the positive direction of the Axis.")]
        [SerializeField]
        [Restricted]
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
            }
        }
        #endregion

        /// <summary>
        /// Adds the given <see cref="source"/> to the <see cref="PositiveInput"/> Sources collection.
        /// </summary>
        /// <param name="source">The <see cref="BooleanAction"/> to add to the Sources collection.</param>
        public virtual void SetPositiveInputSource(BooleanAction source)
        {
            SetInputSource(source, PositiveInput);
        }

        /// <summary>
        /// Adds the given <see cref="source"/> to the <see cref="NegativeInput"/> Sources collection.
        /// </summary>
        /// <param name="source">The <see cref="BooleanAction"/> to add to the Sources collection.</param>
        public virtual void SetNegativeInputSource(BooleanAction source)
        {
            SetInputSource(source, NegativeInput);
        }

        /// <summary>
        /// Sets the adds the <see cref="source"/> to the Sources collection of the <see cref="target"/> <see cref="BooleanAction"/>.
        /// </summary>
        /// <param name="source">The <see cref="BooleanAction"/> to add as a source.</param>
        /// <param name="target">The <see cref="BooleanAction"/> to have the Sources collection updated.</param>
        protected virtual void SetInputSource(BooleanAction source, BooleanAction target)
        {
            target.ClearSources();
            target.AddSource(source);
        }
    }
}