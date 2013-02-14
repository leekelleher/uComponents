﻿namespace uComponents.DataTypes.DataTypeGrid.Factories
{
    using uComponents.DataTypes.UrlPicker;
    using uComponents.DataTypes.UrlPicker.Dto;

    using umbraco.interfaces;

    /// <summary>
    /// Factory for the <see cref="UrlPickerDataType"/> class.
    /// </summary>
    public class UrlPickerDataTypeFactory : BaseDataTypeFactory<UrlPickerDataType>
    {
        /// <summary>
        /// Method for performing special actions while creating the <see cref="IDataType">datatype</see> editor.
        /// </summary>
        /// <remarks>Called when the grid creates the editor controls for the specified <see cref="IDataType">datatype</see>.</remarks>
        /// <param name="dataType">The <see cref="IDataType">datatype</see> instance.</param>
        /// <param name="container">The editor control container.</param>
        public override void Configure(UrlPickerDataType dataType, System.Web.UI.Control container)
        {
            if (dataType.Data.Value != null && dataType.ContentEditor.State == null)
            {
                dataType.ContentEditor.State = UrlPickerState.Deserialize((string)dataType.Data.Value);
            }
        }
    }
}