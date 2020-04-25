﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.using System

using Microsoft.Azure.Documents;
using WSBNports.Models;

namespace WSBNports.Infrastructure.Data
{
    public interface IDocumentCollectionContext<in T> where T : Entity
    {
        string CollectionName { get; }

        string GenerateId(T entity);

        PartitionKey ResolvePartitionKey(string entityId);
    }
}
