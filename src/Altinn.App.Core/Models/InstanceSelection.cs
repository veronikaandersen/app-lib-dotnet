using Newtonsoft.Json;

namespace Altinn.App.Core.Models
{
    /// <summary>
    /// Contains options for displaying the instance selection component
    /// </summary>
    public class InstanceSelection
    {
        /// <summary>
        /// A list of selectable options for amount of rows per page to show for pagination
        /// </summary>
        [JsonProperty(PropertyName = "rowsPerPageOptions")]
        public List<int>? RowsPerPageOptions { get; set; }

        /// <summary>
        /// The direction of sorting the list of instances, asc or desc
        /// </summary>
        [JsonProperty(PropertyName = "sortDirection")]
        public string? SortDirection { get; set; }
    }
}