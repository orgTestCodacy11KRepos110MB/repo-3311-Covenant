// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CapturedTicketCredential
    {
        /// <summary>
        /// Initializes a new instance of the CapturedTicketCredential class.
        /// </summary>
        public CapturedTicketCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapturedTicketCredential class.
        /// </summary>
        /// <param name="ticketCredentialType">Possible values include: 'RC4',
        /// 'AES'</param>
        /// <param name="type">Possible values include: 'Password', 'Hash',
        /// 'Ticket'</param>
        public CapturedTicketCredential(TicketType? ticketCredentialType = default(TicketType?), string serviceName = default(string), string ticket = default(string), int? id = default(int?), CredentialType? type = default(CredentialType?), string domain = default(string), string username = default(string))
        {
            TicketCredentialType = ticketCredentialType;
            ServiceName = serviceName;
            Ticket = ticket;
            Id = id;
            Type = type;
            Domain = domain;
            Username = username;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'RC4', 'AES'
        /// </summary>
        [JsonProperty(PropertyName = "ticketCredentialType")]
        public TicketType? TicketCredentialType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ticket")]
        public string Ticket { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Password', 'Hash', 'Ticket'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public CredentialType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

    }
}