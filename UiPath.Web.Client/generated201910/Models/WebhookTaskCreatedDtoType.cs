// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebhookTaskCreatedDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookTaskCreatedDtoType
    {
        [EnumMember(Value = "FormTask")]
        FormTask
    }
    internal static class WebhookTaskCreatedDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookTaskCreatedDtoType? value)
        {
            return value == null ? null : ((WebhookTaskCreatedDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookTaskCreatedDtoType value)
        {
            switch( value )
            {
                case WebhookTaskCreatedDtoType.FormTask:
                    return "FormTask";
            }
            return null;
        }

        internal static WebhookTaskCreatedDtoType? ParseWebhookTaskCreatedDtoType(this string value)
        {
            switch( value )
            {
                case "FormTask":
                    return WebhookTaskCreatedDtoType.FormTask;
            }
            return null;
        }
    }
}