namespace Tilia.Input.CombinedActions
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// Converts a positive and negative boolean representation into a 1D axis float action.
    /// </summary>
    public class BooleanTo1DAxisAction : FloatAction
    {
        #region Axis Settings
        /// <summary>
        /// The <see cref="BooleanAction"/> that represents the negative direction of the Axis.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Axis Settings"), DocumentedByXml]
        public BooleanAction NegativeInput { get; set; }
        /// <summary>
        /// The <see cref="BooleanAction"/> that represents the positive direction of the Axis.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public BooleanAction PositiveInput { get; set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public BooleanTo1DAxisActionConfigurator Configuration { get; protected set; }
        #endregion

        protected override void OnEnable()
        {
            base.OnEnable();
            Configuration.SetPositiveInputSource(PositiveInput);
            Configuration.SetNegativeInputSource(NegativeInput);
        }

        /// <summary>
        /// Called after <see cref="PositiveInput"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(PositiveInput))]
        protected virtual void OnAfterPositiveInputChange()
        {
            Configuration.SetPositiveInputSource(PositiveInput);
        }

        /// <summary>
        /// Called after <see cref="NegativeInput"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(NegativeInput))]
        protected virtual void OnAfterNegativeInputChange()
        {
            Configuration.SetNegativeInputSource(NegativeInput);
        }
    }
}