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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The MongoDB database dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MongoDbCollection")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSMongoDbCollectionDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSMongoDbCollectionDataset class.
        /// </summary>
        public PSMongoDbCollectionDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the table name of the MongoDB database. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.collectionName")]
        public object CollectionName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (CollectionName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CollectionName");
            }
        }

        public override Dataset ToSdkObject()
        {
            var dataset = new MongoDbCollectionDataset(this.LinkedServiceName, this.CollectionName);
            SetProperties(dataset);
            return dataset;
        }
    }
}

