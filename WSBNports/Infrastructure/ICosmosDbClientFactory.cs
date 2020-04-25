// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.using System

namespace WSBNports.Infrastructure.Data
{
    public interface ICosmosDbClientFactory
    {
        ICosmosDbClient GetClient(string collectionName);
    }
}
