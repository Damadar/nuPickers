﻿namespace nuPickers.DataEditors.XmlDropDownPicker
{
    using EmbeddedResource;
    using Umbraco.Core.PropertyEditors;

    internal class XmlDropDownPickerPreValueEditor : PreValueEditor
    {
        [PreValueField("dataSource", "", EmbeddedResource.ROOT_URL + "XmlDataSource/XmlDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [PreValueField("relationMapping", "", EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfig.html", HideLabel = true)]
        public string RelationMapping { get; set; }

        [PreValueField("saveFormat", "Save Format", EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}
