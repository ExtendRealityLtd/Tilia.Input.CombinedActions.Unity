namespace Tilia.Input.CombinedActions
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// Sets up the BooleanTo1DAxisAction prefab based on the provided user settings.
    /// </summary>
    public class BooleanTo1DAxisActionConfigurator : MonoBehaviour
    {
        #region Axis Settings
        /// <summary>
        /// The <see cref="BooleanAction"/> that represents the negative direction of the Axis.
        /// </summary>
        [Serialized]
        [field: Header("Axis Settings"), DocumentedByXml, Restricted]
        public BooleanAction NegativeInput { get; set; }
        /// <summary>
        /// The <see cref="BooleanAction"/> that represents the positive direction of the Axis.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public BooleanAction PositiveInput { get; set; }
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