// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Web linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Web")]
    public partial class PSWebLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSWebLinkedService class.
        /// </summary>
        public PSWebLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets web linked service properties.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties")]
        public WebLinkedServiceTypeProperties TypeProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (TypeProperties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeProperties");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new WebLinkedService(this.TypeProperties);
            SetProperties(linkedService);
            return linkedService;
        }
    }
}

