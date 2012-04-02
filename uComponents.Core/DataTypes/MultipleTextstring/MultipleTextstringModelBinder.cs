﻿using System.Collections.Generic;
using System.Xml;
using umbraco.MacroEngines;

namespace uComponents.Core.DataTypes.MultipleTextstring
{
	/// <summary>
	/// Model binder for the Multiple Textstring data-type.
	/// </summary>
	[RazorDataTypeModel(DataTypeConstants.MultipleTextstringId)]
	public class MultipleTextstringModelBinder : IRazorDataTypeModel
	{
		/// <summary>
		/// Inits the specified current node id.
		/// </summary>
		/// <param name="CurrentNodeId">The current node id.</param>
		/// <param name="PropertyData">The property data.</param>
		/// <param name="instance">The instance.</param>
		/// <returns></returns>
		public bool Init(int CurrentNodeId, string PropertyData, out object instance)
		{
			var xml = new XmlDocument();
			xml.LoadXml(PropertyData);

			var values = new List<string>();
			foreach (XmlNode node in xml.SelectNodes("/values/value"))
			{
				values.Add(node.InnerText);
			}

			instance = values;

			return true;
		}
	}
}