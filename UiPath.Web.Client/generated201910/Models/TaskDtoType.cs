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
    /// Defines values for TaskDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskDtoType
    {
        [EnumMember(Value = "FormTask")]
        FormTask
    }
    internal static class TaskDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this TaskDtoType? value)
        {
            return value == null ? null : ((TaskDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskDtoType value)
        {
            switch( value )
            {
                case TaskDtoType.FormTask:
                    return "FormTask";
            }
            return null;
        }

        internal static TaskDtoType? ParseTaskDtoType(this string value)
        {
            switch( value )
            {
                case "FormTask":
                    return TaskDtoType.FormTask;
            }
            return null;
        }
    }
}